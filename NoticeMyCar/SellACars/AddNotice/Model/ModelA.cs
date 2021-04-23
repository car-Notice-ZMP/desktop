using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.SellACars.AddNotice.Model
{
    public class ModelA : IModelA
    {
        public string image { get; set; }
        public string title { get; set; }
        public string content { get; set; }
    }
}
