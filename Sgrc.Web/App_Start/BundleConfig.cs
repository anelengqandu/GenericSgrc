using System.Web.Optimization;

namespace Sgrc.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

          
            //CSS Theme
            bundles.Add(
                  new StyleBundle("~/ThemePluginCSS")
                  .Include("~/Resources/theme/assets/global/plugins/font-awesome/css/font-awesome.min.css", new CssRewriteUrlTransform())
                 .Include("~/Resources/theme/assets/global/plugins/simple-line-icons/simple-line-icons.min.css", new CssRewriteUrlTransform())
                 .Include("~/Resources/theme/assets/global/plugins/bootstrap/css/bootstrap.min.css",new CssRewriteUrlTransform())
                 .Include("~/Resources/theme/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css",new CssRewriteUrlTransform())
                 .Include("~/Resources/theme/assets/global/plugins/select2/css/select2.min.css",new CssRewriteUrlTransform())
                 .Include("~/Resources/theme/assets/global/plugins/select2/css/select2-bootstrap.min.css",new CssRewriteUrlTransform())
                 );

            bundles.Add(new StyleBundle("~/GlobalThemeCSS")
                .Include("~/Resources/theme/assets/global/css/components.min.css", new CssRewriteUrlTransform())
                .Include("~/Resources/theme/assets/global/css/plugins.min.css", new CssRewriteUrlTransform())
                );

            bundles.Add(new StyleBundle("~/LoginThemeCSS")
                .Include("~/Resources/theme/assets/pages/css/login-5.min.css", new CssRewriteUrlTransform())
                .Include("~/Resources/theme/loader.css", new CssRewriteUrlTransform())

               );


            bundles.Add(new ScriptBundle("~/ThemeJS").Include(
                
                "~/Resources/theme/assets/global/plugins/jquery.min.js",
                "~/Resources/theme/assets/global/plugins/bootstrap/js/bootstrap.min.js",
                "~/Resources/theme/assets/global/plugins/js.cookie.min.js",
                "~/Resources/theme/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                "~/Resources/theme/assets/global/plugins/jquery.blockui.min.js",
                "~/Resources/theme/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js",
                "~/Resources/theme/assets/global/plugins/jquery-validation/js/jquery.validate.min.js",
                "~/Resources/theme/assets/global/plugins/jquery-validation/js/additional-methods.min.js",
                "~/Resources/theme/assets/global/plugins/select2/js/select2.full.min.js",
                "~/Resources/theme/assets/global/plugins/backstretch/jquery.backstretch.min.js",
                "~/lib/abp-web-resources/Abp/Framework/scripts/abp.js",
                "~/lib/abp-web-resources/Abp/Framework/scripts/libs/abp.jquery.js",
                "~/lib/abp-web-resources/Abp/Framework/scripts/libs/abp.toastr.js",
                "~/lib/abp-web-resources/Abp/Framework/scripts/libs/abp.blockUI.js",
                "~/lib/abp-web-resources/Abp/Framework/scripts/libs/abp.spin.js",
                "~/lib/abp-web-resources/Abp/Framework/scripts/libs/abp.sweet-alert.js",
                "~/lib/signalr/jquery.signalR.js"
            ));

            bundles.Add(new ScriptBundle("~/AppScriptJS").Include(
                "~/Resources/theme/assets/global/scripts/app.min.js",
                "~/Resources/helper.widgets.js"
            ));


           

        }
    }
}