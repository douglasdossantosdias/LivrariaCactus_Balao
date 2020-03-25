using System.Web;
using System.Web.Mvc;

namespace LivrariaCactus_Balao {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
