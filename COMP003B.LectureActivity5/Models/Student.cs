﻿using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureActivity5.Models
{
    public class Student
    {

        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]

        public string Email { get; set; }

        public virtual ICollection<Enrollment>? Enrollment { get; set; }
    }
}
