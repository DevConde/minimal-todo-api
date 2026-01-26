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
        //private readonly ITodoService _todoService;

        //public TodosModule(ITodoService todoService)
        //{
        //    _todoService = todoService;
        //}

        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/todoitems", async (ITodoService service) => await Task.FromResult(service.GetTodos()));
    

            //        app.MapGet("/todoitems/complete", async (TodoDb db) =>
            //            await db.Todos.Where(t => t.IsComplete).ToListAsync());

            //        app.MapGet("/todoitems/{id}", async (int id, TodoDb db) =>
            //            await db.Todos.FindAsync(id)
            //                is Todo todo
            //                    ? Results.Ok(todo)
            //                    : Results.NotFound());

            app.MapPost("/todoitems", (ITodoService service, CreateTodoRequest request) =>
            {
                service.CreateTodo(request);

                return Results.Ok();
            });

            //app.MapPut("/todoitems/{id}", async (int id, Todo inputTodo, TodoDb db) =>
            //{
            //    var todo = await db.Todos.FindAsync(id);

            //    if (todo is null) return Results.NotFound();

            //    todo.Title = inputTodo.Title;
            //    todo.IsComplete = inputTodo.IsComplete;

            //    await db.SaveChangesAsync();

            //    return Results.NoContent();
            //});

            //app.MapDelete("/todoitems/{id}", async (int id, TodoDb db) =>
            //{
            //    if (await db.Todos.FindAsync(id) is Todo todo)
            //    {
            //        db.Todos.Remove(todo);
            //        await db.SaveChangesAsync();
            //        return Results.NoContent();
            //    }

            //    return Results.NotFound();
            //});
        }
    }
}
