using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core__by_annotation
{
    internal class Instructor
    {
        [Key]
        public int Inst_ID { get; set; }

        [Required, MaxLength(100)]
        public string Inst_Name { get; set; }

        [Required, MaxLength(50)]
        public string Dept_Name { get; set; }
    }
}
