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
        public IEnumerable<TodoTask> Tasks => _tasks.AsReadOnly();

        private int _taskCounter = 0;
        public IEnumerable<TodoTask> All => TodoItems;
        public List<TodoTask> TodoItems => _tasks;

        public TodoList() // konstruktori alustaa task-listan
        {
            _tasks = new List<TodoTask>();           
        }
        public void AddItemToList(TodoTask item) // metodi tehtävän (task) lisäämiseen listaan
        {
            _taskCounter++;
            _tasks.Add(item with { Id = _taskCounter});
        }
        public void RemoveItemFromList(TodoTask item) // metodi tehtävän poistoon
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
            var item = _tasks.First(x => x.Id == id); // löytää ToDo-taskin Id:n perusteella ?

            if (item != null) // tarkistaa onko 'item' olemassa ennen poistoa
                RemoveItemFromList(item);
        }
    }
}