using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using todolist.Services;
using todolist.Models;

namespace todolist.Pages
{
    public class DetailModel : PageModel
    {
        public Todo requestedTodo { get; set; }

        public void OnGet()
        {
            Todo requestedTodo = TodoService.GetSpecificTodo(1);
        }
    }
}
