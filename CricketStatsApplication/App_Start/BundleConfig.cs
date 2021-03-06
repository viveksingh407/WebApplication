﻿using System.Web;
using System.Web.Optimization;

namespace CricketStatsApplication
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/CustomCss").Include(
                      "~/Content/Custom/site.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/CricketTournamentApp")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .Include("~/Scripts/CricketTournamentApp.js"));
        }
    }
}
