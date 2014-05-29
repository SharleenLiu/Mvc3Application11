using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;


namespace Mvc3Application11.ExtensionHelper
{
    public static class ExHelper
    {
        public static HelperResult List<T>(this IEnumerable<T> items, Func<T, HelperResult> template)
        {
            return new HelperResult(writer =>
            {
                foreach (var item in items)
                {
                    template(item).WriteTo(writer);
                }
            });
        }
    }

    
   

}