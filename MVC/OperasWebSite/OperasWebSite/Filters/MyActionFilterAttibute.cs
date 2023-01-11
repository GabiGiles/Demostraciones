using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Diagnostics;
using System.Web.Mvc;
namespace OperasWebSite.Filters
{
    public class MyActionFilterAttibute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("Antes de invocar el acción - OnActionExecuting");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("Despúes de invocar el acción - OnActionExecuted");
        }
    }
}