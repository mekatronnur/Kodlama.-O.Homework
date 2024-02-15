using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Core.Tables
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }
        public string Name { get; set; }

        // Navigation property
        public virtual ICollection<Course> Courses { get; set; }
    }
}
