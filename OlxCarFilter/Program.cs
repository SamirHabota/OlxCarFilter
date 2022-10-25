using OlxCarFilter.Actions;
using OlxCarFilter.Drivers;
using OlxCarFilter.Utils;
using OlxCarFilter.Variables.Behaviour;
using OlxCarFilter.Variables.Links;

namespace OlxCarFilter;

public static class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		Chrome.StartDriver(Urls.Olx);

		SiteActions.AcceptCockies();

		SiteActions.DefineAutomaticBehaviour();

		NavigationActions.GoToCars();

		SiteActions.OpenDetailedSearch();

		new FormActions(FilePaths.CarSpecifications).FillIn();

		if (Automatic.Behaviour)
		{
			SiteActions.DefineResultsNumber();
			FormActions.Search();
			Clipboard.SetText(Chrome.Driver.Url);
			SiteActions.DisplayAutomaticSearchData();
		}

		Wait.Forever();
	}
}
