namespace MVC_One.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "New Task Default Name";
        public int Progress { get; set; } = 0;
    }
}
