using System.Web;
using System.Web.Mvc;

namespace CB180936_AR172433_DESAFIO01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
