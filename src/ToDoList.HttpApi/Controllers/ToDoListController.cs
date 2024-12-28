using ToDoList.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ToDoList.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ToDoListController : AbpControllerBase
{
    protected ToDoListController()
    {
        LocalizationResource = typeof(ToDoListResource);
    }
}
