using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTodoListApp
{
    public class TodoList
    {
        private readonly List<TodoTask> _tasks;
        private int _taskCounter = 0;
        public IEnumerable<TodoTask> All => _TodoItems;
        public List<TodoTask> _TodoItems => _tasks;

        public TodoList()
        {
            _tasks = new List<TodoTask>();           
        }
        public void AddItemToList(TodoTask item)
        {
            _taskCounter++;
            _tasks.Add(item with { Id = _taskCounter});
        }

        public void RemoveItemFromList(TodoTask item)
        {
            if (_tasks.Contains(item))
            {
                _tasks.Remove(item); _taskCounter--;
            }
        }

        public void CompleteItem(int id)
        {
            // remove the item
            var item = _tasks.First(x => x.Id == id);
            RemoveItemFromList(item);
        }
    }
}