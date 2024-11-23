using TaskManagementAPI.Models;
using Task = TaskManagementAPI.Models.Task;
using TaskManagementAPI.Repositories;

namespace TaskManagementAPI.Services
{
    public class TaskService:ITaskService
    {
        private readonly ITaskRepository _repository;

        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Task>> GetAllTasksAsync()
        {
            return await _repository.GetAllTasksAsync();
        }

        public async Task<Task> GetTaskByIdAsync(int id)
        {
            return await _repository.GetTaskByIdAsync(id);
        }

        public async Task<Task> CreateTaskAsync(TaskDto taskDto)
        {
            var task = new Task
            {
                Title = taskDto.Title,
                Description = taskDto.Description,
                IsCompleted = false
            };
            await _repository.CreateTaskAsync(task);
            return task;
        }

        public async Task<Task> UpdateTaskAsync(int id, TaskDto taskDto)
        {
            var task = await _repository.GetTaskByIdAsync(id);
            if (task != null)
            {
                task.Title = taskDto.Title;
                task.Description = taskDto.Description;
                await _repository.UpdateTaskAsync(task);
            }
            return task;
        }

        public async Task<Task> DeleteTaskAsync(int id)
        {
            var task = await _repository.GetTaskByIdAsync(id);
            await _repository.DeleteTaskAsync(id);
            return task;
        }

    }
}
