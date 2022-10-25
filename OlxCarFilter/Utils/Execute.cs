using OlxCarFilter.Drivers;
using OlxCarFilter.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OlxCarFilter.Utils;

public static class Execute
{
	public static void ButtonCLick(string xPath)
	{
		Chrome.Driver.FindElement(By.XPath(xPath)).Click();
	}
	public static void Checkboxes<TEnum>(List<TEnum> enumerationList, List<EnumValue<TEnum>> enumValueListXPaths)
	{
		foreach (TEnum item in enumerationList) Chrome.Driver.FindElement(By.XPath(enumValueListXPaths.Single(x => Equals(x.Enum, item)).Value))?.Click();
	}

	public static void SelectList(string xPath, int index)
	{
		new SelectElement(Chrome.Driver.FindElement(By.XPath(xPath)))?.SelectByIndex(index);
	}

	public static void Textbox(string xPath, string text)
	{
		Chrome.Driver.FindElement(By.XPath(xPath))?.SendKeys(text);
	}
}
