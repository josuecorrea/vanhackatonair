using System;

namespace Vanhack.Models
{
    public class EducationModel
    {
        public int Id { get; set; }

        public string Name{ get; set; }

        public string Location { get; set; }

        public string Course { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int UserId { get; set; }

        public virtual UserModel User { get; set; }

        public int Order { get; set; }

        public string StateProvince { get; set; }

        public string Country { get; set; }
    }
}