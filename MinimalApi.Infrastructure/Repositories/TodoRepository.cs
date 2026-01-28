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

        public IEnumerable<Todo> FindByCriteria(Func<Todo, bool> criteria)
        {
            return _dbContext.Todos.Where(criteria);
        }

        public IEnumerable<Todo> GetTodos()
        {
            return _dbContext.Todos;
        }


        public void CreateTodo(Todo todo)
        {
            _dbContext.Todos.Add(todo);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var todo = _dbContext.Todos.Find(id);
            if (todo != null)
            {
                _dbContext.Todos.Remove(todo);
                _dbContext.SaveChanges();
            }
        }
    }
}
