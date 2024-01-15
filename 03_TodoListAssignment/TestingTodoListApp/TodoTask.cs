using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestingTodoListApp
{
    public record TodoTask(string TaskDescription) // ota selvää recordin toiminnasta
    {
        
        public int Id { get; init; } //init makes property immutable which means you cannot change value with set afterwards.
        public bool IsCompleted { get; init; }

       
        public override string ToString()
        {
            return $"Id: {Id} + Task: {TaskDescription} + Did you do it?: {IsCompleted}";
        }
    }

}





