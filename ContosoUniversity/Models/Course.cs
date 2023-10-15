using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course:BaseEntity
    {
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Range(0, 3)]
        public int Credits { get; set; }
        public string  Description { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        public int DepartmentID { get; set; }

        public Department Department { get; set;}

        public ICollection<CourseAssignment> CourseAssignments { get; set; }

    }
}
