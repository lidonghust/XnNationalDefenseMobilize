﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.DefenseMobilize;
using XnNationalDefenseMobilize.Models.utility;

namespace XnNationalDefenseMobilize.Controllers
{
    public class DefenseMobilizeController : Controller
    {

        public DefenseNewsContext defenseNewsContext = new DefenseNewsContext();

        public ActionResult Index()
        {
            return View(defenseNewsContext.defenseNewsLists.ToList());
        }

        public ActionResult DefenseList(int type_id, int page_id = 1)
        {
            IEnumerable<DefenseNews> newsList = from items in defenseNewsContext.defenseNewsLists
                                                where items.defenseNewsCategory.defenseCategory_id == type_id
                                                orderby items.defenseNews_title
                                                select items;

            MulltiPageDisplayContrler multiPagesContrler = new MulltiPageDisplayContrler(newsList, 6, 5, page_id);
            return View(multiPagesContrler);
        }

        public ActionResult DefenseDetail(int id)
        {
            DefenseNews singleNews = defenseNewsContext.defenseNewsLists.Find(id);
            return View(singleNews);
        }

    }
}
