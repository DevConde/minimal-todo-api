using MinimalApi.Core.Models;

namespace MinimalApi.Core.Repositories
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> GetTodos();
        Task<IEnumerable<Todo>> GetTodosAsync();

        public void InsertTodo(Todo todo);
        Task InsertTodoAsync(Todo todo);
    }
}
