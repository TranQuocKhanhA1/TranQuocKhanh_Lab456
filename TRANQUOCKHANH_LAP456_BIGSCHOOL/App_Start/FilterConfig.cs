using System.Web;
using System.Web.Mvc;

namespace TRANQUOCKHANH_LAP456_BIGSCHOOL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
