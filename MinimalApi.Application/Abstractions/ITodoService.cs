using MinimalApi.Application.Requests;
using MinimalApi.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalApi.Application.Abstractions
{
    public interface ITodoService
    {
        void CreateTodo(CreateTodoRequest request);
        IEnumerable<GetTodoResponse> GetTodos();
    }
}
