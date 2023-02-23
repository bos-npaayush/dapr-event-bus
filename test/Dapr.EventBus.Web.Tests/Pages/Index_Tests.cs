using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Dapr.EventBus.Pages;

public class Index_Tests : EventBusWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
