﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace PlanGoGoAdmin
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.min.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/angularSupport").Include(
                        "~/Scripts/angular-animate.min.js",
                        "~/Scripts/angular-aria.min.js",
                        "~/Scripts/angular-cookies.min.js",
                        "~/Scripts/angular-loader.min.js",
                        "~/Scripts/angular-message-format.min.js",
                        "~/Scripts/angular-messages.min.js",
                        "~/Scripts/angular-mocks.js",
                        "~/Scripts/angular-parse-ext.min.js",
                        "~/Scripts/angular-resource.min.js",
                        "~/Scripts/angular-route.min.js",
                        "~/Scripts/angular-sanitize.min.js",
                        //"~/Scripts/angular-scenario.js",
                        "~/Scripts/angular-touch.min.js",
                        "~/Scripts/ng-table.js"
                        ));           

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/*.css",
                        "~/Content/ng-table.css"
                        ));

            //Custom scripts

            bundles.Add(new ScriptBundle("~/customscript").Include(
                        "~/CustomScripts/Common/ajax/AjaxCalls.js",
                        "~/CustomScripts/Common/ngTableParameters.js"
                        ));

            bundles.Add(new ScriptBundle("~/controllerManageUser").Include(
                        "~/CustomScripts/Controller/controllerManageUser.js"
                        ));

            bundles.Add(new ScriptBundle("~/controllerManageCountry").Include(
                        "~/CustomScripts/Controller/controllerManageCountry.js"
                        ));

        }
    }
}