﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.News;
using XnNationalDefenseMobilize.Models.utility;

namespace XnNationalDefenseMobilize.Controllers
{
    public class NewsController : Controller
    {
        NewsInfoContext newsContext = new NewsInfoContext();


        public ActionResult Index()
        {
            return View(newsContext.newsInfoLists.ToList());
        }

        public ActionResult NewsList(int type_id, int page_id = 1)
        {
            IEnumerable<NewsInfo> newsList = from items in newsContext.newsInfoLists
                                             where items.newsCategory.newsCategory_id == type_id
                                             orderby items.news_title
                                             select items;

            MulltiPageDisplayContrler multiPagesContrler = new MulltiPageDisplayContrler(newsList,6,5, page_id);
            return View(multiPagesContrler);
        }


        public ActionResult NewsDetail(int id)
        {
            NewsInfo singleNews = newsContext.newsInfoLists.Find(id);
            return View(singleNews);
        }
    }
}