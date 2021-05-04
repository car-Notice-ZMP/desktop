namespace NoticeMyCar.SellACars.Notices.Model
{
    public interface IModelN
    {
        string body { get; set; }
        string color { get; set; }
        int id { get; set; }
        string image_url { get; set; }
        string mark { get; set; }
        string message { get; set; }
        string mileage { get; set; }
        string model { get; set; }
        string name { get; set; }
        string price { get; set; }
        string title { get; set; }
        string year { get; set; }
    }
}