using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Shop.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/bundles/animate/css")
             .Include("~/fonts/css/animate.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/bootstrap.min/css")
             .Include("~/fonts/css/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/core-style/css")
             .Include("~/fonts/css/core-style.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/font-awesome.min/css")
              .Include("~/fonts/css/font-awesome.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/jquery-ui.min/css")
              .Include("~/fonts/css/jquery-ui.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/magnific-popup/css")
            .Include("~/fonts/css/magnific-popup.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/main/css")
            .Include("~/fonts/css/main.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/nouislider/css")
            .Include("~/fonts/css/nouislider.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/owl.carousel/css")
            .Include("~/fonts/css/owl.carousel.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/responsive/css")
            .Include("~/fonts/css/responsive.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/themify-icons/css")
            .Include("~/fonts/css/themify-icons.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/util/css")
            .Include("~/fonts/css/util.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/style/css")
             .Include("~/fonts/fonts/style.css", new CssRewriteUrlTransform()));


            bundles.Add(new ScriptBundle("~/bundles/jquery/jquery-2.2.4.min/js")
            .Include("~/Scripts/js/jquery/jquery-2.2.4.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/popper.min/js")
            .Include("~/Scripts/js/popper.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap.min/js")
            .Include("~/Scripts/js/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/plugins/js")
            .Include("~/Scripts/js/plugins.js"));
            bundles.Add(new ScriptBundle("~/bundles/active/js")
            .Include("~/Scripts/js/active.js"));


        }
    }
}