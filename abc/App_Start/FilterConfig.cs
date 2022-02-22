using System.Web;
using System.Web.Mvc;

namespace VPPUP_NEW_VERSION
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
