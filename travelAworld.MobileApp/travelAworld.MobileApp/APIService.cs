using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using Xamarin.Forms;

namespace travelAworld.MobileApp
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        private readonly string _route;

#if DEBUG
        private string _apiUrl = "http://192.168.0.10:45457/api";
        //private string _apiUrl = "http://localhost:57818/api";
#endif
#if RELEASE
        private string _apiUrl = "https://mywebsite.azure.com/api/";
#endif

        public APIService(string route)
        {
            _route = route;
        }

        public T Get<T>(object queryParams)
        {
            var result = $"{_apiUrl}/{_route}".WithOAuthBearerToken(App.Current.Properties["Token"].ToString()).SetQueryParams(queryParams).GetJsonAsync<T>();
            //var result = $"{_apiUrl}/{_route}".SetQueryParams(queryParams).GetJsonAsync<T>();
            return result.Result;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithOAuthBearerToken(App.Current.Properties["Token"].ToString()).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {

            try
            {
                return await $"{_apiUrl}/{_route}".PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }

        public async Task<T> InsertA<T>(object request)
        {

            try
            {
                return await $"{_apiUrl}/{_route}".WithOAuthBearerToken(App.Current.Properties["Token"].ToString()).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }

        public async Task InsertById (int id)
        {

            try
            {
                await $"{_apiUrl}/{_route}".WithOAuthBearerToken(App.Current.Properties["Token"].ToString()).PostUrlEncodedAsync(new
                {
                    id = "51"
                });
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                
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

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }
    }
}
