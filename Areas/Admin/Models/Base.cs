using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Electronics_Store.Models;

namespace Electronics_Store.Areas.Admin.Models
{
    public class Base
    {
        protected ElectronicsStoreDbEntities _ctx = new ElectronicsStoreDbEntities();
    }
}