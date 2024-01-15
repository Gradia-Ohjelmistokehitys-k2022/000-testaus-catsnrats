using System.Collections.Generic;
using System.Linq;
using TestingTodoListApp;

namespace TodoListNS
{

    /// <summary>
    /// Todo list. You can inserts things to do. Delete them. Complete them.
    /// </summary>
    public class Program
    {

        public static void Main()
        {
            TodoList todoList = new ();

            todoList.AddItemToList(new TodoTask("Do the dishes"));
          
            todoList.AddItemToList(new TodoTask("Wash your clothes"));
            var list = todoList.All; //for iterations
            var anotherList = todoList._TodoItems; //original style of getting list
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            foreach (var item in anotherList)
            {
                Console.WriteLine(item);
            }

        }

    }
}
