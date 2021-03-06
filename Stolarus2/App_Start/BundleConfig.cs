﻿using System.Web;
using System.Web.Optimization;

namespace Stolarus2
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            //bundles.Add(new ScriptBundle("~/bundles/angular")
            //            .Include("~/Scripts/angular.js")
            //            .Include("~/Scripts/modules/stolarus/controllers/article.js")
            //            .Include("~/Scripts/modules/stolarus/controllers/certificates.js")
            //            .Include("~/Scripts/modules/stolarus/controllers/contacts.js")
            //            .Include("~/Scripts/modules/stolarus/controllers/portfoliodetails.js")
            //            .Include("~/Scripts/modules/stolarus/controllers/portfolios.js")
            //            .Include("~/Scripts/modules/stolarus/controllers/portfoliotypes.js")
            //            .Include("~/Scripts/modules/stolarus/controllers/productcategories.js")
            //            .Include("~/Scripts/modules/stolarus/controllers/products.js")
            //            .Include("~/Scripts/modules/stolarus/controllers/quotes.js")
            //            .Include("~/Scripts/modules/stolarus/controllers/sliders.js")
            //            .Include("~/Scripts/modules/stolarus/app.js")
            //            );

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
