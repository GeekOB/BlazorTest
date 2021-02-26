namespace TestWebAssembly.Pages.ToDo
{
    public class ToDoItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"[Title={Title}|Description={Description}]";
        }
    }
}