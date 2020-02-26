using Nekretnine.Mobile.Views;
using Nekretnine.Model.Models;
using Nekretnine.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Nekretnine.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Klijent");
        private readonly APIService _serviceGenerateHashHelper = new APIService("GenerateHashHelper");
        public int _KlijentId { get; set; }
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            RegisterComand = new Command( () =>  Register());
        }

        string _userName = string.Empty;

        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        string _password = string.Empty;

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterComand { get; set; }

        public void Register()
        {
            Application.Current.MainPage = new RegisterPage();
        }

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = UserName;
            APIService.Password = Password;
            if(UserName.Length.Equals(0) || Password.Length.Equals(0))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Popunite sva polja", "OK");
                return;
            }
            try
            {
                await _service.Get<List<dynamic>>(null);
                KlijentSearchRequest klijentSearch = new KlijentSearchRequest();
                klijentSearch.Username = APIService.Username;
                klijentSearch.Status = true;

                var korisnici = await _service.Get<List<Model.Models.Klijent>>(klijentSearch);

                if (korisnici.Count > 0)
                {
                    var k = korisnici.FirstOrDefault();
                    GenerateHashSearch search = new GenerateHashSearch();
                    search.LozinkaSalt = k.LozinkaSalt;
                    search.LozinkaHash = APIService.Password;
                    var pwHas=await _serviceGenerateHashHelper.GenerateHash2<Model.Models.GenerateHashGet>(search);
                    //string pwHash = GenerateHash(k.LozinkaSalt, APIService.Password);

                    if (k.Username == klijentSearch.Username && k.LozinkaHash ==pwHas.Hash)
                    {
                        _KlijentId = k.KlijentId;
                        Application.Current.MainPage = new MainPage(_KlijentId);
                    }
                    else
                        throw new Exception("Unos nije ispravan");
                }
                else
                    throw new Exception("User ne postoji");
            }
            catch (Exception ex)
            {
                string msg = "";
                if (ex.InnerException != null)
                    msg = ex.InnerException.ToString() + " - ";
                await Application.Current.MainPage.DisplayAlert("Greška", msg + ex.Message, "OK");
            }
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
