using System.IO;

namespace NoticeMyCar.SellACars.AddNotice.Model
{
    public interface IModelA
    {
        string content { get; set; }
        string image { get; set; }
        string title { get; set; }
    }
}