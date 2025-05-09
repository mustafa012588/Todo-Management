using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class Todo
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        public string? Description { get; set; }

        [Required]
        public string Status { get; set; } = "Pending"; 

        [Required]
        public string Priority { get; set; } = "Medium"; 

        public DateTime? DueDate { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;
    }
}
