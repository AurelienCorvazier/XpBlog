
namespace XpBlog.Domain
{
    public class Lien : Paragraphe
    {
        public string Url { get; private set; }

        public Lien(string url)
        {
            Url = url;
        }

    }
}