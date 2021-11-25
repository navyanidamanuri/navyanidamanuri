using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp1.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult GuessingGame()
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 100);
            Session["rndNumber"] = n;            
            return View();
        }

        [HttpPost]
        public ActionResult GuessingGame(string txtGame)
        {
            int x = int.Parse(txtGame);
            if (x >= 1 && x <= 100)
            {
                int n = int.Parse(Session["rndNumber"].ToString());
                if (x == n)
                    ViewBag.info = "Congrats, You Won Game";
                if (x > n)
                    ViewBag.info = "Sorry, Given value is greater to generated value";
                if (x < n)
                    ViewBag.info = "Sorry, Given value is lesser to generated value";
                Random rnd = new Random();
                Session["rndNumber"] = rnd.Next(1, 100);                
            }
            else
                ViewBag.info = "Value must be in 1-100";
            
            return View();
        }
    }
}