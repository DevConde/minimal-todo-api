using Mapster;
using MinimalApi.Application.Abstractions;
using MinimalApi.Application.Requests;
using MinimalApi.Application.Responses;
using MinimalApi.Core.Models;
using MinimalApi.Core.Repositories;

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

        public void DeleteTodo(int id)
        {
            _repository.Delete(id);
        }

        #region Read
        public IEnumerable<GetTodoResponse> GetTodos()
        {
            var todos = _repository.GetTodos().ToList();
            return todos.Adapt<IEnumerable<GetTodoResponse>>();
        }

        public IEnumerable<GetTodoResponse> GetCompletedTodos()
        {
            var todos = _repository.FindByCriteria(e => e.IsComplete);
            return todos.Adapt<IEnumerable<GetTodoResponse>>();
        }

        public IEnumerable<GetTodoResponse> GetTodosById(int id)
        {
            var todos = _repository.FindByCriteria(e => e.Id == id);
            return todos.Adapt<IEnumerable<GetTodoResponse>>();
        }
        #endregion
        // Read
        // Update
        // Delete
    }
}
