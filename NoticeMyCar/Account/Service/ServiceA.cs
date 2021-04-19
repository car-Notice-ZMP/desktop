using NoticeMyCar.Account.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.Account.Service
{
    public class ServiceA : IServiceA
    {
        private IModelA _model;

        public ServiceA(IModelA model)
        {
            _model = model;
        }

        public IModelA Profile()
        {
            var client = new RestClient("https://citygame.ga/api/auth/profile");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + Token.returnToken());
            IRestResponse response = client.Execute(request);

            string[] result = response.Content.Split(new char[] { '"' });

            _model.avatar = result[17];
            _model.name = result[7];
            _model.email = result[11];

            return _model;
        }
    }
}
