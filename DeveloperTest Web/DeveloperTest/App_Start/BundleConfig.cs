using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace DeveloperTest
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Bundle for all things jquery.
            bundles.Add(new ScriptBundle("~/Scripts/jquerybundle").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-migrate-{version}.js",
                        "~/Scripts/jquery.*"));

            // Bootstrap bundle.
            bundles.Add(new ScriptBundle("~/Scripts/bootstrapbundle").Include(
                        "~/Scripts/bootstrap.js"));

            // Bundle for our participant scripts.
            bundles.Add(new ScriptBundle("~/Scripts/participantbundle").Include(
                        "~/Scripts/participant-add.js"));

            // Bundle for site level css.
            bundles.Add(new StyleBundle("~/Content/css/cssbundle").Include(
                        "~/Content/css/*.css"));
        }
    }
}