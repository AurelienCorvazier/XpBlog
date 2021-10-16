namespace XpBlog.Html
{
    public class Page 
    {
        public string Titre;
        public string FileName { get; }
        public string Html_menu { get; }
        public string Html_page { get; }

        public string Html { get; }

        public Page(string titre, string nomFichier, string html_page, string menu)
        {
            Titre = titre;
            FileName = nomFichier;
            Html_menu = menu;
            Html_page = html_page;

            var razor = new Razor<Page>("Page/code.cshtml", this);
            Html = razor.Html;
        }
         
    }
}