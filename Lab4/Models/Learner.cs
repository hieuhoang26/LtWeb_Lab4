namespace ThucHanh1.Models
{
    public class Learner
    {
        public int LearnerID { get; set; }

        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int MajorID { get; set; }
        public Majors Major { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
