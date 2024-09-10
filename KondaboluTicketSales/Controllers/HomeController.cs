using KondaboluTicketSales.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

//For the 2 IAction methods there are 2 views in home directory 

namespace KondaboluTicketSales.Controllers
{
    public class HomeController : Controller
    {
        /*
         * Created by Kondabolu
         */
               public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        
    }
}
