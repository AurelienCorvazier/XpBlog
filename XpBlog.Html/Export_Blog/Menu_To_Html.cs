using System.Collections.Generic;
using System.Linq;
using XpBlog.Domain;

namespace XpBlog.Html
{
    internal class Menu
    { 
        public string Html { get; }

        public Menu(List<LIEN> liens)
        { 
            var html = "<nav id=\"menu\">";
            html += "<ul id=\"menu-closed\">";

            foreach (var lien in liens)
                html += "<li><a href=\"" + lien.LienAbsolu + "\">" + lien.Nom + "</a></li>";

            html += "<li><a href=\"#menu-closed\">&#215; Close menu</a></li>";

            html += "<li><a href=\"#menu\">&#9776; Menu</a></li>";
            html += "</ul>";
            html += "</nav>";

            Html = html;
        }

    }
}