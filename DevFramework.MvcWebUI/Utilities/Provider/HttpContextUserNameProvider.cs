using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevFramework.MvcWebUI.Utilities.Provider
{
    public class HttpContextUserNameProvider
    {
        public override string ToString()
        {
            HttpContext httpContext = HttpContext.Current;

            if(httpContext != null && httpContext.User != null && httpContext.User.Identity.IsAuthenticated)
            {
                return httpContext.User.Identity.Name;
            }

            return "Work";
        }
    }
}