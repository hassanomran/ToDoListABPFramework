using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList.DTOS;
using ToDoList.Interface;
using ToDoList.Web.Pages;

namespace TodoApp.Web.Pages
{
    public class IndexModel : ToDoListPageModel
    {
        public List<TodoItemDto> TodoItems { get; set; }

        private readonly ITodoAppService _todoAppService;

        public IndexModel(ITodoAppService todoAppService)
        {
            _todoAppService = todoAppService;
        }

        public async Task OnGetAsync()
        {
            TodoItems = await _todoAppService.GetListAsync();
        }
    }
}
