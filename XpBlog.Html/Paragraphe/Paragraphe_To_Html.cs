using System;
using XpBlog.Domain;
using XpBlog.Html;

namespace XpBlog
{
    public class Paragraphe_To_Html
    {
        public string Html { get; private set; }

        public Paragraphe_To_Html(Paragraphe paragraphe)
        {
            Html = Get_string(paragraphe);
        }

        private static string Get_string(Paragraphe paragraphe)
        {
            if (paragraphe is Texte)
                return Texte_To_Html(paragraphe as Texte);
            if (paragraphe is Code)
                return Code_To_Html(paragraphe as Code);
            if (paragraphe is Lien)
                return Lien_To_Html(paragraphe as Lien);
            throw new NotImplementedException();
        }

        internal static string Texte_To_Html(Texte texte)
        {
            return $"<p>{texte._texte}</p>";
        }

        internal static string Code_To_Html(Code code)
        {
            var code_To_Html = new Code_To_Html(code);
            return code_To_Html.Html;
        }

        internal static string Lien_To_Html(Lien lien)
        {
            return $"<a href=\"{lien.Url}\">{lien.Url}</a>";
        }
    }
}