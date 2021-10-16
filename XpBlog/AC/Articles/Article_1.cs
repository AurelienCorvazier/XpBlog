using System;
using XpBlog.Domain;

namespace XpBlog.AC.Articles
{
    public class Article_1
    {
        public Article Article { get; }

        public Article_1()
        {
            Article = new Article(new DateTime(2021, 7, 4), "Aurélien CORVAZIER", "SOLID", new Tag[] { Tag.CSharp, Tag.Method });

            var chapitre_1 = new Chapitre("Responsabilité unique");
            chapitre_1.AddTexte("une classe, une fonction ou une méthode doit avoir une et une seule responsabilité");
            Article.AddChapitre(chapitre_1);

            var chapitre_2 = new Chapitre("Ouvert / fermé");
            chapitre_2.AddTexte("une entité applicative(class, fonction, module...) doit être fermée à la modification directe mais ouverte à l'extension");
            Article.AddChapitre(chapitre_2);

            var chapitre_3 = new Chapitre("Substitution de Liskov");
            chapitre_3.AddTexte("une instance de type T doit pouvoir être remplacée par une instance de type G, tel que G sous-type de T, sans que cela ne modifie la cohérence du programme");
            Article.AddChapitre(chapitre_3);

            var chapitre_4 = new Chapitre(" Ségrégation des interfaces");
            chapitre_4.AddTexte("préférer plusieurs interfaces spécifiques pour chaque client plutôt qu'une seule interface générale");
            Article.AddChapitre(chapitre_4);

            var chapitre_5 = new Chapitre("Inversion des dépendances");
            chapitre_5.AddTexte("il faut dépendre des abstractions, pas des implémentations");
            Article.AddChapitre(chapitre_5);

        }

    }
}

//var pastilles = new List<string>() { "**/bin/**", "**/obj/**" };
//chapitre_1.AddPastilles(pastilles);

//var c2 = "public void Configure(IApplicationBuilder app)" + Environment.NewLine;
//c2 += "{" + Environment.NewLine;
//c2 += "    app.UseExceptionHandler(\"/Home/Error\");" + Environment.NewLine;
//c2 += "    app.UseStaticFiles();" + Environment.NewLine;
//c2 += "    app.UseAuthentication();" + Environment.NewLine;
//c2 += "    app.UseMvcWithDefaultRoute();" + Environment.NewLine;
//c2 += "}" + Environment.NewLine;
//chapitre_2.AddCode(c2);

