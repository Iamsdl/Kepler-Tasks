using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BradWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int ID = 3)
        {
            int l = ((ID + 1) * (ID + 2) / 2) + 1;
            int c = 2 * ID + 1;

            ViewData["lin"] = l;
            ViewData["col"] = c;

            char[,] brad = VecMat.Matrice.Blanks(l, c);
            brad = BradApp.BradApp.RamuriBradMatrice(brad, ID, ID);
            brad = BradApp.BradApp.TrunchiBradMatrice(brad, ID);

            string b = BradApp.BradApp.ToString(brad, l, c);

            ViewData["brad"] = b;
            return View();
        }
    }
}
