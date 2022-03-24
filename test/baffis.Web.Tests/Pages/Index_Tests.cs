using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace baffis.Pages;

public class Index_Tests : baffisWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
