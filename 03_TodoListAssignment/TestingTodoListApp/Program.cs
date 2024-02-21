using System.Collections.Generic;
using System.Linq;
using TestingTodoListApp;

namespace TodoListNS
{    
    public class Program
    {
        public static void Main()
        {
            TodoList todoList = new();

            todoList.AddItemToList(new TodoTask("Do the dishes"));          
            todoList.AddItemToList(new TodoTask("Wash your clothes"));

            var listAll = todoList.All; //for iterations
            var listItems = todoList.TodoItems; //original style of getting list

            // tulostaa kaikki tehtävät
            Console.WriteLine("All tasks from list:");
            foreach (var item in listAll)
            {
                Console.WriteLine(item);
            }

            // tulostaa toisen samanlaisen listan ? onko tarpeellinen
            Console.WriteLine("\nTasks from items:");
            foreach (var item in listItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}