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
                            .Remove(0, 2)
                            .Replace(",", "")
                            .Trim();
                    else if (r.Equals("mileage"))
                        _model.mileage = result[i + 1]
                            .ToString()
                            .Remove(0, 2)
                            .Replace(",", "")
                            .Trim();
                    else if (r.Equals("price"))
                        _model.price = result[i + 1]
                            .ToString()
                            .Remove(0, 2)
                            .Replace(",", "")
                            .Trim();
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

        public bool Update(int id, List<string> changes)
        {
            bool whetherItWasSuccessful;

            _model.title = null;
            _model.mark = null;
            _model.model = null;
            _model.color = null;
            _model.body = null;
            _model.mileage = null;
            _model.price = null;
            _model.year = null;
            _model.message = null;

            foreach (var c in changes)
            {
                string[] number = c.Split(new string[] { "+,+" }, StringSplitOptions.None);

                switch (number[0])
                {
                    case "0":
                        _model.title = number[1];
                        break;
                    case "1":
                        _model.mark = number[1];
                        break;
                    case "2":
                        _model.model = number[1];
                        break;
                    case "3":
                        _model.color = number[1];
                        break;
                    case "4":
                        _model.body = number[1];
                        break;
                    case "5":
                        _model.mileage = number[1];
                        break;
                    case "6":
                        _model.price = number[1];
                        break;
                    case "7":
                        _model.year = number[1];
                        break;
                    case "8":
                        _model.message = number[1];
                        break;
                    case "9":
                        _model.image = number[1];
                        break;
                }
            }

            var client = new RestClient("https://citygame.ga/api/notices/update/" + id.ToString());
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);

            if (_model.image != null)
                request.AddFile("image", _model.image);
            if (_model.title != null)
                request.AddQueryParameter("title", _model.title);
            if (_model.mark != null)
                request.AddQueryParameter("mark", _model.mark);
            if (_model.model != null)
                request.AddQueryParameter("model", _model.model);
            if (_model.color != null)
                request.AddQueryParameter("color", _model.color);
            if (_model.body != null)
                request.AddQueryParameter("body", _model.body);
            if (_model.mileage != null)
                request.AddQueryParameter("mileage", _model.mileage);
            if (_model.price != null)
                request.AddQueryParameter("price", _model.price);
            if (_model.year != null)
                request.AddQueryParameter("year", _model.year);
            if (_model.message != null)
                request.AddQueryParameter("message", _model.message);

            request.AddHeader("Authorization", "Bearer " + Token.returnToken());
            IRestResponse response = client.Execute(request);

            if (response.StatusCode.ToString().Equals("OK"))
                whetherItWasSuccessful = true;
            else
                whetherItWasSuccessful = false;

            return whetherItWasSuccessful;
        }
    }
}
