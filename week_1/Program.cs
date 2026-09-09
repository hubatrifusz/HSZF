namespace week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Todo todo1 = new Todo(1, "Fogmosás");
            manager.AddTodo(todo1);
            manager.ListTodos();
        }
    }
}
