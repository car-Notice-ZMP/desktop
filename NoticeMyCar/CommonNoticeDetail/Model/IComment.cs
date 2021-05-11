namespace NoticeMyCar.CommonNoticeDetail.Model
{
    public interface IComment
    {
        string author_avatar { get; set; }
        string comment_author { get; set; }
        string content { get; set; }
    }
}