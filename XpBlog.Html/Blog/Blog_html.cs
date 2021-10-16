using System.Collections.Generic;
using System.Linq;
using XpBlog.Domain;

namespace XpBlog.Html
{
    public class Blog_html
    {
        private readonly string _adresse_site;
        public List<Page> Pages { get; }

        public Blog_html(string adresse_site, SortedSet<Tag> tags, List<Article> articles)
        {
            _adresse_site = adresse_site;

            var article_views = Get_Article_View_From_Articles(articles);
            var articles_Syntheses = article_views.Select(e => new Article_Synthese(e)).ToList();

            var pages_articles = article_views.Select(e => new Article_Complet_To_Html(e.Titre, e.Lien.LienRelatif, e)).ToList();
            var pages_tags = tags.Select(e => new Page_Tags_To_Html(e.Nom, e.Nom + ".html", Get_Article_Synthese(e.Articles))).ToList();

            var pages_0 = new List<IPage>();
            pages_0.Add(new Accueil("Accueil", "index.html", articles_Syntheses));
            pages_0.AddRange(pages_articles);
            pages_0.AddRange(pages_tags);

            var liens = Get_Liens_Menu(tags);
            var html_menu = new Menu(liens).Html;
            Pages = pages_0.Select(e => new Page(e.Titre, e.FileName, e.Html_page, html_menu)).ToList();
        }

        private List<Article_View> Get_Article_View_From_Articles(List<Article> articles)
        {
            return articles.Select(e => new Article_View(Get_Lien_Article(e), Get_Liens_From_Tags(e.Tags), e)).ToList();
        }

        private IEnumerable<Article_Synthese> Get_Article_Synthese(List<Article> articles)
        {
            var article_views_tag = Get_Article_View_From_Articles(articles);
            var articles_Syntheses_tag = article_views_tag.Select(e => new Article_Synthese(e)).ToList();
            return articles_Syntheses_tag;
        }

        private LIEN Get_Lien_Article(Article article)
        {
            return new LIEN(_adresse_site, article.Titre, "Articles/" + article.Titre + ".html");
        }

        private List<LIEN> Get_Liens_Menu(SortedSet<Tag> tags)
        {
            var liens = Get_Liens_From_Tags(tags);
            var menus = new List<LIEN> { new LIEN(_adresse_site, "Accueil", "index.html") };
            menus.AddRange(liens);
            return menus;
        }

        private List<LIEN> Get_Liens_From_Tags(SortedSet<Tag> tags)
        {
            var liens = tags.Select(e => new LIEN(_adresse_site, e.Nom, e.Nom + ".html")).ToList();
            return liens;
        }
    }
}