using Newtonsoft.Json;
using NoticeMyCar.Registration.Model;
using NoticeMyCar.Registration.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

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

            client.BaseAddress = new Uri("https://citygame.ga/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response;

            _model.email = view.email;
            _model.password = view.password;
            _model.password_confirmation = view.repeatPassword;
            _model.name = view.name;

            response = client.PostAsJsonAsync("auth/register", _model).Result;

            if (response.StatusCode.ToString().Equals("OK"))
                validLogin = true;
            else
                validLogin = false;

            return validLogin;
        }
    }
}
