using System.Web;
using System.Web.Optimization;

namespace NgoReportingSystem
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*",
                        "~/Content/js/jquery-1.10.2.min.js",
                        "~/Content/js/bootstrap.min.js",
                        "~/Content/js/minjs.js",
                        "~/Content/assets/js/jquery-2.0.3.min.js",
                        "~/Content/assets/js/jquery.mobile.custom.min.js",
                        "~/Content/js/griddata.js"));

            bundles.Add(new StyleBundle("~/Content/css/css").Include(
                       "~/Content/css/bootstrap.min.css",
                       "~/Content/css/font-awesome.min.css",
                       "~/Content/css/local.css",
                       "~/Content/css/shieldui-all.min.css",
                       "~/Content/assets/css/bootstrap.min.css",
                       "~/Content/assets/css/font-awesome.min.css",
                       "~/Content/assets/css/ace-fonts.css",
                       "~/Content/assets/css/ace.min.css",
                       "~/Content/assets/css/ace-rtl.min.css",
                       "~/Content/css/light-bootstramp.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}