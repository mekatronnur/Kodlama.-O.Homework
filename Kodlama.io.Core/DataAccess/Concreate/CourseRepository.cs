using Kodlama.io.Core.Context;
using Kodlama.io.Core.DataAccess.Absract;
using Kodlama.io.Core.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Core.DataAccess.Concreate
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CourseContext _context;
        public CourseRepository(CourseContext courseContext)
        {
            _context = courseContext;
        }
        public void CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void DeleteCourse(int courseId)
        {
            var course = _context.Courses.Find(courseId);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }

        public Course GetCourseById(int courseId)
        {
            return _context.Courses.Find(courseId);
        }

        public void UpdateCourse(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
        }
    }
}
