using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vanhack.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Bio { get; set; }

        public DateTime? BornDate { get; set; }

        public string CurrentEmployer { get; set; }

        public string Position { get; set; }

        public decimal? EnglishLevel { get; set; }

        public int? YearsOfExperience { get; set; }

        public string Skills { get; set; }

        public string WebSite { get; set; }

        public string GitHub { get; set; }

        public string Linkedin { get; set; }

        public int? PrincipalSkill { get; set; }

        public bool CvChecked { get; set; }
    }
}