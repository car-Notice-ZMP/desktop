using Newtonsoft.Json.Linq;
using NoticeMyCar.CommonNoticeDetail.Model;
using NoticeMyCar.CommonNoticeDetail.View;
using RestSharp;

namespace NoticeMyCar.CommonNoticeDetail.Service
{
    class ServiceC : IServiceC
    {
        private readonly INotice _notice;
        private readonly IComment _comment;

        public ServiceC(INotice notice, IComment comment)
        {
            _notice = notice;
            _comment = comment;
        }

        public INotice Notice(int id)
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
                    _notice.id = int.Parse(
                        result[i - 1]
                        .Remove(0, 1)
                        .Replace(",", "")
                    );

                    whetherThereWasAnId = true;
                }

                if (whetherThereWasAnId)
                {
                    if (r.Equals("title"))
                        _notice.title = result[i + 2];
                    else if (r.Equals("message"))
                        _notice.message = result[i + 2];
                    else if (r.Equals("notice_author"))
                        _notice.notice_author = result[i + 2];
                    else if (r.Equals("notice_author_email"))
                        _notice.notice_author_email = result[i + 2];
                    else if (r.Equals("author_avatar"))
                        _notice.author_avatar = result[i + 2];
                    else if (r.Equals("mark"))
                        _notice.mark = result[i + 2];
                    else if (r.Equals("model"))
                        _notice.model = result[i + 2];
                    else if (r.Equals("color"))
                        _notice.color = result[i + 2];
                    else if (r.Equals("year"))
                        _notice.year = result[i + 1]
                            .ToString()
                            .Remove(0, 2)
                            .Replace(",", "")
                            .Trim();
                    else if (r.Equals("mileage"))
                        _notice.mileage = result[i + 1]
                            .ToString()
                            .Remove(0, 2)
                            .Replace(",", "")
                            .Trim();
                    else if (r.Equals("price"))
                        _notice.price = result[i + 1]
                            .ToString()
                            .Remove(0, 2)
                            .Replace(",", "")
                            .Trim();
                    else if (r.Equals("body"))
                        _notice.body = result[i + 2];
                    else if (r.Equals("image_url"))
                        _notice.image_url = result[i + 2];
                    else if (r.Equals("name"))
                    {
                        _notice.name = result[i + 2];
                        break;
                    }
                }

                i++;
            }

            return _notice;
        }

        public int NumberOfComments(int id)
        {
            int numberofComments = 0;
            bool isThereAComment = false;

            var client = new RestClient("https://citygame.ga/api/notices/show/" + id.ToString());
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            string[] result = response.Content.Split(new char[] { '"' });

            foreach (var r in result)
            {
                if (r.Equals("comments"))
                    isThereAComment = true;

                if (isThereAComment && r.Equals("id"))
                    numberofComments++;
            }

            return numberofComments;
        }

        public IComment Comment(int id, int numberOfComment)
        {
            int i = 0;
            int index = -1;
            bool isThereAComment = false;

            var client = new RestClient("https://citygame.ga/api/notices/show/" + id.ToString());
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            JObject decodedResponse = JObject.Parse(response.Content);

            string[] result = decodedResponse.ToString().Split(new char[] { '"' });

            foreach (var r in result)
            {
                if (r.Equals("comments"))
                    isThereAComment = true;

                if (isThereAComment && r.Equals("id"))
                    index++;

                if (isThereAComment && index == numberOfComment)
                {
                    if (r.Equals("content"))
                        _comment.content = result[i + 2];
                    else if (r.Equals("comment_author"))
                        _comment.comment_author = result[i + 2];
                    else if (r.Equals("author_avatar"))
                    {
                        _comment.author_avatar = result[i + 2];
                        break;
                    }
                }

                i++;
            }

            return _comment;
        }

        public bool AddComment(IViewC view, int id)
        {
            bool hasAnNoticeBeenAdded;

            _comment.content = view.content;

            var client = new RestClient("https://citygame.ga/api/comments/" + id.ToString() + "/store");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddQueryParameter("content", _comment.content);
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
