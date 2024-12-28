using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using ToDoList.Localization;

namespace ToDoList.Web;

[Dependency(ReplaceServices = true)]
public class ToDoListBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ToDoListResource> _localizer;

    public ToDoListBrandingProvider(IStringLocalizer<ToDoListResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
