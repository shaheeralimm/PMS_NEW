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
                "~/Content/layout/dist/js/app.min.js",
                "~/Content/layout/dist/js/app.init.js",
                "~/Content/layout/dist/js/app-style-switcher.js",
                "~/Content/layout/assets/libs/perfect-scrollbar/dist/perfect-scrollbar.jquery.min.js",
                "~/Content/layout/assets/extra-libs/sparkline/sparkline.js",
                "~/Content/layout/dist/js/waves.js",
                "~/Content/layout/dist/js/sidebarmenu.js",
                "~/Content/layout/dist/js/custom.min.js",
                "~/Content/layout/dist/js/pages/dashboards/dashboard1.js",
                "~/Content/layout/assets/libs/toastr/build/toastr.min.js",
                "~/Content/layout/assets/extra-libs/toastr/toastr-init.js",
                "~/Content/layout/assets/libs/sweetalert2/dist/sweetalert2.all.min.js",
                "~/Content/layout/assets/libs/sweetalert2/sweet-alert.init.js",
                "~/Content/layout/assets/extra-libs/DataTables/datatables.min.js",
                "~/Content/layout/dist/js/pages/datatable/datatable-basic.init.js",
                "~/Content/layout/dist/js/pages/tables/js-grid-db.js",
                "~/Content/layout/assets/libs/jsgrid/dist/jsgrid.min.js",
                "~/Content/layout/dist/js/pages/tables/js-grid-init.js",
                "~/Content/layout/assets/extra-libs/jqbootstrapvalidation/validation.js",
                "~/Content/layout/assets/libs/moment/moment.js",
                "~/Content/layout/assets/libs/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js",
                "~/Content/layout/assets/libs/daterangepicker/daterangepicker.js",
                "~/Content/layout/assets/libs/pickadate/lib/compressed/picker.js",
                "~/Content/layout/assets/libs/pickadate/lib/compressed/picker.date.js",
                "~/Content/layout/assets/libs/pickadate/lib/compressed/picker.time.js",
                "~/Content/layout/assets/libs/pickadate/lib/compressed/legacy.js",
                "~/Content/layout/dist/js/pages/forms/datetimepicker/datetimepicker.init.js",
                "~/Content/layout/assets/libs/bootstrap-material-datetimepicker/js/bootstrap-material-datetimepicker-custom.js",
                "~/Content/layout/assets/libs/jquery.repeater/jquery.repeater.min.js",
                "~/Content/layout/assets/extra-libs/jquery.repeater/repeater-init.js",
                "~/Content/layout/assets/extra-libs/jquery.repeater/dff.js"
              ));

            bundles.Add(new StyleBundle("~/bootstrap/css").Include(
                "~/Content/layout/assets/libs/toastr/build/toastr.min.css",
                "~/Content/layout/assets/libs/sweetalert2/dist/sweetalert2.min.css",
                "~/Content/layout/assets/libs/datatables.net-bs4/css/dataTables.bootstrap4.css",
                "~/Content/layout/assets/libs/jsgrid/dist/jsgrid-theme.min.css",
                "~/Content/layout/assets/libs/jsgrid/dist/jsgrid.min.css",
                "~/Content/layout/assets/libs/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css",
                "~/Content/layout/assets/libs/daterangepicker/daterangepicker.css",
                "~/Content/layout/assets/libs/pickadate/lib/themes/default.css",
                "~/Content/layout/assets/libs/pickadate/lib/themes/default.date.css",
                "~/Content/layout/assets/libs/pickadate/lib/themes/default.time.css",
                "~/Content/layout/assets/libs/bootstrap-material-datetimepicker/css/bootstrap-material-datetimepicker.css"
                ));
            bundles.IgnoreList.Clear();
            bundles.IgnoreList.Ignore("*.intellisense.js");
            bundles.IgnoreList.Ignore("*-vsdoc.js");
            bundles.IgnoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            BundleTable.EnableOptimizations = true;
        }
    }
}