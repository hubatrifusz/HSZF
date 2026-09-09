using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_1
{
    public class Manager
    {
        private List<Todo> todos = new();

        public void AddTodo(Todo todo)
        {
            todos.Add(todo);
            Console.WriteLine($"{todo.Title} added!");
        }

        public void ListTodos()
        {
            foreach (var t in todos)
            {
                Console.WriteLine(t.ToString());
            }
        }

        public void CompleteTodo(Todo todo)
        {
            todo.IsCompleted = true;
            Console.WriteLine($"{todo.Title} done!");
        }
    }
}
