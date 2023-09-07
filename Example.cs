using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [Test]
    public async Task MyTest()


    {
        await using var browser = await Playwright.Chromium.LaunchAsync();
        await using var context = await browser.NewContextAsync();


        

        await Page.GotoAsync("https://demo.playwright.dev/todomvc/#/");

        await Page.GetByPlaceholder("What needs to be done?").ClickAsync();

        await Page.GetByPlaceholder("What needs to be done?").FillAsync("open vs code");

        await Page.GetByPlaceholder("What needs to be done?").PressAsync("Enter");

        await Page.GetByPlaceholder("What needs to be done?").FillAsync("start new test");

        await Page.GetByPlaceholder("What needs to be done?").PressAsync("Enter");

        await Page.GetByPlaceholder("What needs to be done?").FillAsync("add new test");

        await Page.GetByPlaceholder("What needs to be done?").PressAsync("Enter");

        await Page.GetByPlaceholder("What needs to be done?").FillAsync("use codeGen");

        await Page.GetByPlaceholder("What needs to be done?").PressAsync("Enter");

        await Page.Locator("li").Filter(new() { HasText = "use codeGen" }).GetByLabel("Toggle Todo").CheckAsync();

        await Page.Locator("li").Filter(new() { HasText = "add new test" }).GetByLabel("Toggle Todo").CheckAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Completed" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Clear completed" }).ClickAsync();

        
    }
}
