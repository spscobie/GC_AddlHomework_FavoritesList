using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day20_Lecture_FavoritesList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //this will take care of the action:
        public ActionResult AddToFavsList (string Name)
        {
            //set up a session
            if (Session["FavList"] == null)
            {
                Session.Add("FavList", new List<string>());
            }

            // fetch the list from the session
            List<string> FavList = (List<string>)Session["FavList"];

            //Check for duplication. If none then add song to the list.
            if (!FavList.Contains(Name))
            {
                FavList.Add(Name); //added a song to the favorites list
            }

            FavList.Sort();
            Session["FavList"] = FavList; //added list to the session

            ViewBag.FavList = FavList;

            return View("About");
        }
    }
}