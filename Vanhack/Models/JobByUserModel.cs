using System;


namespace Vanhack.Models
{
    public class JobByUserModel
    {
        public int Id { get; set; }
        public bool Applied { get; set; }

        public DateTime Data { get; set; }

        public bool Contanted { get; set; }

        public int UserId { get; set; }

        public virtual UserModel User { get; set; }

        public int JobId { get; set; }

        public virtual JobModel Job { get; set; }

        public bool Favorite { get; set; }

        public int ApplicationStatus { get; set; }

        public string AreYouGoodForThisJob { get; set; }
    }
}