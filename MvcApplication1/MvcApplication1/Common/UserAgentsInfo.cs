using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web;
using System.IO;


namespace MvcApplication1.Common
{ 
    
    public class UserAgentsInfo: ActionFilterAttribute     
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            DateTime now = filterContext.RequestContext.HttpContext.Timestamp;
            String date = now.ToString();
            String agent = filterContext.HttpContext.Request.UserAgent;
            base.OnActionExecuting(filterContext);
            string message = ("\n User logged in using at"+date+" by using"+agent+".");
            Logdata(message);
            
        }
        private void Logdata(string msg)
        {
            
            
            using (StreamWriter sw = File.AppendText("~/Data/Data.txt"))
            {
                sw.WriteLine(msg);
                sw.WriteLine("------------------------------------------------");
            }
        }
    }
}