using System.Collections.Generic;
using System.Linq;
using XpBlog.Domain;

namespace XpBlog.Html
{
    public class Chapitre_To_Html
    {
        public string Html { get; private set; }
        public string Titre { get; }
        public IEnumerable<Paragraphe_To_Html> Paragraphes { get; }

        public Chapitre_To_Html(Chapitre chapitre)
        {
            Titre = chapitre._titre;
            Paragraphes = chapitre.Paragraphes.Select(e => new Paragraphe_To_Html(e)).ToList();
            var razor_html = new Razor<Chapitre_To_Html>("Chapitre/code.cshtml", this);
            Html = razor_html.Html;
        }

        public override string ToString()
        {
            return Html;
        }
    }
}