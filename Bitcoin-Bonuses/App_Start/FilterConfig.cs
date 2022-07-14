using System.Web;
using System.Web.Mvc;

namespace Bitcoin_Bonuses
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}