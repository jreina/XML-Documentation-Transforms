using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocumentedMvcApplication.Controllers
{
    /// <summary>
    /// This is the controller for the Documented Widget.
    /// 
    /// This widget does some things to the database on the back end.
    /// 
    /// On the front end, this widget has some very specific requirements in the CMS, here they are:
    /// 
    /// 1. Requirement 1  
    /// 
    /// 2. Requirement 2  
    /// 
    /// 3. Requirement 3  
    /// 
    /// 4. Requirement 4  
    /// </summary> 
    public class DocumentedWidgetController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
