using System.Web;
using System.Web.Mvc;

namespace fsharp.razor.template {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
