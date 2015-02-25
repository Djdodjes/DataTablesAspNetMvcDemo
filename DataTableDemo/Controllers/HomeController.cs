using System.Globalization;
using DataTableDemo.Models;
using DataTableDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTableDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ServiceBrowser SrvBrowser;
        public HomeController()
        {
            SrvBrowser = new ServiceBrowser();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DataTablesDemoWithAjax()
        {
            return View();
        }

        public ActionResult DataTablesDemoFull()
        {
            return View();
        }

        [HttpGet]
        public JsonResult LoadBrowsers(DataTableParamModel param)
        {
            // Browser list
            var totalBrowserList = SrvBrowser.ListOfBrowsers();

            var filteredBrowserList = totalBrowserList.Skip(param.iDisplayStart).Take(param.iDisplayLength);

            var filteredResult = from b in filteredBrowserList
                                 select new[] { b.Engine, b.Browser, b.Platform, b.Version, b.Grade };

            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = totalBrowserList.Count(),
                iTotalDisplayRecords = totalBrowserList.Count(),
                aaData = filteredResult
            },
              JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult LoadBrowsersFull(DataTableParamModel param, string bwsrCreatedDate)
        {
            // Browser list
            var totalBrowserList = SrvBrowser.ListOfBrowsers();
            IEnumerable<BrowserModel> filteredBrowserList;

            // filter keyword search
            if (!string.IsNullOrEmpty(param.sSearch))
            {
                // limit search in column 1 and 2 
                var isBrowserSearchable = Convert.ToBoolean(Request["bSearchable_1"]);
                var isEngineSearchable = Convert.ToBoolean(Request["bSearchable_0"]);

                filteredBrowserList = totalBrowserList.Where(bwsr =>
                                isBrowserSearchable && Convert.ToString(bwsr.Browser).Contains(param.sSearch.ToLower()) ||
                                isEngineSearchable && bwsr.Engine.ToLower().Contains(param.sSearch.ToLower()));
            }
            else
            {
                // No search filter
                filteredBrowserList = totalBrowserList;
            }

            var isBrowserPlatformSortable = Convert.ToBoolean(Request["bSortable_2"]);
            var sortColumnIndex = Convert.ToInt32(Request["iSortCol_0"]);
            Func<BrowserModel, string> orderingFunction = (bwsr =>
                                    sortColumnIndex == 2
                                    && isBrowserPlatformSortable ? Convert.ToString(bwsr.Platform) : "");

            
            var sortDirection = Request["sSortDir_0"];

            // asc or desc ofr column Platform
            filteredBrowserList = sortDirection == "asc" 
                ? filteredBrowserList.OrderBy(orderingFunction) 
                : filteredBrowserList.OrderByDescending(orderingFunction);

            var displayedFilteredBrowserList = filteredBrowserList.Skip(param.iDisplayStart).Take(param.iDisplayLength);

            var filteredResult = from b in displayedFilteredBrowserList
                                 select new[] { b.Engine, b.Browser, b.Platform, b.Version, b.Grade };

            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = totalBrowserList.Count(),
                iTotalDisplayRecords = totalBrowserList.Count(),
                aaData = filteredResult
            },
              JsonRequestBehavior.AllowGet);
        }
    }
}