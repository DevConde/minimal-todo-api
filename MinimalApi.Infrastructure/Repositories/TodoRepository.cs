using Microsoft.EntityFrameworkCore;
using MinimalApi.Core.Models;
using MinimalApi.Core.Repositories;

namespace MinimalApi.Infrastructure.Repositories
{
    public partial class TodoRepository : ITodoRepository
    {
        private readonly TodoDb _dbContext;
        public TodoRepository(TodoDb dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Todo> GetTodos()
        {
            return _dbContext.Todos.ToList();
        }


        public void CreateTodo(Todo todo)
        {
            _dbContext.Todos.Add(todo);
            _dbContext.SaveChanges();
        }
    }
}
