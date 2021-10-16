using System;
using System.IO;
using XpBlog.Domain;

namespace XpBlog.AC.Articles
{
    public class Article_3
    {
        public Article Article { get; }

        public Article_3()
        {
            Article = new Article(new DateTime(2021, 7, 20), "Aurélien CORVAZIER", "SingleOrDefault vs FirstOrDefault", new Tag[] { Tag.Debutant, Tag.CSharp, Tag.Linq });

            var chapitre_1 = new Chapitre("Présentation");

            var sr = new StreamReader("AC/Articles/Article_3/Exemple_1.txt");
            var csharpstring = sr.ReadToEnd();
            sr.Close();
        
            var code = new Code(csharpstring);
            chapitre_1.AddParagraphe(code);
            Article.AddChapitre(chapitre_1);

            var chapitre_2 = new Chapitre("Différence");
            chapitre_2.AddTexte("Utilisez FirstOrDefault quand vous voulez simplement récupérer le premier élément");
            chapitre_2.AddTexte("Utilisez SingleOrDefault quand le résutat attendu est un unique élément. Si la liste contient plusieurs éléments, vous obtiendrez 'System.InvalidOperationException: 'Sequence contains more than one element'' ");
            Article.AddChapitre(chapitre_2);

            var chapitre_3 = new Chapitre("Se Protéger");
            chapitre_3.AddTexte("Mais alors pourquoi utiliser SingleOrDefault si c'est pour risquer de lever une exception ?");
            chapitre_3.AddTexte("Il est toujours préférable d'utiliser SingleOrDefault quand vous savez que l'élément recherché est unique. Si la liste en contenait plusieurs et que vous utilisez FirstOrDefault, une autre exception se lèvera plus loin dans le code et vous mettrez bien plus de temps à comprendre que vos données sont corrompues.");
            Article.AddChapitre(chapitre_3);

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

