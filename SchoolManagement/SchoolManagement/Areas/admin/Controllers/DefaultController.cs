﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Areas.admin.Controllers
{
    public class DefaultController : Controller
    {
        // GET: admin/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}