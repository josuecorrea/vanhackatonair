

namespace Vanhack.Models
{
    public class UserSkillModel
    {
        public int Id { get; set; }

        public virtual UserModel User { get; set; }

        public int UserId { get; set; }

        public virtual SkillModel Skill { get; set; }

        public int SkillId { get; set; }

        public int? YeatsOfExperience { get; set; }
    }
}