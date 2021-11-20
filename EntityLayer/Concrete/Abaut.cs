using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Abaut
    {
        [Key]
        public int AbaoutId { get; set; }
        [StringLength(1000)]
        public string AbaoutDetails1 { get; set; }
        [StringLength(1000)]
        public string AbaoutDetails2 { get; set; }
        [StringLength(100)]
        public string AbaoutImage1 { get; set; }
        [StringLength(100)]
        public string AbaoutImage2 { get; set; }
    }
}
