using CA.Application.Interfaces;
using CA.Application.ViewModels;
using CA.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repo;

        public CourseService(ICourseRepository repo)
        {
            _repo = repo;
        }
        
        CourseViewModel ICourseService.GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _repo.GetCourses()
            };
        }
    }
}
