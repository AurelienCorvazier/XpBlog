using System;
using System.Collections.Generic;
using System.Linq;

namespace XpBlog.Domain
{
    public class Article
    {
        public DateTime DateHeure { get; }
        public string Titre { get; }
        public SortedSet<Tag> Tags { get; }
        public List<Chapitre> Chapitres { get; private set; } = new List<Chapitre>();

        public string Date_Auteur { get; }

        public Article(DateTime dateTime, string auteur, string titre, params Tag[] tags)
        {
            DateHeure = dateTime;
            Date_Auteur = $"Le {dateTime.Date:m} {DateHeure.Date.Year} par {auteur}";
            Titre = titre;
            Tags = new SortedSet<Tag>(tags);
            foreach (var tag in tags)
                tag.AddArticle(this);
        }
        public void AddChapitre(Chapitre chapitre)
        {
            Chapitres.Add(chapitre);
        }

    }
}