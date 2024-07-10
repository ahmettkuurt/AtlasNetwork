using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MainPage
    {
        [Key]
        public int MainPageID { get; set; }

        
        public string factshostingsales { get; set; }
        public string factsdomainregistered { get; set; }
        public string factsresolvedsupport { get; set; }
        public string factshappycustomer { get; set; }

    }
}
