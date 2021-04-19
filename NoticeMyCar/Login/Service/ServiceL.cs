﻿using NoticeMyCar.Login.Model;
using NoticeMyCar.Login.View;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NoticeMyCar.Services.Login
{
    public class ServiceL : IServiceL
    {
        private IModelL _model;

        public ServiceL(IModelL model)
        {
            _model = model;
        }

        public bool Login(IViewL view)
        {
            bool validLogin;

            _model.email = view.email;
            _model.password = view.password;

            string requesBody = "{" +
                                    "\"email\": \"" + _model.email + "\"," +
                                    "\"password\": \"" + _model.password + "\"" +
                                 "}";

            var client = new RestClient("https://citygame.ga/api/auth/login");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", requesBody, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            string[] result = response.Content.Split(new char[] { '"' });

            Token.addToken(result[3]);

            if (response.StatusCode.ToString().Equals("OK"))
                validLogin = true;
            else
                validLogin = false;

            return validLogin;
        }
    }
}
