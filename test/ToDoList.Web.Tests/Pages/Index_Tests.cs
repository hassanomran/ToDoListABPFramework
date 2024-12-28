using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ToDoList.Pages;

[Collection(ToDoListTestConsts.CollectionDefinitionName)]
public class Index_Tests : ToDoListWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
