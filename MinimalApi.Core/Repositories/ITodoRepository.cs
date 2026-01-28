using MinimalApi.Core.Models;

namespace MinimalApi.Core.Repositories
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> FindByCriteria(Func<Todo, bool> criteria);
        void Delete(int id);

        IEnumerable<Todo> GetTodos();
        Task<IEnumerable<Todo>> GetTodosAsync();

        public void CreateTodo(Todo todo);
        Task CreateTodoAsync(Todo todo);
    }
}
