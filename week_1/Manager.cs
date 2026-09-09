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
            Console.WriteLine($"{todo.Title} hozzáadva!");
        }

        public void ListTodos()
        {
            foreach (var t in todos)
            {
                Console.WriteLine(t.ToString());
            }
        }
    }
}
