using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vanhack.Models
{
    public class JobModel
    {
        public int Id { get; set; }

        public string AboutUs { get; set; }

        public string AboutYourTeam { get; set; }

        public string AboutThisRole { get; set; }

        public string Responsibilities { get; set; }

        public string Qualifications { get; set; }

        public string Benefits { get; set; }

        public int JobType { get; set; }

        public DateTime? PostDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Email { get; set; }

        public bool Deleted { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public virtual UserModel User { get; set; }

        public int UserId { get; set; }

        public virtual JobPositionModel JobPosition { get; set; }

        public int JobPositionId { get; set; }

        public int PrincipalSkill { get; set; }

        public virtual CompanyModel Company { get; set; }

        public int CompanyId { get; set; }

        public string Position { get; set; }

        public bool Applied { get; set; }

        public bool RemoteJob { get; set; }

        public bool Private { get; set; }

        public int? UserRecruiterId { get; set; }

        public double? Salary { get; set; }

        public double? Commission { get; set; }

        public int? NumberOfPosition { get; set; }

        public int? YearOfExperience { get; set; }
    }
}