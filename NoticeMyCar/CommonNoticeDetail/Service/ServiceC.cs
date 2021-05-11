using Newtonsoft.Json.Linq;
using NoticeMyCar.CommonNoticeDetail.Model;
using NoticeMyCar.CommonNoticeDetail.View;
using RestSharp;

namespace NoticeMyCar.CommonNoticeDetail.Service
{
    class ServiceC : IServiceC
    {
        private readonly IModelC _model;

        public ServiceC(IModelC model)
        {
            _model = model;
        }

        public IModelC Notice(int id)
        {
            int i = 0;
            bool whetherThereWasAnId = false;

            var client = new RestClient("https://citygame.ga/api/notices/show/" + id.ToString());
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            JObject decodedResponse = JObject.Parse(response.Content);

            string[] result = decodedResponse.ToString().Split(new char[] { '"' });

            foreach (var r in result)
            {
                if (r.Equals("title"))
                {
                    _model.id = int.Parse(
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
                    else if (r.Equals("notice_author"))
                        _model.notice_author = result[i + 2];
                    else if (r.Equals("notice_author_email"))
                        _model.notice_author_email = result[i + 2];
                    else if (r.Equals("author_avatar"))
                        _model.author_avatar = result[i + 2];
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

        public bool addComment(IViewC view, int id)
        {
            bool hasAnNoticeBeenAdded;

            _model.content = view.content;

            var client = new RestClient("https://citygame.ga/api/comments/" + id.ToString() + "/store");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddQueryParameter("content", _model.content);
            request.AddHeader("Authorization", "Bearer " + Token.returnToken());
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
                hasAnNoticeBeenAdded = true;
            else
                hasAnNoticeBeenAdded = false;

            return hasAnNoticeBeenAdded;
        }
    }
}
