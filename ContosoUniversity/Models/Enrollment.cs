using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Enrollment
    {

        [Key]
        public int EnrollmentId { get; set; }
        public Grade? Grade { get; set; }

        [ForeignKey("StudentId")]
        public int StudentId { get; set; }
        public Student Students { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId { get; set; }
        public Course Courses { get; set; }
    }

    public enum Grade
    {
        A, B, C, D, F
    }
}
