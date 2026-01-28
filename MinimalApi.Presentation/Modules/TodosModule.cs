using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using MinimalApi.Application.Abstractions;
using MinimalApi.Application.Requests;

namespace MinimalApi.Presentation.Modules
{
    public class TodosModule : CarterModule
    {
        public TodosModule() : base("/todoitems")
        { }

        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/", (ITodoService service) => service.GetTodos());

            app.MapGet("/todoitems/complete", (ITodoService service) => service.GetCompletedTodos());

            app.MapGet("/todoitems/{id}", (int id, ITodoService service) => service.GetTodosById(id));

            app.MapPost("/todoitems", (ITodoService service, CreateTodoRequest request) => service.CreateTodo(request));

            app.MapDelete("/todoitems/{id}", (int id, ITodoService service) => service.DeleteTodo(id));
        }
    }
}
