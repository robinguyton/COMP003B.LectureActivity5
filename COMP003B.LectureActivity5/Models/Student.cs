using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureActivity5.Models
{
    public class Student
    {

        public int StudentId { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        public virtual ICollection<Enrollment>? Enrollments { get; set; }

        public int Age { get; set; }
    }
}
