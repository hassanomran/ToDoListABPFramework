using ToDoList.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ToDoList.Web.Pages;

public abstract class ToDoListPageModel : AbpPageModel
{
    protected ToDoListPageModel()
    {
        LocalizationResourceType = typeof(ToDoListResource);
    }
}
