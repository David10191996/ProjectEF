using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectEF.Models
{
    public class Tasks
    {
        [Key]
        public Guid TaskId { get; set; }
        [ForeignKey("CategoryId")]
        public Guid CatergoryId { get; set; } 
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        public string Descripcion { get; set; }
        public Priority PriorityTask {get; set;} 
        public DateTime CreationDate { get; set; }
        [NotMapped]
        public string Summary { get; set; }
        public virtual Category Category { get; set; }
    }

    public enum Priority {
        Baja, 
        Media, 
        Alta 
    }
}