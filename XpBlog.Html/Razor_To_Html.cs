using RazorEngineCore;
using RazorEngine = RazorEngineCore.RazorEngine;

namespace XpBlog.Html
{
    internal class Razor<T>
    {
        public string Html { get; }

        public Razor(string path_code_cshtml, T model)
        {
            var razorEngine = new RazorEngine();
            var razorContent = System.IO.File.ReadAllText(path_code_cshtml, System.Text.Encoding.UTF8);
            var template = razorEngine.Compile<RazorEngineTemplateBase<T>>(razorContent, builder =>
            {
                //builder.AddAssemblyReferenceByName("System.Security"); // by name
                builder.AddAssemblyReference(typeof(XpBlog.Domain.Chapitre)); // by type
                //builder.AddAssemblyReference(Assembly.Load("source")); // by reference
            });


            string html_r = template.Run(instance =>
            {
                instance.Model = model;
            });

            Html = html_r;
        }

    }
}