using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Electronics_Store.Models;


namespace Electronics_Store.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BaseController : Controller
    {
        protected ElectronicsStoreDbEntities _ctx = new ElectronicsStoreDbEntities();
    }
}