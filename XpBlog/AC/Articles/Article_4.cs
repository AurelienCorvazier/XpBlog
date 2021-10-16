using System;
using XpBlog.Domain;

namespace XpBlog.AC.Articles
{
    public class Article_4
    {
        public Article Article { get; }

        public Article_4()
        {
            Article = new Article(new DateTime(2021, 10, 2), "Aurélien CORVAZIER", "Kata Gilded Rose", new Tag[] { Tag.Kata, Tag.CSharp });

            var chapitre_1 = new Chapitre("Solution");
            var lien = new Lien("https://github.com/AurelienCorvazier/Kata.GildedRose");
            chapitre_1.AddParagraphe(lien);
            Article.AddChapitre(chapitre_1);
        }
    }
}

