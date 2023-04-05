using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEntityFrameworkCodeFirst.Models.ViewModel
{
    public class HomepageViewModel
    {
        public List<Kisiler> Kisiler { get; set; }
        public List<Adresler> Adresler { get; set; }
    }
}