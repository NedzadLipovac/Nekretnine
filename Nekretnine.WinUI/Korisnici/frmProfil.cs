using Nekretnine.Model.Requests;
using Nekretnine.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nekretnine.WinUI.Korisnici
{
    partial class frmProfil : Form
    {
        private readonly APIService _KorisniciService = new APIService("Korisnik");
        private readonly APIService _gradService = new APIService("Grad");
        private KorisnikUpsertRequest korisnik = new KorisnikUpsertRequest();
        bool izmjena = false;
        private int _KorisnikId { get; set; }
        public frmProfil(int id)
        {
            _KorisnikId = id;
            InitializeComponent();
         
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajSLiku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var filename = openFileDialog1.FileName;

                var file = File.ReadAllBytes(filename);

                korisnik.Slika = file;
                Image image = Image.FromFile(filename);
                Image thumb = image.GetThumbnailImage(75, 75, () => false, IntPtr.Zero);

                ImageConverter _imageConverter = new ImageConverter();
                byte[] imagethumbbyte = (byte[])_imageConverter.ConvertTo(thumb, typeof(byte[]));
                korisnik.SlikaThumb = imagethumbbyte;
                pictureBox1.Image = image;
            }
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            var provjera =  this.ValidateChildren();
            string error1 = errorProvider1.GetError(txtEmail);
            string error2 = errorProvider1.GetError(txtUsername);
            string error3 = errorProvider1.GetError(txtStariPassword);
            if (!string.IsNullOrEmpty(error1) || !string.IsNullOrEmpty(error2) || !string.IsNullOrEmpty(error3))
                provjera = false;

            if (provjera)
            {
                var GradObj = cmbGrad.SelectedValue;
                if (int.TryParse(GradObj.ToString(), out int GradId))
                {
                    korisnik.GradId = GradId;
                }

                var user = await _KorisniciService.GetById<Model.Models.Korisnik>(_KorisnikId);
                //var uloge = user.KorisniciUloge.Select(x => x.UlogaId).ToList();

                korisnik.KorisnikId = _KorisnikId;
                korisnik.Ime = txtIme.Text;
                korisnik.Prezime = txtPrezime.Text;
                korisnik.Adresa = txtAdresa.Text;
                korisnik.Username = txtUsername.Text;
                korisnik.Email = txtEmail.Text;
                korisnik.Telefon = txtTelefon.Text;
                korisnik.DatumRodjenja = user.DatumRodjenja;
                korisnik.Status = true;
                //korisnik.Uloge = uloge;

                if (txtStariPassword.Text != "")
                {
                    korisnik.Password = txtPassword.Text;
                    korisnik.PasswordPotvrda = txtPotvrdaPassworda.Text;
                }
                var entity =  await _KorisniciService.Update<Model.Models.Korisnik>(_KorisnikId, korisnik);
                if (entity != null)
                {
                    MessageBox.Show("Podaci uspješno izmjenjeni");
                    txtPassword.Clear();
                    txtPotvrdaPassworda.Clear();
                    txtStariPassword.Clear();
       

                } 
            }

        }
        private async Task LoadGradovi(ComboBox cmb)
        {
            var result = await _gradService.Get<List<Model.Models.Grad>>(null);
            result.Insert(0, new Model.Models.Grad());

            ComboBoxLoad<Model.Models.Grad> cmbLoad = new ComboBoxLoad<Model.Models.Grad>();
            cmbLoad.Load(cmb, result, "Naziv", "GradId");
        }

        private async void frmProfil_Load(object sender, EventArgs e)
        {
          
            var user = await _KorisniciService.GetById<Model.Models.Korisnik>(_KorisnikId);
            var grad = await _gradService.GetById<Model.Models.Grad>(user.GradId);

            await LoadGradovi(cmbGrad);

            korisnik.Ime = user.Ime;
            korisnik.Prezime = user.Prezime;
            korisnik.Adresa = user.Adresa;
            korisnik.Username = user.Username;
            korisnik.Email = user.Email;
            korisnik.Telefon = user.Telefon;
            korisnik.GradId = user.GradId;
            if (user.Slika != null)
            {
                korisnik.Slika = user.Slika;
                byte[] slika = user.Slika;
                MemoryStream memoryStream = new MemoryStream(slika);
                pictureBox1.Image = Image.FromStream(memoryStream);
            }
            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
            txtAdresa.Text = korisnik.Adresa;
            txtUsername.Text = korisnik.Username;
            txtEmail.Text = korisnik.Email;
            txtTelefon.Text = korisnik.Telefon;
            cmbGrad.SelectedIndex = cmbGrad.FindString(grad.Naziv);
        }

        #region Validation
        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
            }


        }
        private async void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            izmjena = false;
            if (!string.IsNullOrEmpty(txtPassword.Text) || !string.IsNullOrEmpty(txtPotvrdaPassworda.Text) || !string.IsNullOrEmpty(txtStariPassword.Text))
            {
                izmjena = true;
            }

            //Ako nije unesena stara lozinka
            if (string.IsNullOrEmpty(txtStariPassword.Text) && izmjena)
            {
                errorProvider1.SetError(txtStariPassword, Properties.Resources.OldPassword);
                e.Cancel = true;
            }

            else if (!string.IsNullOrEmpty(txtStariPassword.Text) && izmjena)
            {
                var user = await _KorisniciService.GetById<Model.Models.Korisnik>(_KorisnikId);

                string hash = GenerateHash(user.LozinkaSalt, txtStariPassword.Text);

                if (user.LozinkaHash != hash)
                {
                    errorProvider1.SetError(txtStariPassword, Properties.Resources.OldPassword);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txtStariPassword, null);
                }
            }
            else if (!string.IsNullOrEmpty(txtStariPassword.Text) && !izmjena)
            {
                errorProvider1.SetError(txtStariPassword, null);
            }
        }
        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private async void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            bool postoji = false;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                KorisnikSearchRequest korisniciSearch = new KorisnikSearchRequest()
                {
                    Status = true,
                    Username = txtUsername.Text
                };


                var user = await _KorisniciService.Get<List<Model.Models.Korisnik>>(korisniciSearch);
                if (user.Count > 0)
                {
                    foreach (var item in user)
                    {
                        if (item.KorisnikId != _KorisnikId)
                            postoji = true;
                    }
                }

                korisniciSearch.Status = false;
                user = await _KorisniciService.Get<List<Model.Models.Korisnik>>(korisniciSearch);
                if (user.Count > 0)
                {
                    foreach (var item in user)
                    {
                        if (item.KorisnikId != _KorisnikId)
                            postoji = true;
                    }
                }

                if (postoji)
                {
                    errorProvider1.SetError(txtUsername, Properties.Resources.UsernameExists);
                    e.Cancel = true;
                }
                else
                    errorProvider1.SetError(txtUsername, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider1.SetError(txtTelefon, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefon, null);
            }

        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                errorProvider1.SetError(txtAdresa, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAdresa, null);
            }
        }

        private void cmbGrad_Validating(object sender, CancelEventArgs e)
        {
            var GradObj = cmbGrad.SelectedValue;

            if (GradObj.ToString() == "0")
            {
                errorProvider1.SetError(cmbGrad, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cmbGrad, null);
            }
        }

        private void txtPotvrdaPassworda_Validating(object sender, CancelEventArgs e)
        {
         if (!string.IsNullOrWhiteSpace(txtPotvrdaPassworda.Text))
            {
                if (string.Compare(txtPassword.Text, txtPotvrdaPassworda.Text) != 0)
                {
                    errorProvider1.SetError(txtPotvrdaPassworda, Properties.Resources.PasswordNotEqual);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txtPotvrdaPassworda, null);
                }
            }
            else
            {
                errorProvider1.SetError(txtPotvrdaPassworda, null);
            }
        }

        private void txtNoviPassword_Validating(object sender, CancelEventArgs e)
        {
        //    if (string.IsNullOrWhiteSpace(txtPassword.Text))
        //    {
        //        errorProvider1.SetError(txtPassword, Properties.Resources.Validation_Required);
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtPassword, null);
        //    }
        }

   
        #endregion
        public  static string GenerateHash(string salt, string password)
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
