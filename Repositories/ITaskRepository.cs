
using Task = TaskManagementAPI.Models.Task;
namespace TaskManagementAPI.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<Task>> GetAllTasksAsync();
        Task<Task> GetTaskByIdAsync(int id);
        Task<Task> CreateTaskAsync(Task task);
        Task<Task> UpdateTaskAsync(Task task);
        Task<Task> DeleteTaskAsync(int id);
    }
}
