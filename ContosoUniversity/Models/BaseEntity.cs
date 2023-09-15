using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class BaseEntity
    {
        [Key]
        [Required]
        //public Guid Id { get; set; }
        public int Id { get; set; }
    }
}
