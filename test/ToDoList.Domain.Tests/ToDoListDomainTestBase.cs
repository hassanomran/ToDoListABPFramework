using Volo.Abp.Modularity;

namespace ToDoList;

/* Inherit from this class for your domain layer tests. */
public abstract class ToDoListDomainTestBase<TStartupModule> : ToDoListTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
