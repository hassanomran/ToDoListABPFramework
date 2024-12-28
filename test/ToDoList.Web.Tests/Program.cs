using Microsoft.AspNetCore.Builder;
using ToDoList;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("ToDoList.Web.csproj"); 
await builder.RunAbpModuleAsync<ToDoListWebTestModule>(applicationName: "ToDoList.Web");

public partial class Program
{
}
