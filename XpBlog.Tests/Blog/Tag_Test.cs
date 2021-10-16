using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using XpBlog.Domain;

namespace XpBlog.Tests
{
    [TestClass]
    public class Tag_Test
    {
        [TestMethod]
        public void Article_est_ajouté_dans_Tag_Test()
        {
            var tag = new Tag("TAG");
            _ = new Article(new DateTime(1900, 1, 1), "AUTEUR", "TITRE", tag);

            var article_ = tag.Articles.Single();
            Assert.AreEqual("TITRE", article_.Titre);
        }

        [TestMethod] 
        public void Tag_est_ajouté_dans_Blog_Test()
        {
            var tag = new Tag("TAG");
            var article = new Article(new DateTime(1900, 1, 1), "AUTEUR", "TITRE", tag);
            var blog = new Blog(article);

            var tag_ = blog.Tags.Single();
            Assert.AreEqual("TAG", tag_.Nom);
        }

    }
}
