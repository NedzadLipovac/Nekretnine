using Flurl.Http;
using Nekretnine.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nekretnine.Mobile
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        private string _route = null;

#if DEBUG

#endif
        string _apiUrl = "http://localhost:64804/api";
#if RELASE
        string _apiUrl = "https://mywebsite.ba/api/";
#endif
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var URL = $"{_apiUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    URL += "?";
                    URL += await search.ToQueryString();
                }
                return await URL.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    //MessageBox.Show("Niste autentificirani");
                   await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            //return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                //MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                return default(T);
            }


        }

        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                //MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
                return default(T);
            }

        }


        public async Task<T> GenerateHash2<T>(object search)
        {
            var URL = $"{_apiUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    URL += "?";
                    URL += await search.ToQueryString();
                }
                return await URL.GetJsonAsync<T>();

            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    //MessageBox.Show("Niste autentificirani");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
                }
                throw;
            }
        }
    }
}
