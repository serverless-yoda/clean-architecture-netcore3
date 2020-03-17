using CA.Domain.Entities;
using CA.Domain.Interfaces;
using CA.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CleanArchDBContext _context;

        public CourseRepository(CleanArchDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
