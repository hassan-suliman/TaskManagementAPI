using TaskManagementAPI.Models;
using Task = TaskManagementAPI.Models.Task;

namespace TaskManagementAPI.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<Task>> GetAllTasksAsync();
        Task<Task> GetTaskByIdAsync(int id);
        Task<Task> CreateTaskAsync(TaskDto taskDto);
        Task<Task> UpdateTaskAsync(int id, TaskDto taskDto);
        Task<Task> DeleteTaskAsync(int id);
    }
}
