using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Core.Tables
{
    public class Category
    {
        [Key] 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // Navigation property
        public virtual ICollection<Course> Courses { get; set; }


    }
}
