using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Core.Tables
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public string CourseDescription { get; set; }
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }

        // Navigation properties
        [ForeignKey("InstructorId")]
        public virtual Instructor Instructor { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

    }
}
