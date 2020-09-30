using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
     
        Lessons[] les = {
         new Lessons {Lesson_Id = 1, Name_Group = "ІПЗ", All_students=25, Students_attended=18},
         new Lessons {Lesson_Id = 2, Name_Group = "КС", All_students=30, Students_attended=15},
         new Lessons {Lesson_Id = 3, Name_Group = "ОМ", All_students=20, Students_attended=12},
         new Lessons {Lesson_Id = 4, Name_Group = "КН", All_students=22, Students_attended=13},
     };
     


        public ActionResult Index()
        {
            return View(les);
        }
    }
}