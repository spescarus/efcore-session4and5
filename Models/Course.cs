using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_core_Tutorial.Models
{
    public class Course
    {
        [Display(Name = "Number")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CourseId { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Range(0,5)]
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
