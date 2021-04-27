using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NoticeMyCar.Account.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.Account.Service
{
    class ServiceA : IServiceA
    {
        private readonly IModelA _model;

        public ServiceA(IModelA model)
        {
            _model = model;
        }

        public IModelA Profile()
        {
            string avatar = "";
            string name = "";
            string email = "";
            int i = 0;

            var client = new RestClient("https://citygame.ga/api/auth/profile");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + Token.returnToken());
            IRestResponse response = client.Execute(request);

            JObject decodedResponse = JObject.Parse(response.Content);

            string[] result = decodedResponse.ToString().Split(new char[] { '"' });

            foreach (var r in result)
            {
                if (r.Equals("name"))
                    name = result[i + 2];
                else if (r.Equals("email"))
                    email = result[i + 2];
                else if (r.Equals("avatar"))
                {
                    avatar = result[i + 2];
                    break;
                }

                i++;
            }

            _model.avatar = avatar;
            _model.name = name;
            _model.email = email;

            return _model;
        }
    }
}
