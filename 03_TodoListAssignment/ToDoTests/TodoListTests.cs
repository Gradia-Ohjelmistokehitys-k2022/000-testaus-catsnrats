namespace TodoListTests
{
    [TestClass]
    public class TodoListTests
    {
        /* ### AddItemToList -metodin testit ### */
        [TestMethod]
        public void AddItemToList_ShouldIncreaseTaskCount()
        {
            // arrange
            TodoList todoList = new();

            // act
            todoList.AddItemToList(new TodoTask("Test task 1"));

            // assert
            Assert.AreEqual(1, todoList.All.Count());
        }

        [TestMethod]
        public void AddItemToList_ShouldAssignUniqueIds()
        {
            // arrange
            TodoList todoList = new();

            // act
            todoList.AddItemToList(new TodoTask("Test task 1"));
            todoList.AddItemToList(new TodoTask("Test task 2"));

            // assert
            var tasks = todoList.All.ToList();
            Assert.AreEqual(2, tasks.Count);
            Assert.AreNotEqual(0, tasks[1].Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddItemToList_ShouldThrowArgumentNullException_WhenTaskIsNull()
        {
            // arrange
            TodoList todoList = new();

            // act
            todoList.AddItemToList(null);

            // assert
            // except exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddItemToList_ShouldThrowArgumentException_WhenTaskDescriptionIsEmpty()
        {
            // arrange
            TodoList todoList = new();

            // act
            todoList.AddItemToList(new TodoTask(string.Empty));

            // assert
            // except argument exception
        }
        [TestMethod]
        public void AddLargeNumberOfItems_ShouldNotExceedMemoryLimits()
        {
            // arrange
            TodoList todoList = new();

            // act
            for (int i = 0; i < 1000000; i++) // lisää listaan miljoona tehtävää
            {
                todoList.AddItemToList(new TodoTask($"Task {i + 1}"));
            }

            // assert
            Assert.AreEqual(1000000, todoList.All.Count());
        }

        /* ### RemoveItemFromList -metodin testit ### */

        [TestMethod]
        public void RemoveItemFromList_ShouldRemoveExistingItem()
        {
            // arrange
            TodoList todoList = new();
            TodoTask task = new("Test task");
            todoList.AddItemToList(task);

            // act
            todoList.RemoveItemFromList(task);

            // arrange
            CollectionAssert.DoesNotContain(todoList.All.ToList(), task);
        }

        [TestMethod]
        public void RemoveItemFromList_ShouldNotAffectListForNonExistingItem() // poista olematon 'item' listalta
        {
            // arrange
            TodoList todoList = new();
            TodoTask task = new("Test task");

            // act
            todoList.RemoveItemFromList(task);

            // assert
            CollectionAssert.DoesNotContain(todoList.All.ToList().ToList(), task);
        }

        [TestMethod]
        public void RemoveItemFromList_ShouldAdjustTaskCounter()
        {
            // arrange
            TodoList todoList = new();
            TodoTask task1 = new("Test task 1");
            TodoTask task2 = new("Test task 2");
            todoList.AddItemToList(task1);
            todoList.AddItemToList(task2);

            // act
            todoList.RemoveItemFromList(task1);

            // assert
            CollectionAssert.DoesNotContain(todoList.All.ToList(), task1);
        }

        [TestMethod]
        public void RemoveItemFromList_ShouldRemoveItemWithSpecificID()
        {
            // arrange
            TodoList todoList = new();
            TodoTask task1 = new("Test task 1");
            TodoTask task2 = new("Test task 2");            
            todoList.AddItemToList(task1);
            todoList.AddItemToList(task2);

            // noutaa taskit listalta päivittyneen Id:n kera
            TodoTask addedTask1 = todoList.All.First(t => t.TaskDescription == "Test task 1");
            TodoTask addedTask2 = todoList.All.First(t => t.TaskDescription == "Test task 2");

            // act
            todoList.RemoveItemFromList(addedTask1); // ID 1 tehtävän poisto

            // assert
            CollectionAssert.DoesNotContain(todoList.All.ToList(), addedTask1); // varmistaa, että task1 (ID 1) on poistettu

            // varmistaa, että task2 on listalla
            CollectionAssert.Contains(todoList.All.ToList(), addedTask2);            
        }

        /* ### CompleteItem -metodin testit ### */

        [TestMethod]
        public void CompleteItem_ShouldNotCompleteTask_WhenIdExistsInUndoneTasks()
        {
            // arrange
            TodoList todoList = new();
            TodoTask task1 = new("Test task 1");
            todoList.AddItemToList(task1);

            // task1 id pysyy oletusarvossa, vain todoList sisällä "Test task 1" saa uuden id:n
            TodoTask addedTask = todoList.All.FirstOrDefault();

            // act
            todoList.CompleteItem(addedTask.Id + 1);

            // assert
            Assert.IsFalse(todoList.DoneTasks.Contains(addedTask));
            Assert.IsTrue(todoList.TodoItems.Contains(addedTask));
        }

        [TestMethod]
        public void CompleteItem_ShouldMoveTaskToDoneTasks_WhenCompleted()
        {
            // arrange
            TodoList todoList = new();
            TodoTask task1 = new TodoTask("Test task 1");
            todoList.AddItemToList(task1);

            // `task1` does not get its Id updated -> retrieve it back from the todoList
            TodoTask addedTask = todoList.All.FirstOrDefault();

            // act            
            todoList.CompleteItem(addedTask.Id);            

            // assert        
            var completedTask = todoList.DoneTasks.FirstOrDefault(t => t.Id == addedTask.Id);
            Assert.IsNotNull(completedTask, "Task should be in done tasks.");
            Assert.IsTrue(completedTask.IsCompleted, "Task should be marked as completed.");
        }

        [TestMethod]
        public void CompleteItem_ShouldNotCompleteTask_WhenIdDoesNotExistInUndoneTasksList()
        {
            // Arrange
            TodoList todoList = new();
            TodoTask task1 = new TodoTask("Test task 1");
            todoList.AddItemToList(task1);

            // Act
            todoList.CompleteItem(task1.Id + 1); // Using a different ID

            // Assert
            Assert.IsFalse(todoList.DoneTasks.Contains(task1));
            //Assert.IsTrue(todoList.TodoItems.Contains(task1));
        }

    }
}