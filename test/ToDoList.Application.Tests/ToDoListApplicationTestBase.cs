using Volo.Abp.Modularity;

namespace ToDoList;

public abstract class ToDoListApplicationTestBase<TStartupModule> : ToDoListTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
