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
        public IEnumerable<TodoTask> All => _TodoItems; //https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.all?view=net-6.0
        public List<TodoTask> _TodoItems { get => _tasks; }

        /// <summary>
        /// Each time new todolist is created. New list of tasks is created.
        /// </summary>
        public TodoList()
        {
            _tasks = new List<TodoTask>();
            //string defaultTask = $"Task number {_taskCounter}"; // remove
            //TodoTask item = new(defaultTask);
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
                _tasks.Remove(item with { Id = _taskCounter-- });

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
