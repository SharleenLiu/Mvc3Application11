using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using System.Web.Script.Serialization;

namespace Mvc3Application11.ExtensionHelper
{    
    //setup in web.config <system.web.webPages.razor>, so can be used any Razor view
    public abstract class CustomWebView : WebPage
    {
        public IHtmlString MYData(object data)
        {
            return DisplayExtensions.MYData(data);
        }
    }

    public static class DisplayExtensions
    {
        /// <summary>
        /// Returns an Html-Encoded string to be put inline with an Html Element with the
        /// data-attribute name "data-my".  Ie, returns: data-my="{ encoded Json }"
        /// </summary>
        public static IHtmlString MYData(object data)
        {
            var serializer = new JavaScriptSerializer();
            return new HtmlString(string.Format(
                "data-my=\"{0}\"",
                HttpContext.Current.Server.HtmlEncode(serializer.Serialize(data))
                ));
        }
    }


}