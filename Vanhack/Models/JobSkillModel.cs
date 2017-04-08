
namespace Vanhack.Models
{
    public class JobSkillModel
    {
        public int Id { get; set; }

        public virtual JobModel Job { get; set; }

        public int JobId { get; set; }

        public virtual SkillModel Skill { get; set; }

        public int SkillId { get; set; }
    }
}