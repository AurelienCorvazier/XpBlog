using System.Collections.Generic;
using System.Linq;
using XpBlog.Domain;

namespace XpBlog.Html
{
    public class Article_View
    {
        public LIEN Lien { get; private set; }
        public string Date_Auteur { get; private set; }
        public string Titre { get; internal set; }

        public IEnumerable<Chapitre_To_Html> Chapitres { get; }
        public IEnumerable<LIEN> Tags { get; }

        public Article_View(LIEN lien, IEnumerable<LIEN> liens_tags, Article article)
        {
            Titre = article.Titre;
            Lien = lien;
            Date_Auteur = article.Date_Auteur;

            Chapitres = article.Chapitres.Select(e => new Chapitre_To_Html(e)).ToList();
            Tags = liens_tags; 
        }


    }
}