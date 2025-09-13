using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core__by_annotation
{
    internal class Stud_Course
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int Stud_ID { get; set; }

        [Required]
        public int Course_ID { get; set; }

        [Range(0, 100)]
        public int Grade { get; set; }
    }
}
