using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using todolist.Services;
using todolist.Models;

namespace todolist.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public List<Todo> todos = new();

    public void OnGet()
    {
        todos = TodoService.GetTodos();
    }
}
