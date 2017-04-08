using System;

namespace Vanhack.Models
{
    public class JobExperienceModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual UserModel User { get; set; }

        public string CompanyName { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public string StateProvince { get; set; }

        public string Country { get; set; }

    }
}