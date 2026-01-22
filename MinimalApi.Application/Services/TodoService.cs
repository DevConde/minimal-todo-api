using MinimalApi.Core.Repositories;
using MinimalApi.Core.Services;
using MinimalApi.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalApi.Application.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _repository;
        public TodoService(ITodoRepository repository)
        {
            _repository = repository;
        }

        public void CreateTodo()
        {
            // Map from 'request' to 'domain'
            _repository
        }
        // Create
        // Read
        // Update
        // Delete
    }
}
