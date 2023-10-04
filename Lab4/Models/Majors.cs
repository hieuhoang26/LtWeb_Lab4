using System.ComponentModel.DataAnnotations;

namespace ThucHanh1.Models
{
    public class Majors
    {
        [Key]
        public int MajorID { get; set; }
        public string MajorName { get; set; }
        public ICollection<Learner> Learners { get; set; }
    }
}
