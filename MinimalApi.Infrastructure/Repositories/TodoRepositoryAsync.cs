using Microsoft.EntityFrameworkCore;
using MinimalApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalApi.Infrastructure.Repositories
{
    public partial class TodoRepository
    {
        public async Task InsertTodoAsync(Todo todo)
        {
            _dbContext.Todos.Add(todo);
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);
        }


        public async Task<IEnumerable<Todo>> GetTodosAsync()
        {
            return await _dbContext.Todos.ToListAsync().ConfigureAwait(false);
        }
    }
}
