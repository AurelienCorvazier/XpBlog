using System.Collections.Generic;

namespace XpBlog.Html
{
    public class Page_Tags_To_Html : IPage 
    {
        public string Titre { get; }
        public IEnumerable<Article_Synthese> Articles_Syntheses { get; }

        public Page_Tags_To_Html(string titre, string nomFichier, IEnumerable<Article_Synthese> articles_Syntheses)
        {
            Titre = titre;
            FileName = nomFichier;
            Articles_Syntheses = articles_Syntheses;
        }

        public string Html_page
        {
            get
            {
                var razor_html = new Razor<Page_Tags_To_Html>("Page_Tags/code.cshtml", this);
                return razor_html.Html;
            }
        }

        public string FileName { get; }
    }
}