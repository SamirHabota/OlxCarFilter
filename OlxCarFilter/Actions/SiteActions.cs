using OlxCarFilter.Drivers;
using OlxCarFilter.Utils;
using OlxCarFilter.Variables.Behaviour;
using OlxCarFilter.Variables.Text;
using OlxCarFilter.Variables.XPaths;
using OpenQA.Selenium;

namespace OlxCarFilter.Actions;

public static class SiteActions
{
	public static void AcceptCockies() => Execute.ButtonCLick(Buttons.AcceptCoockies);
	public static void OpenDetailedSearch() => Execute.ButtonCLick(Links.DetailedSearch);

	public static void DefineAutomaticBehaviour()
	{
		DialogResult dialogResult = MessageBox.Show(Dialogs.AutomaticSearchBehaviorPrompt, Dialogs.AutomaticSearchTitle, MessageBoxButtons.YesNo);
		Automatic.Behaviour = dialogResult == DialogResult.Yes;
	}

	public static void DefineResultsNumber()
	{
		Wait.ForASecond();
		string? searchButtonText = Chrome.Driver.FindElement(By.XPath(Buttons.SearchButton)).Text;
		Automatic.NumberOfResults = int.Parse(searchButtonText.Split(' ')[1]);
	}

	public static void DisplayAutomaticSearchData()
	{
		MessageBox.Show(Dialogs.AutomaticSearchResultsPrompt + Automatic.NumberOfResults, Dialogs.AutomaticSearchResultsTitle, MessageBoxButtons.OK);
	}
}
