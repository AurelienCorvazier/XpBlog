namespace XpBlog.Html
{
    public interface IPage
    {
        public string Titre { get; }
        public string FileName { get; }
        public string Html_page { get; }
    }
}