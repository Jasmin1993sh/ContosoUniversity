using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    [Table(nameof(Student))]
    public class Student : BaseEntity
    {
        
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Full Name")]
        public string FullName => FirstMidName + ","+LastName;
        

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.FirstMidName).Length(5, 20).NotNull();


        }
    }
}
