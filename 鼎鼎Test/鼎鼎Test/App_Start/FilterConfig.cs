using System.Web;
using System.Web.Mvc;

namespace 鼎鼎Test
{
      public class FilterConfig
      {
            public static void RegisterGlobalFilters(GlobalFilterCollection filters)
            {
                  filters.Add(new HandleErrorAttribute());
            }
      }
}
