using System.Web;
using System.Web.Mvc;

namespace HuynhThiThuyTrang_2080600142
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
