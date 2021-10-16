using System;
using System.Collections.Generic;

namespace XpBlog.Domain
{
    public class Tag : IComparable<Tag>
    {
        public string Nom { get; private set; }
        public List<Article> Articles { get; private set; } = new List<Article>();

        public Tag(string nom)
        {
            Nom = nom;
        }

        public static Tag Debutant { get; private set; } = new Tag("Debutant");
        public static Tag CSharp { get; private set; } = new Tag("CSharp");
        public static Tag Method { get; private set; } = new Tag("Methodes");
        public static Tag Linq { get; private set; } = new Tag("Linq");
        public static Tag Kata { get; private set; } = new Tag("Kata");
        
        internal void AddArticle(Article article)
        {
            Articles.Add(article);
        }

        public int CompareTo(Tag other)
        {
            return Nom.CompareTo(other.Nom);
        }
    }
}