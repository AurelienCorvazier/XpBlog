using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace XpBlog.Html
{
    public class Export_Blog_Html
    {
        private List<Page> _fichiers_Htmls { get; }

        public Export_Blog_Html(List<Page> fichiers_Htmls)
        {
            _fichiers_Htmls = fichiers_Htmls.ToList();
        }

        public void Creer_Fichiers(string directory_output)
        {
            if (Directory.Exists(directory_output))
                Directory.Delete(directory_output, true);

            Directory.CreateDirectory(directory_output);

            foreach (var fichier_html in _fichiers_Htmls)
            {
                var directories = fichier_html.FileName.Split("/");
                var first = directories.FirstOrDefault();
                if (first != null && !first.Contains(".html"))
                {
                    var directoryPath = Path.Combine(directory_output, first);
                    Directory.CreateDirectory(directoryPath);
                }

                var filePath = Path.Combine(directory_output, fichier_html.FileName);
                var sw = new StreamWriter(filePath);
                sw.WriteLine(fichier_html.Html);
                sw.Close();
            }
        }
    }
}
