using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Workull.Models.Report
{
    public abstract class ReportGenerator
    {
        public abstract ActionResult GetReport();
    }
}