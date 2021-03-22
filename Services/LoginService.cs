using Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LoginService
    {
        public bool Login(string email, string password)
        {
            RunAsync(email, password).Wait();
        }

        static async Task RunAsync(string email, string password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://34.122.22.62:8080/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                LoginModel login = new LoginModel();
                login.email = email;
                login.password = password;

                HttpResponseMessage response = await client.PostAsJsonAsync("auth/login", login);
                if (response.IsSuccessStatusCode)
                {

                }
            }
        }
    }
}
