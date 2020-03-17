using CA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
