namespace projectEF.Models
{
    public class Task
    {
        public Guid TaskId { get; set; }
        public Guid CatergoryId { get; set; }
        public string Title { get; set; }
        public string Descripcion { get; set; }
        public Priority PriorityTask {get; set;} 
        public DateTime CreationDate { get; set; }
        public virtual Category Category { get; set; }
    }

    public enum Priority {
        Baja, 
        Media, 
        Alta 
    }
}