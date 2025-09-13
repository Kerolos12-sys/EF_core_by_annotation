using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core__by_annotation
{
    internal class Topic
    {
        [Key]
        public int Topic_ID { get; set; }

        [Required, MaxLength(100)]
        public string Topic_Name { get; set; }
    }
}
