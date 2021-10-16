
namespace XpBlog.Html
{
    public class Article_Complet_To_Html : IPage
    { 
        public LIEN Lien { get; internal set; }
        public Article_View Article_view { get; }

        public Article_Complet_To_Html(string titre, string nomFichier, Article_View article_view)
        {
            Titre = titre;
            FileName = nomFichier;
            Lien = article_view.Lien;
            Article_view = article_view;
        }
        public string Titre { get; }

        public string FileName { get; }

        public string Html_page
        {
            get
            {
                var razor_html = new Razor<Article_View>("Article/code.cshtml", Article_view);
                return razor_html.Html;
            }
        }
    }
}