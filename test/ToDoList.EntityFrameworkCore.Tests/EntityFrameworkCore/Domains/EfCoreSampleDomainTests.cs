using ToDoList.Samples;
using Xunit;

namespace ToDoList.EntityFrameworkCore.Domains;

[Collection(ToDoListTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ToDoListEntityFrameworkCoreTestModule>
{

}
