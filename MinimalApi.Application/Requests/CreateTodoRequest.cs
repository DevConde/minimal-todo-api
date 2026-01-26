namespace MinimalApi.Application.Requests
{
    public class CreateTodoRequest
    {
        public string? Title { get; set; }
        public bool IsComplete { get; set; }
    }
}
