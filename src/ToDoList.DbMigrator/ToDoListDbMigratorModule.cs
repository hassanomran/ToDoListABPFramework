using ToDoList.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ToDoList.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ToDoListEntityFrameworkCoreModule),
    typeof(ToDoListApplicationContractsModule)
)]
public class ToDoListDbMigratorModule : AbpModule
{
}
