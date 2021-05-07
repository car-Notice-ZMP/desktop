using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.BuyACar.Notice.Model
{
    class ModelN : IModelN
    {
        public int id { get; set; }
        public string image_url { get; set; }
        public string title { get; set; }
        public string notice_author { get; set; }
        public string notice_author_email { get; set; }
        public string author_avatar { get; set; }
        public string message { get; set; }
        public string mark { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public string body { get; set; }
        public string mileage { get; set; }
        public string price { get; set; }
        public string image { get; set; }
        public string year { get; set; }
        public string name { get; set; }
    }
}
