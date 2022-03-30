using System.ComponentModel.DataAnnotations;

namespace todolist.Models;

public class Todo
{
    public int Id { get; set; }

    [Required]
    public string? title { get; set; }
    public bool isTaskComplete { get; set; }
}