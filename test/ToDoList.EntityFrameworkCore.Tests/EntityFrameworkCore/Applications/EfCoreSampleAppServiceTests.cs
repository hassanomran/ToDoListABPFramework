using ToDoList.Samples;
using Xunit;

namespace ToDoList.EntityFrameworkCore.Applications;

[Collection(ToDoListTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ToDoListEntityFrameworkCoreTestModule>
{

}
