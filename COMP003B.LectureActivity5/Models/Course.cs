using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureActivity5.Models
{
    public class Course
    {
        public int StudentId { get; set; }

        [Required]
        public string Title { get; set; }

        public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }
}
