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

    [BindProperty]
    public Todo NewTodo { get; set; }
    public List<Todo> todos = new();

    public IActionResult OnGet()
    {
        todos = TodoService.GetAllTodo();

        return Page();

    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        TodoService.AddNewTodo(NewTodo.title, NewTodo.description);
        TodoService.ModifyTodoStatus(NewTodo.Id);

        return RedirectToPage("./Index");
    }
}
