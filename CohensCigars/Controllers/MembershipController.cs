﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CohensCigars.Controllers
{
    public class MembershipController : Controller
    {
        // GET: Membership
        public ActionResult Index()
        {
            return View();
        }
    }
}