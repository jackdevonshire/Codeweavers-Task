using System.Collections.Generic;
using KanbanConsoleApp.Features.Clients;
using KanbanConsoleApp.Features.Tasks;

namespace KanbanConsoleApp
{
    public class TaskEngine
    {
        private readonly TaskRepository _taskRepository = new TaskRepository();


        public void SaveTask(Task task)
        {
            _taskRepository.SaveTask(task);
        }

        public Task RetrieveTaskById(string id)
        {
            var allTasks = _taskRepository.GetTasks();
            foreach (var task in allTasks)
            {
                return task;
            }

            return null;
        }

        public void SaveClient(Client client)
        {
        }

        public List<Client> GetClients()
        {
            return new List<Client>();
        }

        public void RemoveClientByName(string name)
        {
        }

        public List<Task> GetTasksForClient(string clientName)
        {
            return new List<Task>();
        }
    }
}