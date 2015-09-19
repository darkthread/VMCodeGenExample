using Darkthread;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetSampleData() 
        {
            List<Player> players = new List<Player>();
            players.Add(new Player("A001", "Jeffrey"));
            players.Add(new Player("A002", "Darkthread"));
            players.ForEach(o => o.GenRandomData());
            return new JsonResult()
            {
                Data = players
            };
        }
    }
}