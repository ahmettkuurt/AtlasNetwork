using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class References
    {
        [Key]
        public int ReferencesID { get; set; }
        public string ReferencesImage { get; set; }
        public string ReferencesTitle { get; set; }
        public string ReferencesDescription { get; set; }

    }
}
