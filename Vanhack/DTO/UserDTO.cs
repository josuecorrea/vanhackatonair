using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vanhack.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }

        public decimal? EnglishLevel { get; set; }

        public int? YearsOfExperience { get; set; }

        public string Skills { get; set; }

        public string Linkedin { get; set; }

    }
}