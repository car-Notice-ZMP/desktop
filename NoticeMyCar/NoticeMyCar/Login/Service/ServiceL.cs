﻿using NoticeMyCar.Login.Model;
using NoticeMyCar.Login.View;
using RestSharp;

namespace NoticeMyCar.Services.Login
{
    class ServiceL : IServiceL
    {
        private readonly IModelL _model;

        public ServiceL(IModelL model)
        {
            _model = model;
        }

        public bool Login(IViewL view)
        {
            bool validLogin;
            int i = 0;
            string token = "";

            _model.email = view.email;
            _model.password = view.password;

            var client = new RestClient("https://citygame.ga/api/auth/login");
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);

            request.AddQueryParameter("email", _model.email);
            request.AddQueryParameter("password", _model.password);

            IRestResponse response = client.Execute(request);

            string[] result = response.Content.Split(new char[] { '"' });

            foreach (var r in result)
            {
                if (r.Equals("access_token"))
                {
                    token = result[i + 2];
                    break;
                }
                i++;
            }

            Token.addToken(token);

            if (response.IsSuccessful)
                validLogin = true;
            else
                validLogin = false;

            return validLogin;
        }
    }
}
