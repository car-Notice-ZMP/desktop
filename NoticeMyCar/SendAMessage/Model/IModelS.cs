namespace NoticeMyCar.SendAMessage.Model
{
    interface IModelS
    {
        string content { get; set; }
        string receiver { get; set; }
        string title { get; set; }
    }
}