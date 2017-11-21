using System.Web;
using System.Web.Mvc;

namespace Day20_Lecture_FavoritesList
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
