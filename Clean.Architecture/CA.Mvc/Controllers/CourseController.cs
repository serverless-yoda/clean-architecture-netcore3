using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA.Application.Interfaces;
using CA.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CA.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService service;

        public CourseController(ICourseService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            CourseViewModel model = service.GetCourses();
            return View(model);
        }
    }
}