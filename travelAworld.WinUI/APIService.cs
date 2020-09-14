using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using travelAworld.Model;
using System.Windows.Forms;
using travelAworld.WinUI.Properties;

namespace travelAworld.WinUI
{
    public class APIService
    {
        private string _route = null;
        public string endpoint = "https://travelaapi2.azurewebsites.net/api/";

        public static string Username { get; set; }
        public static string Password { get; set; }

        public APIService(string route)
        {
            _route = route;
        }

        public T Get<T>(object queryParams)
        {
            var result = $"{endpoint}/{_route}".WithOAuthBearerToken(Properties.Settings.Default.Token).SetQueryParams( queryParams ).GetJsonAsync<T>();
            return result.Result;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{endpoint}/{_route}/{id}".WithOAuthBearerToken(Properties.Settings.Default.Token);

            return await url.GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{endpoint}/{_route}";

            try
            {
                return await url.WithOAuthBearerToken(Properties.Settings.Default.Token).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{endpoint}/{_route}/{id}";

                return await url.WithOAuthBearerToken(Properties.Settings.Default.Token).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

    }
}
