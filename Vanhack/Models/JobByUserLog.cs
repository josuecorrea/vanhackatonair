using System;


namespace Vanhack.Models
{
    public class JobByUserLog
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int ApplicationsStatus { get; set; }

        public int JobByUserId { get; set; }

        public virtual JobByUserModel JobByUser { get; set; }

        public int IdUserApplcation { get; set; }

    }
}