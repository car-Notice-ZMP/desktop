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
                if (r.Equals("title"))
                    numberOfNotices++;

            return numberOfNotices;
        }

        public IModelN Notice(int id)
        {
            int i = 0;
            bool j = true;
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
                if (r.Equals("title"))
                    index++;

                if (r.Equals("title") && index == id)
                {
                    _model.id = Int32.Parse(
                        result[i - 1]
                        .Remove(0, 1)
                        .Replace(",", "")
                    );

                    whetherThereWasAnId = true;
                }

                if (whetherThereWasAnId)
                {
                    if (r.Equals("title"))
                        _model.title = result[i + 2];
                    else if (r.Equals("message"))
                        _model.message = result[i + 2];
                    else if (r.Equals("mark"))
                        _model.mark = result[i + 2];
                    else if (r.Equals("model"))
                        _model.model = result[i + 2];
                    else if (r.Equals("color"))
                        _model.color = result[i + 2];
                    else if (r.Equals("year"))
                        _model.year = result[i + 1]
                            .ToString()
                            .Remove(0, 1)
                            .Replace(",", "");
                    else if (r.Equals("mileage"))
                        _model.mileage = result[i + 1]
                            .ToString()
                            .Remove(0, 1)
                            .Replace(",", "");
                    else if (r.Equals("price"))
                        _model.price = result[i + 1]
                            .ToString()
                            .Remove(0, 1)
                            .Replace(",", "");
                    else if (r.Equals("body"))
                        _model.body = result[i + 2];
                    else if (r.Equals("image_url"))
                        _model.image_url = result[i + 2];
                    else if (r.Equals("name"))
                    {
                        _model.name = result[i + 2];
                        break;
                    }
                }

                i++;
            }

            return _model;
        }

        public void DeleteNotice(int id)
        {
            var client = new RestClient("https://citygame.ga/api/notices/delete/" + id.ToString());
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("Authorization", "Bearer " + Token.returnToken());
            client.Execute(request);
        }

        public bool StatusNotice(int id)
        {
            bool status;

            var client = new RestClient("https://citygame.ga/api/notices/status/" + id.ToString());
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + Token.returnToken());
            IRestResponse response = client.Execute(request);

            if (response.StatusCode.ToString().Equals("OK"))
                status = true;
            else
                status = false;

            return status;
        }
    }
}
