using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleBrowserContext;

[Ignore]
[TestClass]
public class SampleBrowserContext : PageTest
{
    [TestMethod]
    public async Task TestWithCustomContextOptions()
    {
        // The following Page (and BrowserContext) instance has the custom colorScheme, viewport and baseURL set:
        await Page.GotoAsync("/login");
    }


    /* 
    Below method will setup browser with 

    */

    public override BrowserNewContextOptions ContextOptions()
    {
        return new BrowserNewContextOptions()
        {
            ColorScheme = ColorScheme.Dark,
            ViewportSize = new()
            {
                Width = 412,
                Height = 915
            },
            BaseURL = "https://github.com",
        };
    }
}
