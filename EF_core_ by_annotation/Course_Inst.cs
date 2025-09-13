using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core__by_annotation
{
    internal class Course_Inst
    {

        [Key]
        public int ID { get; set; }


        [Required]
        public int Inst_ID { get; set; }

        [Required]
        public int Course_ID { get; set; }

        [MaxLength(250)]
        public string Evaluate { get; set; }
    }
}
