using System.Collections.Generic;
using KanbanConsoleApp.Features.Clients;
using KanbanConsoleApp.Features.Tasks;

namespace KanbanConsoleApp
{
    public class TaskEngine
    {
        private readonly TaskRepository _taskRepository = new TaskRepository();
        private readonly ClientRepository _clientRepository = new ClientRepository();

        public void SaveTask(Task task)
        {
            _taskRepository.SaveTask(task);
        }

        public Task RetrieveTaskById(string id)
        {
            var allTasks = _taskRepository.GetTasks();
            foreach (var task in allTasks)
            {
                if (task.Id == id) {
                    return task;
                }
            }

            return null;
        }

        public void SaveClient(Client client)
        {
            _clientRepository.SaveClient(client);
        }

        public List<Client> GetClients()
        {
            var allClients = _clientRepository.GetClients();
            return allClients;
        }

        public void RemoveClientByName(string name)
        {
            _clientRepository.DeleteClientByName(name);
        }

        public List<Task> GetTasksForClient(string clientName)
        {
            return _taskRepository.GetTasksForClientName(clientName);
        }
    }
}