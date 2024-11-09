using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;

namespace SampleAdvanceFeature;


[TestClass]
public class ExampleTest : PageTest
{


    [TestMethod]
    public async Task HasTitle()
    {
        await Page.GotoAsync("https://playwright.dev");
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
       // await Page.RouteAsync("wss://example.com/ws",);

    }

    
}
