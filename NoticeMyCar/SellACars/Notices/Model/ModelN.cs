using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.SellACars.Notices.Model
{
    class ModelN : IModelN
    {
        public string image_url { get; set; }
        public string title { get; set; }
        public string contenet { get; set; }
    }
}
