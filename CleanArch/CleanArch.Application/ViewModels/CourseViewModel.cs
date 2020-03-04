using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModels
{
    class CourseViewModel
    {
        public IEnumerable<Course> GetCourses { get; set; }
        
    }
}
