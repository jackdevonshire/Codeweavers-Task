using KanbanConsoleApp.Features.Tasks;
using KanbanConsoleApp.Features.Clients;

namespace KanbanConsoleApp.Tests
{
    public static class _1
    {
        public static void AbilityToGetATaskById_ThenTheCorrectTaskIsRetrieved()
        {
            var engine = new TaskEngine();
            engine.SaveClient(new Client { Name = "BMW" });
            engine.SaveTask(new Task { Description = "Ability to login to the order system.", Id = "1", ClientName = "BMW" });
            engine.SaveTask(new Task { Description = "Ability to logout of the order system.", Id = "2", ClientName = "BMW" });

            var result = engine.RetrieveTaskById("2");
            Assert.AreEqual(result.Description, "Ability to logout of the order system.");
        }
    }
}