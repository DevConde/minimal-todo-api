using Mapster;
using MinimalApi.Application.Abstractions;
using MinimalApi.Application.Requests;
using MinimalApi.Application.Responses;
using MinimalApi.Core.Models;
using MinimalApi.Core.Repositories;
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

        public void CreateTodo(CreateTodoRequest request)
        {
            _repository.CreateTodo(request.Adapt<Todo>());
        }

        public IEnumerable<GetTodoResponse> GetTodos()
        {
            var todos = _repository.GetTodos().ToList();
            return todos.Adapt<IEnumerable<GetTodoResponse>>();
        }
        // Read
        // Update
        // Delete
    }
}
