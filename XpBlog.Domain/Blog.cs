using System.Collections.Generic;
using System.Linq;

namespace XpBlog.Domain
{
    public class Blog
    {

        public List<Article> Articles { get; }

        public SortedSet<Tag> Tags { get; } 

        public Blog(params Article[] articles)
        {
            Articles = articles.ToList();
            Tags = new SortedSet<Tag>(articles.SelectMany(e => e.Tags));
        }

    }
}
