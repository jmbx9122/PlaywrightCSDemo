using Microsoft.Playwright.MSTest;
using Microsoft.Playwright;

[TestClass]
public class Tests : PageTest
{
    [TestMethod]
    public async Task MyTest()
    {
        await Page.GotoAsync("https://demo.playwright.dev/todomvc/#/active");


        await Page.GetByPlaceholder("What needs to be done?").FillAsync("Task 01");

        await Page.GetByPlaceholder("What needs to be done?").PressAsync("Enter");

        await Page.GetByPlaceholder("What needs to be done?").FillAsync("Task 02");

        await Page.GetByPlaceholder("What needs to be done?").PressAsync("Enter");

        await Page.GetByRole(AriaRole.Button, new () { Name = "Delete" }).ClickAsync();

    }
}
