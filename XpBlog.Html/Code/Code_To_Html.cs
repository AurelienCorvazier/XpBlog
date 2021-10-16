using ColorCode;
using XpBlog.Domain;

namespace XpBlog.Html
{
    public class Code_To_Html
    {
        public string Html { get; internal set; }
        public string Html_color { get; }

        public Code_To_Html(Code code)
        {
            var formatter = new HtmlClassFormatter();
            var html_color = formatter.GetHtmlString(code.CSharp, Languages.CSharp);
            Html_color = html_color.Replace("\n", "<br>").Replace("<pre>", "<pre style=\"white-space:normal\">");

            var razor = new Razor<Code_To_Html>("Code/code.cshtml", this);
            Html = razor.Html;
        }
    }
}