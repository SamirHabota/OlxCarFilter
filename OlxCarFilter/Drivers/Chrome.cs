using OlxCarFilter.Actions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OlxCarFilter.Drivers;

public static class Chrome
{
	public static IWebDriver Driver { get; private set; } = null!;

	public static void StartDriver(string url)
	{
		Driver = new ChromeDriver();
		Driver.Url = url;
		NavigationActions.MaximizeWindow(Driver);
	}
}
