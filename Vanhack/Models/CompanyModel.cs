using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vanhack.Models
{
    public class CompanyModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Summary { get; set; }

        public string Phone { get; set; }

        public string WebSite { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string Country { get; set; }

        public int Favourite { get; set; }

        public string Image { get; set; }
    }
}