using Kodlama.io.Core.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Core.DataAccess.Absract
{
    public interface IInstructorRepository
    {
        Instructor GetInstructorById(int instructorId);
        void CreateInstructor(Instructor instructor);
        void UpdateInstructor(Instructor instructor);
        void DeleteInstructor(int instructorId);
    }
}
