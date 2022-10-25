// ReSharper disable UnusedMember.Local

using System.Globalization;
using System.Reflection;
using OlxCarFilter.Drivers;
using OlxCarFilter.Models;
using OlxCarFilter.Utils;
using OlxCarFilter.Variables.Behaviour;
using OlxCarFilter.Variables.XPaths;
using OpenQA.Selenium;

namespace OlxCarFilter.Actions;

public class FormActions
{
	private readonly CarSpecifications _carSpecifications;

	public FormActions(string jsonFilePath)
	{
		_carSpecifications = FileReader<CarSpecifications>.GetSpecifications(jsonFilePath);
	}

	public void FillIn()
	{
		GetType()
		   .GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
		   .Where(m => m.Name.StartsWith("Select") || m.Name.StartsWith("Input") && m.ReturnType == typeof(void))
		   .ToList()
		   .ForEach(x => x.Invoke(this, null));
	}

	private void SelectCarState()
	{
		Chrome.Driver.FindElement(By.XPath(RadioButtons.CarStates.Single(x => x.Enum == _carSpecifications.CarState).Value)).Click();
	}

	private void SelectCarType()
	{
		Execute.SelectList(SelectLists.CarBrand, (int) _carSpecifications.CarBrand);
	}

	private void InputPriceRange()
	{
		Execute.Textbox(Textboxes.PriceFrom, _carSpecifications.PriceFrom.ToString(CultureInfo.CurrentCulture));
		Execute.Textbox(Textboxes.PriceTo, _carSpecifications.PriceTo.ToString(CultureInfo.CurrentCulture));
	}

	private void SelectLocation()
	{
		Execute.SelectList(SelectLists.Location, (int) _carSpecifications.Location);
	}

	private void InputYearRange()
	{
		Execute.Textbox(Textboxes.YearFrom, _carSpecifications.YearFrom.ToString(CultureInfo.CurrentCulture));
		Execute.Textbox(Textboxes.YearTo, _carSpecifications.YearTo.ToString(CultureInfo.CurrentCulture));
	}

	private void InputMileageRange()
	{
		Execute.SelectList(SelectLists.MileageFrom, (int) _carSpecifications.MileageFrom);
		Execute.SelectList(SelectLists.MileageTo, (int) _carSpecifications.MileageTo);
	}

	private void SelectFuelType()
	{
		Execute.Checkboxes(_carSpecifications.Fuels, Checkboxes.Fuels);
	}

	private void InputHorsePowerRange()
	{
		Execute.Textbox(Textboxes.HorsePowerFrom, _carSpecifications.HorsePowerFrom.ToString(CultureInfo.CurrentCulture));
		Execute.Textbox(Textboxes.HorsePowerTo, _carSpecifications.HorsePowerTo.ToString(CultureInfo.CurrentCulture));
	}

	private void InputKilowattRange()
	{
		Execute.Textbox(Textboxes.KilowattFrom, _carSpecifications.KilowattFrom.ToString(CultureInfo.CurrentCulture));
		Execute.Textbox(Textboxes.KilowattTo, _carSpecifications.KilowattTo.ToString(CultureInfo.CurrentCulture));
	}

	private void InputKubikageRange()
	{
		Execute.SelectList(SelectLists.KubikageFrom, (int) _carSpecifications.KubikageFrom);
		Execute.SelectList(SelectLists.KubikageTo, (int) _carSpecifications.KubikageTo);
	}

	private void SelectMotorDriveMethod()
	{
		Execute.Checkboxes(_carSpecifications.MotorDriveMethods, Checkboxes.MotorDriveMethods);
	}

	private void SelectTransmissions()
	{
		Execute.Checkboxes(_carSpecifications.Transmissions, Checkboxes.Transmissions);
	}

	private void SelectAmountOfDoors()
	{
		Execute.Checkboxes(_carSpecifications.AmountOfDoors, Checkboxes.AmountOfCarDoors);
	}

	private void SelectSensors()
	{
		Execute.Checkboxes(_carSpecifications.Sensors, Checkboxes.CarSensors);
	}

	private void SelectCarTypes()
	{
		Execute.Checkboxes(_carSpecifications.CarTypes, Checkboxes.CarTypes);
	}

	private void SelectCarColors()
	{
		Execute.Checkboxes(_carSpecifications.CarColors, Checkboxes.CarColors);
	}

	private void SelectCarGears()
	{
		Execute.Checkboxes(_carSpecifications.CarGears, Checkboxes.CarGears);
	}

	private void SelectRimSizes()
	{
		Execute.Checkboxes(_carSpecifications.RimSizes, Checkboxes.RimSizes);
	}

	private void SelectSoundSystems()
	{
		Execute.Checkboxes(_carSpecifications.SoundSystems, Checkboxes.SoundSystems);
	}

	private void SelectSecurityBlockades()
	{
		Execute.Checkboxes(_carSpecifications.SecurityBlockades, Checkboxes.SecurityBlockades);
	}

	public static void Search()
	{
		Execute.ButtonCLick(Buttons.SearchButton);
	}
}
