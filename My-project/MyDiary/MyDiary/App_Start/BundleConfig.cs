using System.Web;
using System.Web.Optimization;

namespace MyDiary
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery.js",
                        "~/Scripts/jquery-{version}.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            //My script
            bundles.Add(new ScriptBundle("~/bundles/otherscript").Include(
                      "~/Scripts/bootstrap-filestyle.js",
                       "~/Scripts/function.js",
                       "~/Scripts/owl.carousel.min.js",
                       "~/Scripts/jquery-ui.js",
                       "~/Content/star-rating/js/star-rating.js",
                       "~/Scripts/sweet-alert.js"                       
                       ));

            bundles.Add(new ScriptBundle("~/bundles/myscript").Include(
                     "~/Scripts/myscript.js"
                       ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //My CSS
            bundles.Add(new StyleBundle("~/Content/mycss").Include(
                      "~/Content/business-casual.css",
                      "~/Content/style.css",
                      "~/Content/star-rating/css/star-rating.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/jquery-ui.theme.css",
                      "~/Content/sweet-alert.css"                      
                      ));
        }
    }
}
