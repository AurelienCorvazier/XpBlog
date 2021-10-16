using Renci.SshNet;
using System;
using System.IO;
using XpBlog.AC;
using XpBlog.Html;

namespace XpBlog
{
    class Program
    {
        static void Main()
        {
            //var adresse_site = "file:///C:/Users/aurel/Documents/XpBlog";
            var adresse_site = "http://martin-arthur.alwaysdata.net/";

            var blog = MonBlog.Get_Blog();

            string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directory_output = Path.Combine(myDocuments, "XpBlog");

            var blog_html = new Blog_html(adresse_site, blog.Tags, blog.Articles);
            var export = new Export_Blog_Html(blog_html.Pages);
            export.Creer_Fichiers(directory_output);

            var pauth = new PasswordAuthenticationMethod("martin-arthur", "7syAZB=#wHzRqsdMM:");
            var connectionInfo = new ConnectionInfo("ssh-martin-arthur.alwaysdata.net", "martin-arthur", pauth);

            var publish_sftp = new Pubish_SFTP(connectionInfo);
            publish_sftp.UploadDirectory(directory_output, "www");

        }

    }
}
