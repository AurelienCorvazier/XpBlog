using System.Collections.Generic; 


namespace XpBlog.Html
{
    public class Accueil : IPage
    {
        public IEnumerable<Article_Synthese> Articles_Syntheses { get; } 

        public Accueil(string titre, string nomFichier, List<Article_Synthese> articles_Syntheses)
        {
            Titre = titre;
            FileName = nomFichier;
            Articles_Syntheses = articles_Syntheses;
        }

        public string Html_page
        {
            get
            {
                var razor_html = new Razor<Accueil>("Accueil/code.cshtml", this);
                return razor_html.Html;
            }
        }

        public string Titre { get; }

        public string FileName { get; }
    }
}