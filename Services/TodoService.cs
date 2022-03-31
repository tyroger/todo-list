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
        new Todo{Id = 1, title ="se lever"},
        new Todo{Id = 2, title ="s'étirer"}
        };
    }

    //step 01 : list my Todos

    public static List<Todo>? GetTodos() => TodoList;

    // step 02 : change a todo state

    public static bool ChangeTodoState(Todo todo)
    {
        int index = TodoList.FindIndex(t => t.Id == todo.Id);
        todo = TodoList[index];
        todo.isTaskComplete = true;
        return todo.isTaskComplete;
    }



    // TODO : 
    // show detail of a todo
    public static void ShowTodoDetail() { }


    // TODO : 
    // Add a new todo
    public static void AddnewTodo(List<Todo> TodoList, string title)
    {
        int newId = TodoList.Count + 1;
        string newTitle = title;
        Todo newTodo = new Todo { Id = newId, title = newTitle };
        TodoList.Add(newTodo);
    }

}