using System.Web;
using System.Web.Optimization;

namespace BarbisanWebProject
{
    public class BundleConfig
    {
        // Weitere Informationen zur Bündelung finden Sie unter https://go.microsoft.com/fwlink/?LinkId=301862.
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/minusPlus").Include(
                       "~/Scripts/minusPlus.js"));


            // Verwenden Sie die Entwicklungsversion von Modernizr zum Entwickeln und Erweitern Ihrer Kenntnisse. Wenn Sie dann
            // bereit ist für die Produktion, verwenden Sie das Buildtool unter https://modernizr.com, um nur die benötigten Tests auszuwählen.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-Lux.css",
                      "~/Content/Footer-Dark.css",
                      "~/Content/Header-Blue.css",
                      "~/Content/Navigation-with-Button.css",
                      "~/Content/ionicons.min.css",
                      "~/Content/SchalungselementBox.css",
                      "~/Content/site.css"));
        }
    }
}
