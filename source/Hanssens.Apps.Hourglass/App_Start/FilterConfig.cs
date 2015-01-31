using System.Web;
using System.Web.Mvc;

namespace Hanssens.Apps.Hourglass
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
