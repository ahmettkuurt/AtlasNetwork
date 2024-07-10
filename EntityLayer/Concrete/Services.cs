using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Services
    {
        [Key]
        public int ServicesID { get; set; }
        public string ServicesImage { get; set; }
        public string ServicesName { get; set; }
        public string ServicesDescription { get; set; }
    }
}
