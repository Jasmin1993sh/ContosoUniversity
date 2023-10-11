﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course:BaseEntity
    {
   
        public string Title { get; set; }
        public int Credits { get; set; }
        public string  Description { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
       
    }
}
