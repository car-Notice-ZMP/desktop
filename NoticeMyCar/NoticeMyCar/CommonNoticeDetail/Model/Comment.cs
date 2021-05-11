namespace NoticeMyCar.CommonNoticeDetail.Model
{
    class Comment : IComment
    {
        public string content { get; set; }
        public string comment_author { get; set; }
        public string author_avatar { get; set; }
    }
}
