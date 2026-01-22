namespace MinimalApi.Application.Inputs
{
    public class CreateTodoInput
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
