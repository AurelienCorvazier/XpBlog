using System;
using XpBlog.Domain;

namespace XpBlog.AC.Articles
{
    public class Article_2
    {
        public Article Article { get; }

        public Article_2()
        {
            Article = new Article(new DateTime(2021, 7, 4), "Aurélien CORVAZIER", "Kata Bowling", new Tag[] { Tag.Kata, Tag.CSharp });

            var chapitre_1 = new Chapitre("Solution");
            var lien = new Lien("https://github.com/AurelienCorvazier/Kata.Bowling");
            chapitre_1.AddParagraphe(lien);
            Article.AddChapitre(chapitre_1);
        }
    }
}

