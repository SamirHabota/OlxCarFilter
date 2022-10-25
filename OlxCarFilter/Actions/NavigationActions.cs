using OlxCarFilter.Drivers;
using OpenQA.Selenium;

namespace OlxCarFilter.Actions;

public static class NavigationActions
{
	public static void MaximizeWindow(IWebDriver driver) => driver.Manage().Window.Maximize();
	
	public static void GoToCars() => Chrome.Driver.FindElement(By.XPath(Variables.XPaths.NavigationButtons.Cars)).Click();
}
