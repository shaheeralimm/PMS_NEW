using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Store.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bootstrap/js").Include("~/Content/layout/assets/libs/jquery/dist/jquery.min.js",
                "~/Content/layout/assets/libs/popper.js/dist/umd/popper.min.js",
                "~/Content/layout/assets/libs/bootstrap/dist/js/bootstrap.min.js",
                "~/Content/layout/assets/libs/perfect-scrollbar/dist/perfect-scrollbar.jquery.min.js",
                "~/Content/layout/assets/extra-libs/sparkline/sparkline.js",
                "~/Content/layout/dist/js/waves.js",
                "~/Content/layout/dist/js/sidebarmenu.js",
                "~/Content/layout/dist/js/custom.min.js",
                "~/Content/layout/assets/libs/flot/excanvas.js",
                "~/Content/layout/assets/libs/flot/jquery.flot.js",
                "~/Content/layout/assets/libs/flot/jquery.flot.pie.js",
                "~/Content/layout/assets/libs/flot/jquery.flot.time.js",
                "~/Content/layout/assets/libs/flot/jquery.flot.stack.js",
                "~/Content/layout/assets/libs/flot/jquery.flot.crosshair.js",
                "~/Content/layout/assets/libs/flot.tooltip/js/jquery.flot.tooltip.min.js",
                "~/Content/layout/dist/js/pages/chart/chart-page-init.js",
                "~/Content/layout/assets/extra-libs/multicheck/datatable-checkbox-init.js",
                "~/Content/layout/assets/extra-libs/multicheck/jquery.multicheck.js",
                "~/Content/layout/assets/extra-libs/DataTables/datatables.min.js",
                "~/Content/layout/assets/libs/toastr/build/toastr.min.js",
                "~/Content/layout/assets/libs/magnific-popup/dist/jquery.magnific-popup.min.js",
                "~/Content/layout/assets/libs/magnific-popup/meg.init.js"));

            bundles.Add(new StyleBundle("~/bootstrap/css").Include("~/Content/layout/assets/libs/flot/css/float-chart.css",
                "~/Content/layout/assets/extra-libs/multicheck/multicheck.css",
                "~/Content/layout/assets/libs/datatables.net-bs4/css/dataTables.bootstrap4.css",
                "~/Content/layout/assets/libs/toastr/build/toastr.min.css",
                "~/Content/layout/assets/libs/magnific-popup/dist/magnific-popup.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}