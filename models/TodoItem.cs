namespace TodoApi.models
{
    public class TodoItem
    {
        public long Id { get; set;}
        public string Nome {get; set;}
        public bool IsComplete { get; set; }
    }
}