using todolist.Models;

namespace todolist.Services;
public static class TodoService
{
    static List<Todo>? TodoTasks { get; }

    // predefine data :
    static TodoService()
    {
        TodoTasks = new List<Todo>
        {
        new Todo{Id = 1, title ="se lever", isTaskComplete = false},
        new Todo{Id = 2, title ="se laver", isTaskComplete = false}
        };
    }

    //step 01 : list my Todos

    public static List<Todo>? GetTodos() => TodoTasks;
}