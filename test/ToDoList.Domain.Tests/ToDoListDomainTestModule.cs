using Volo.Abp.Modularity;

namespace ToDoList;

[DependsOn(
    typeof(ToDoListDomainModule),
    typeof(ToDoListTestBaseModule)
)]
public class ToDoListDomainTestModule : AbpModule
{

}
