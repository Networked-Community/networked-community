using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Nc.Pages
{
    public class Index_Tests : NcWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
