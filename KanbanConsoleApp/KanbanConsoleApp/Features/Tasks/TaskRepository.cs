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
