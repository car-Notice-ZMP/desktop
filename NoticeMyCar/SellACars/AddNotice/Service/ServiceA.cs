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
            _model.message = view.content;
            _model.mark = view.mark;
            _model.model = view.model;
            _model.color = view.color;
            _model.body = view.body;
            _model.mileage = view.mileage;
            _model.price = view.price;
            _model.year = view.year;

            var client = new RestClient("https://citygame.ga/api/notices/store");
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);

            request.AddQueryParameter("title", _model.title);
            request.AddQueryParameter("message", _model.message);
            request.AddQueryParameter("mark", _model.mark);
            request.AddQueryParameter("model", _model.model);
            request.AddQueryParameter("color", _model.color);
            request.AddQueryParameter("body", _model.body);
            request.AddQueryParameter("mileage", _model.mileage);
            request.AddQueryParameter("price", _model.price);
            request.AddQueryParameter("year", _model.year);

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
