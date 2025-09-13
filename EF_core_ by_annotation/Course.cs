using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core__by_annotation
{
    internal class Course
    {
        [Key]
        public int Course_ID { get; set; }

        [Required, MaxLength(100)]
        public string Course_Name { get; set; }

        [Range(1, 10)]
        public int Credit_Hours { get; set; }
    }
}
