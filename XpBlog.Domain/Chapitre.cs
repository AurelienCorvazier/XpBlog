using System.Collections.Generic;
using System.IO;

namespace XpBlog.Domain
{
    public class Chapitre
    {
        public string _titre;

        public List<Paragraphe> Paragraphes = new();

        public Chapitre(string titre)
        {
            _titre = titre;
        }

        public void AddTexte(string texte)
        {
            Paragraphes.Add(new Texte(texte));
        }

        public void AddParagraphe(Paragraphe paragraphe)
        {
            Paragraphes.Add(paragraphe);
        }
         
    }
}