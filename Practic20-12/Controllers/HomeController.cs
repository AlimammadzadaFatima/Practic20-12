using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practic20_12.Models;
using Practic20_12.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Practic20_12.Controllers
{
    public class HomeController : Controller
    {
       
            private DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
              Courses = _context.Courses.ToList()
            };
            return View(homeVM);
        }

        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult getcourse(int id)
        {
            Course course = _context.Courses.FirstOrDefault(x => x.Id == id);

            //return Json(book);
            return PartialView("ModalCourseDetail", course);
        }
    }
}
