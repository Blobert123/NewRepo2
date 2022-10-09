using System.Web;
using System.Web.Mvc;

namespace PI4_Inleveropdracht_Web_application
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
