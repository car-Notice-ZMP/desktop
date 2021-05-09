using NoticeMyCar.Registration.Model;
using NoticeMyCar.Registration.View;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace NoticeMyCar.Registration.Service
{
    class ServiceR : IServiceR
    {
        private readonly IModelR _model;

        public ServiceR(IModelR model)
        {
            _model = model;
        }

        public bool Register(IViewR view)
        {
            var client = new HttpClient();
            bool validLogin;

            _model.email = view.email;
            _model.password = view.password;
            _model.password_confirmation = view.repeatPassword;
            _model.name = view.name;

            client.BaseAddress = new Uri("https://citygame.ga/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("auth/register", _model).Result;

            if (response.IsSuccessStatusCode)
                validLogin = true;
            else
                validLogin = false;

            return validLogin;
        }
    }
}
