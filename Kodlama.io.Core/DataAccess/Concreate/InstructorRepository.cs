using Kodlama.io.Core.Context;
using Kodlama.io.Core.DataAccess.Absract;
using Kodlama.io.Core.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Core.DataAccess.Concreate
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly CourseContext _courseContext;
        public InstructorRepository(CourseContext courseContext)
        {
            _courseContext =courseContext;
        }
        public void CreateInstructor(Instructor instructor)
        {
           _courseContext.Instructors.Add(instructor);
            _courseContext.SaveChanges();
        }

        public void DeleteInstructor(int instructorId)
        {
            var instructor = _courseContext.Instructors.Find(instructorId);
            if (instructor != null)
            {
                _courseContext.Instructors.Remove(instructor);
                _courseContext.SaveChanges();
            }
        }

        public Instructor GetInstructorById(int instructorId)
        {
            return _courseContext.Instructors.Find(instructorId);
        }

        public void UpdateInstructor(Instructor instructor)
        {
            _courseContext.Instructors.Update(instructor);
            _courseContext.SaveChanges();
        }
    }
}
