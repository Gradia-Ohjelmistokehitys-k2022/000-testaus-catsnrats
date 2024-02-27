using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTodoListApp
{
    public class TodoList
    {
        private readonly List<TodoTask> _tasks; // lista Todo-"tehtäville"
        private readonly List<TodoTask> _doneTasks; // lista tehdyille tehtäville        
        private int _taskCounter = 0;
        public IEnumerable<TodoTask> All => _tasks;
        public IEnumerable<TodoTask> DoneTasks => _doneTasks;
        public IEnumerable<TodoTask> TodoItems => _tasks.Except(_doneTasks).ToList();     

        public TodoList() // konstruktori alustaa task-listat
        {
            _tasks = new List<TodoTask>(); 
            _doneTasks = new List<TodoTask>();            
        }
        public void AddItemToList(TodoTask item) // metodi tehtävän (task) lisäämiseen listaan
        {
            if (item == null) // mikäli "task" on null
            {
                throw new ArgumentNullException(nameof(item), "Task cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(item.TaskDescription)) // mikäli tehtäväkuvaus on tyhjä tai välilyönti
            {
                throw new ArgumentException("Task description cannot be empty or whitespace.");
            }

            _taskCounter++;
            _tasks.Add(item with { Id = _taskCounter});
        }
        public void RemoveItemFromList(TodoTask item) // metodi tehtävän poistoon ? onko tarpeellinen
        {
            if (_tasks.Contains(item))
            {
                _tasks.Remove(item);
                if (_taskCounter > 0) // tarkistaa ennen miinustamista, ettei vähennä nollasta
                    _taskCounter--;
            }
        }
        public void CompleteItem(int id)
        {         
            var item = _tasks.FirstOrDefault(x => x.Id == id); // kaivaa ensimmäisen TodoTaskin listalta _tasks (LINQ FirstOrDefault)

            // Tarkistaa onko 'item' olemassa ennen poistoa. Merkitsee tehtävän tehdyksi, poistaa ja siirtää tehdyt _doneTasks-listaan.
            if (item != null)
            {                
                var updatedItem = item with { IsCompleted = true };
                _tasks.Remove(item);                
                _doneTasks.Add(updatedItem);                
            }
            else
            {
                Console.WriteLine($"Task with Id {id} not found in the undone tasks list.");
            }
        }
    }
}