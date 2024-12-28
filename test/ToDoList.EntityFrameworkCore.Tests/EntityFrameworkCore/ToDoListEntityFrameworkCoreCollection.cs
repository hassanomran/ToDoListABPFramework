using Xunit;

namespace ToDoList.EntityFrameworkCore;

[CollectionDefinition(ToDoListTestConsts.CollectionDefinitionName)]
public class ToDoListEntityFrameworkCoreCollection : ICollectionFixture<ToDoListEntityFrameworkCoreFixture>
{

}
