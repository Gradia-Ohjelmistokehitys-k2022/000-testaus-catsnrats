﻿using System;
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
            
            // lisää tehtäviä listaan
            todoList.AddItemToList(new TodoTask("Go to the gym"));
            todoList.AddItemToList(new TodoTask("Buy groceries"));
            todoList.AddItemToList(new TodoTask("Study C# for 7 hours"));
            todoList.AddItemToList(new TodoTask("Study spanish for 2 hours"));
            todoList.AddItemToList(new TodoTask("Make dinner"));
            todoList.AddItemToList(new TodoTask("Do the dishes"));          
            todoList.AddItemToList(new TodoTask("Wash your clothes"));
            todoList.AddItemToList(new TodoTask("Vacuum the living room"));

            var listDone = todoList.DoneTasks;
            var listAll = todoList.All; //for iterations            
            var listYetTodo = todoList.TodoItems.ToList(); // tekemättömille tehtäville
            var tasksCopy = listAll.ToList(); // iterointiin listAll kopio -> vältää 'collection was modified' poikkeuksen

            // prints all tasks and asks if it's doneS
            Console.WriteLine("Mark tasks as done (yes/y or no/n):");
                       
            foreach (var item in tasksCopy)
            {
                Console.WriteLine(item);
                Console.WriteLine("Is this task done ?");
                string userInput = Console.ReadLine()?.ToLower();

                // if user input is yes or y -> add todoList with Id                
                if (userInput == "yes" || userInput == "y")
                {
                    todoList.CompleteItem(item.Id);
                    listYetTodo.Remove(item); // poistaa tehdyn tehtävän listalta YetTodo
                }
            }

            Console.WriteLine("\nDone tasks:");
            foreach (var item in listDone)
            {
                Console.WriteLine(item);
            }            

            // prints undone tasks
            Console.WriteLine("\nTasks yet to do:");
            foreach (var item in listYetTodo)
            {
                Console.WriteLine(item);
            }
        }
    }
}