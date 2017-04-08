using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vanhack.DTO
{
    public class JobDTO
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string Position { get; set; }

        public string CityCountry { get; set; }

        public DateTime? Published { get; set; }

        public string PrincipalSkill { get; set; }
    }
}