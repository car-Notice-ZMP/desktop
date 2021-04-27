using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NoticeMyCar.SellACars.Notices.Model;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.SellACars.Notices.Service
{
    class ServiceN : IServiceN
    {
        private readonly IModelN _model;

        public ServiceN(IModelN model)
        {
            _model = model;
        }

        public int NumberOfNotices()
        {
            int numberOfNotices = 0;

            var client = new RestClient("https://citygame.ga/api/notices/my_notices");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + Token.returnToken());
            IRestResponse response = client.Execute(request);

            string[] result = response.Content.Split(new char[] { '"' });

            foreach (var r in result)
                if (r.Equals("id"))
                    numberOfNotices++;

            return numberOfNotices;
        }

        public IModelN Notice(int id)
        {
            int i = 0;
            int index = -1;
            bool whetherThereWasAnId = false;

            var client = new RestClient("https://citygame.ga/api/notices/my_notices");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + Token.returnToken());
            IRestResponse response = client.Execute(request);

            JObject decodedResponse = JObject.Parse(response.Content);

            string[] result = decodedResponse.ToString().Split(new char[] { '"' });

            foreach (var r in result)
            {
                if (r.Equals("id"))
                    index++;

                if (r.Equals("id") && index == id)
                {
                    whetherThereWasAnId = true;
                }

                if (whetherThereWasAnId)
                {
                    if (r.Equals("title"))
                        _model.title = result[i + 2];
                    else if (r.Equals("content"))
                        _model.contenet = result[i + 2];
                    else if (r.Equals("image_url"))
                    {
                        _model.image_url = result[i + 2];
                        break;
                    }
                }

                i++;
            }

            return _model;
        }
    }
}
