namespace QuikerBackend.Api.Models
{
    public class TodoTask
    {
        public TodoTask(Guid id, string name, DateTime dueDate)
        {
            Id = id;
            Name = name;
            DueDate = dueDate;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
    }
}
