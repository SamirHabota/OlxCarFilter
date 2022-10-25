using OlxCarFilter.Enumerations;
using OlxCarFilter.Models;

namespace OlxCarFilter.Variables.XPaths;

public static class RadioButtons
{
	public static List<EnumValue<CarState>> CarStates = new()
	{
		new() {Enum = CarState.New, Value = "//*[@id='nova']"},
		new() {Enum = CarState.NewAndUsed, Value = "//*[@id='novoipolovno']"},
		new() {Enum = CarState.Used, Value = "//*[@id='polovna']"},

	};
}
