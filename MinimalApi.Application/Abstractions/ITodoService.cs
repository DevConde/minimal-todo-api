using MinimalApi.Application.Requests;
using MinimalApi.Application.Responses;

namespace MinimalApi.Application.Abstractions
{
    public interface ITodoService
    {
        void CreateTodo(CreateTodoRequest request);
        void DeleteTodo(int id);
        IEnumerable<GetTodoResponse> GetTodos();
        IEnumerable<GetTodoResponse> GetCompletedTodos();
        IEnumerable<GetTodoResponse> GetTodosById(int id);

    }
}
