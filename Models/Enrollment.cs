using System.ComponentModel.DataAnnotations;

namespace Ef_core_Tutorial.Models
{
    public class Enrollment
    {
        public long Id { get; set; }
        public long CourseId { get; set; }
        public long StudentId { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }

    public enum Grade
    {
        A, B, C, D ,F
    }
}
