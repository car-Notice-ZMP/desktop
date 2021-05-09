using NoticeMyCar.SendAMessage.Model;
using NoticeMyCar.SendAMessage.View;
using RestSharp;
using System;

namespace NoticeMyCar.SendAMessage.Service
{
    class ServiceS : IServiceS
    {
        private readonly IModelS _model;

        public ServiceS(IModelS model)
        {
            _model = model;
        }

        public bool WasItSent(IViewSAM view)
        {
            bool wasItSent;

            _model.receiver = view.receiver;
            _model.title = view.title;
            _model.content = view.content;

            var client = new RestClient("https://citygame.ga/api/mail/send");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);

            request.AddQueryParameter("receiver", _model.receiver);
            request.AddQueryParameter("title", _model.title);
            request.AddQueryParameter("content", _model.content);

            request.AddHeader("Authorization", "Bearer " + Token.returnToken());
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
                wasItSent = true;
            else
                wasItSent = false;

            return wasItSent;
        }
    }
}
