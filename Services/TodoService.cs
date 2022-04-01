using todolist.Models;

namespace todolist.Services;
public static class TodoService
{
    static List<Todo>? TodoList { get; }

    // predefined data :
    static TodoService()
    {
        TodoList = new List<Todo>
        {
        new Todo{Id = 1, title ="se lever", isTaskComplete=true},
        new Todo{Id = 2, title ="s'étirer"},
        new Todo{Id = 3, title ="coder"}
        };
    }

    public static List<Todo>? GetAllTodo()
    {
        return TodoList;
    }


    public static Todo GetSpecificTodo(int Index)
    {
        List<Todo>? todos = GetAllTodo();

        foreach (Todo todo in todos)
            if (todo.Id == Index)
            {
                return todo;
            }
        return null;
    }


    public static Todo ModifyTodoStatus(int Index)
    {
        Todo TodoToBeModified = GetSpecificTodo(Index);

        TodoToBeModified.isTaskComplete = !TodoToBeModified.isTaskComplete;

        return TodoToBeModified;
    }


    public static void AddNewTodo(string title, string description)
    {
        int newTtemNumber = TodoList.Count + 1;
        string newtitle = title;
        string newDescription = description;
        Todo todoToBeAdded = new Todo { Id = newTtemNumber, title = newtitle, description = newDescription };
        TodoList.Add(todoToBeAdded);
    }

}