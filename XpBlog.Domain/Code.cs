
namespace XpBlog.Domain
{
    public class Code : Paragraphe
    {
        public string CSharp { get; private set; }

        public Code(string code)
        {
            CSharp = code;
        }

    }
}