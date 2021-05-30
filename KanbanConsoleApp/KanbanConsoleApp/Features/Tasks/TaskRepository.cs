using System.Collections.Generic;

namespace KanbanConsoleApp.Features.Tasks
{
    public class TaskRepository
    {
        private readonly List<Task> _tasks = new List<Task>();

        public void SaveTask(Task task)
        {
            _tasks.Add(task);
        }

        public List<Task> GetTasks()
        {
            var tasksToReturn = new List<Task>();

            foreach (var task in _tasks)
            {
                tasksToReturn.Add(new Task
                {
                    Id = task.Id,
                    Description = task.Description,
                    ClientName = task.ClientName
                });
            }

            return tasksToReturn;
        }

        public void SwapTasks(string taskOneID, string taskTwoID)
        {
            int indexOne = -1;
            int indexTwo = -1;

            for (var i = 1; i < _tasks.Count; ++i)
            {
                if (_tasks[i].Id == taskOneID)
                {
                    indexOne = i;
                }
                if (_tasks[i].Id == taskTwoID)
                {
                    indexTwo = i;
                }
            }


            Task temp = _tasks[indexOne];
            _tasks[indexOne] = _tasks[indexTwo];
            _tasks[indexTwo] = temp;
        }

        public List<Task> GetTasksForClientName(string name)
        {
            var tasksToReturn = new List<Task>();

            foreach (var task in _tasks)
            {
                if (task.ClientName == name)
                {
                    tasksToReturn.Add(new Task
                    {
                        Id = task.Id,
                        Description = task.Description,
                        ClientName = task.ClientName
                    });
                }
            }
            return tasksToReturn;
        }
    }
}
