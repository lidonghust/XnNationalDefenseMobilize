﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers
{
    public class DefenseMobilizeController : Controller
    {
        //
        // GET: /DefenseMobilize/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DefenseList()
        {
            return View();
        }

        public ActionResult DefenseDetail(int id)
        {
            return View();
        }

    }
}