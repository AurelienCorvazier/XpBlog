using XpBlog.AC.Articles;
using XpBlog.Domain;

namespace XpBlog.AC
{
    public class MonBlog
    {

        public MonBlog()
        {
        }

        public static Blog Get_Blog()
        {
            var articles = new Article[]
            {
                new Article_1().Article,
                new Article_2().Article,
                new Article_3().Article,
                new Article_4().Article,
            };
            var blog = new Blog(articles);
            return blog;
        }
    }
}
