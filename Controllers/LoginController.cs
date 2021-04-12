using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.Mvc;
using Mobile_Affordability_Application.Models;
namespace Mobile_App.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Authorise(User user)
        {
            using (MobileDBEntities db = new MobileDBEntities())
            {
                var userDetail = db.Users.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
                if (userDetail == null)
                {
                    user.LoginErrorMessage = "Invalid username or password";
                    return View("index", user);
                }
                else
                {
                    Session["userID"] = user.UserID;
                    return RedirectToAction("Index", "Home");
                }
            }

        }
        public ActionResult Logout()
        {

            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }

    }
}