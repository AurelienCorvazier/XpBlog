using System.IO;

namespace XpBlog.Html
{
    public class LIEN
    {
        public string Nom { get; private set; }
        public string LienRelatif { get; private set; }
        public string LienAbsolu { get; private set; }
        public string Html { get; private set; }

        public LIEN(string adresse_site, string nom, string lienRelatif)
        {
            Nom = nom;
            LienRelatif = lienRelatif;
            LienAbsolu = Path.Combine(adresse_site, lienRelatif);

            var style = "style=\"padding: 5px 10px;margin-right: 10px;font-weight: 700; color: #fff; text-decoration: none; background: #2a2a2a;\"";
            var html = "<a " + style + " href=\"" + LienAbsolu + "\">" + Nom + "</a>"; 
            Html = html;
        }
    }
}