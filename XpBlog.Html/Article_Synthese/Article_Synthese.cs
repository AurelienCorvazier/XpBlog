using XpBlog.Domain;

namespace XpBlog.Html
{
    public class Article_Synthese
    {
        public string Html { get; private set; }

        public Article_Synthese(Article_View article_view)
        {
            var razor_html = new Razor<Article_View>("Article_Synthese/code.cshtml", article_view);
            Html = razor_html.Html;
        }
    }
}