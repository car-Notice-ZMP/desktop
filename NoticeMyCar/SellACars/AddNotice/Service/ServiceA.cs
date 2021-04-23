using NoticeMyCar.SellACars.AddNotice.Model;
using NoticeMyCar.SellACars.AddNotice.View;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.SellACars.AddNotice.Service
{
    class ServiceA : IServiceA
    {
        private readonly IModelA _model;

        public ServiceA(IModelA model)
        {
            _model = model;
        }

        public bool Notice(IViewA view)
        {
            bool validLogin;

            _model.image = view.image;
            _model.title = view.title;
            _model.content = view.content;

            var client = new RestClient("https://citygame.ga/api/notices/store");
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);

            request.AddQueryParameter("title", _model.title);
            request.AddQueryParameter("content", _model.content);

            request.AddHeader("Authorization", "Bearer " + Token.returnToken());
            request.AddFile("image", _model.image);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode.ToString().Equals("OK"))
                validLogin = true;
            else
                validLogin = false;

            return validLogin;
        }
    }
}
