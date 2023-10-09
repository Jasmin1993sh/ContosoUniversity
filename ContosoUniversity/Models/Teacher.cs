using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    [Table(nameof(Teacher))]
    public class Teacher:BaseEntity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        
        public int? Age { get; set; }
    }
}
