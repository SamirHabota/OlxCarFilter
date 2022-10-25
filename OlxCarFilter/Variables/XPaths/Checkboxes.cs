using OlxCarFilter.Enumerations;
using OlxCarFilter.Models;
// ReSharper disable StringLiteralTypo

namespace OlxCarFilter.Variables.XPaths;

public static class Checkboxes
{
	public static readonly List<EnumValue<Fuel>> Fuels = new()
	{
		new() {Enum = Fuel.Diesel, Value = "//*[@id='dizel']"},
		new() {Enum = Fuel.Gasoline, Value = "//*[@id='benzin']"},
		new() {Enum = Fuel.Gas, Value = "//*[@id='plin']"},
		new() {Enum = Fuel.Hybrid, Value = "//*[@id='hibrid']"},
		new() {Enum = Fuel.Electric, Value = "//*[@id='elektro']"},
	};

	public static readonly List<EnumValue<MotorDriveMethod>> MotorDriveMethods = new()
	{
		new() {Enum = MotorDriveMethod.FrontWheelDrive, Value = "//*[@id='pogon_select_prednji']"},
		new() {Enum = MotorDriveMethod.RearWheelDrive, Value = "//*[@id='pogon_select_zadnji']"},
		new() {Enum = MotorDriveMethod.FourWheelDrive, Value = "//*[@id='pogon_select_sva-cetiri']"},
	};

	public static readonly List<EnumValue<Transmission>> Transmissions = new()
	{
		new() {Enum = Transmission.Automatic, Value = "//*[@id='transmisija_select_automatik']"},
		new() {Enum = Transmission.Manual, Value = "//*[@id='transmisija_select_manuelni']"},
		new() {Enum = Transmission.SemiAutomatic, Value = "//*[@id='transmisija_select_polu-automatik']"},
	};

	public static readonly List<EnumValue<AmountOfDoors>> AmountOfCarDoors = new()
	{
		new() {Enum = AmountOfDoors.Two, Value = "//*[@id='broj-vrata_select_2-3']"},
		new() {Enum = AmountOfDoors.Four, Value = "//*[@id='broj-vrata_select_4-5']"},
	};

	public static readonly List<EnumValue<Sensors>> CarSensors = new()
	{
		new() {Enum = Sensors.None, Value = "//*[@id='parking-senzori_select_nema']"},
		new() {Enum = Sensors.FrontSensors, Value = "//*[@id='parking-senzori_select_naprijed']"},
		new() {Enum = Sensors.BackSensors, Value = "//*[@id='parking-senzori_select_nazad']"},
		new() {Enum = Sensors.FrontAndBackSensors, Value = "//*[@id='parking-senzori_select_naprijed-nazad']"},
	};

	public static readonly List<EnumValue<CarType>> CarTypes = new()
	{
		new() {Enum = CarType.Limousine, Value = "//*[@id='tip_select_limuzina']"},
		new() {Enum = CarType.SmallCar, Value = "//*[@id='tip_select_malo-auto']"},
		new() {Enum = CarType.Caravan, Value = "//*[@id='tip_select_karavan']"},
		new() {Enum = CarType.Van, Value = "//*[@id='tip_select_kombi']"},
		new() {Enum = CarType.Suv, Value = "//*[@id='tip_select_terenac']"},
		new() {Enum = CarType.Cabriolet, Value = "//*[@id='tip_select_kabriolet']"},
		new() {Enum = CarType.Coupe, Value = "//*[@id='tip_select_sportski-kupe']"},
		new() {Enum = CarType.OffRoad, Value = "//*[@id='tip_select_off-road']"},
		new() {Enum = CarType.Caddy, Value = "//*[@id='tip_select_caddy']"},
		new() {Enum = CarType.PickUp, Value = "//*[@id='tip_select_pick-up']"},
		new() {Enum = CarType.OldTimer, Value = "//*[@id='tip_select_pick-oldtimer']"},
		new() {Enum = CarType.Others, Value = "//*[@id='tip_select_pick-ostalo']"},
	};

	public static readonly List<EnumValue<CarColor>> CarColors = new()
	{
		new() {Enum = CarColor.Beige, Value = "//*[@id='boja_select_bez']"},
		new() {Enum = CarColor.White, Value = "//*[@id='boja_select_bijela']"},
		new() {Enum = CarColor.Black, Value = "//*[@id='boja_select_crna']"},
		new() {Enum = CarColor.Red, Value = "//*[@id='boja_select_crvena']"},
		new() {Enum = CarColor.Purple, Value = "//*[@id='boja_select_ljubicasta']"},
		new() {Enum = CarColor.Orange, Value = "//*[@id='boja_select_narandzasta']"},
		new() {Enum = CarColor.Blue, Value = "//*[@id='boja_select_plava']"},
		new() {Enum = CarColor.Gray, Value = "//*[@id='boja_select_siva']"},
		new() {Enum = CarColor.Brown, Value = "//*[@id='boja_select_smedja']"},
		new() {Enum = CarColor.Silver, Value = "//*[@id='boja_select_srebrena']"},
		new() {Enum = CarColor.Green, Value = "//*[@id='boja_select_zelena']"},
		new() {Enum = CarColor.Gold, Value = "//*[@id='boja_select_zlata']"},
		new() {Enum = CarColor.Yellow, Value = "//*[@id='boja_select_zuta']"},
	};
	
	public static readonly List<EnumValue<Gears>> CarGears = new()
	{
		new() {Enum = Gears.Three, Value = "//*[@id='broj-stepeni-prijenosa_select_3-plusr']"},
		new() {Enum = Gears.Four, Value = "//*[@id='broj-stepeni-prijenosa_select_4-plusr']"},
		new() {Enum = Gears.Five, Value = "//*[@id='broj-stepeni-prijenosa_select_5-plusr']"},
		new() {Enum = Gears.Six, Value = "//*[@id='broj-stepeni-prijenosa_select_6-plusr']"},
		new() {Enum = Gears.Seven, Value = "//*[@id='broj-stepeni-prijenosa_select_7-plusr']"},
	};
	
	public static readonly List<EnumValue<RimSize>> RimSizes = new()
	{
		new() {Enum = RimSize.Thirteen, Value = "//*[@id='velicina-felgi_select_13']"},
		new() {Enum = RimSize.Fourteen, Value = "//*[@id='velicina-felgi_select_14']"},
		new() {Enum = RimSize.Fifteen, Value = "//*[@id='velicina-felgi_select_15']"},
		new() {Enum = RimSize.Sixteen, Value = "//*[@id='velicina-felgi_select_16']"},
		new() {Enum = RimSize.Seventeen, Value = "//*[@id='velicina-felgi_select_17']"},
		new() {Enum = RimSize.Eighteen, Value = "//*[@id='velicina-felgi_select_18']"},
		new() {Enum = RimSize.Nineteen, Value = "//*[@id='velicina-felgi_select_19']"},
		new() {Enum = RimSize.Twenty, Value = "//*[@id='velicina-felgi_select_20']"},
		new() {Enum = RimSize.TwentyOne, Value = "//*[@id='velicina-felgi_select_21']"},
		new() {Enum = RimSize.TwentyTwo, Value = "//*[@id='velicina-felgi_select_22']"},
		new() {Enum = RimSize.Other, Value = "//*[@id='tip_select_ostalo']"},
	};
	
	public static readonly List<EnumValue<SoundSystem>> SoundSystems = new()
	{
		new() {Enum = SoundSystem.CassettePlayer, Value = "//*[@id='muzika-ozvu-enje_select_kasetofon']"},
		new() {Enum = SoundSystem.Cd, Value = "//*[@id='muzika-ozvu-enje_select_cd']"},
		new() {Enum = SoundSystem.CdMp3, Value = "//*[@id='muzika-ozvu-enje_select_cd-mp3']"},
		new() {Enum = SoundSystem.CdMp3WithAmplifier, Value = "//*[@id='muzika-ozvu-enje_select_cd-mp3-plus-pojacalo']"},
		new() {Enum = SoundSystem.DvdMp3WithLcdScreen, Value = "//*[@id='muzika-ozvu-enje_select_dvd-mp3-plus-lcd-display']"},
		new() {Enum = SoundSystem.Others, Value = "//*[@id='muzika-ozvu-enje_select_ostalo'1]"},
	};
	
	public static readonly List<EnumValue<SecurityBlockade>> SecurityBlockades = new()
	{
		new() {Enum = SecurityBlockade.GearboxBlockade, Value = "//*[@id='zastita-blokada_select_blokada-mjenjaca']"},
		new() {Enum = SecurityBlockade.SteeringWheelBlockade, Value = "//*[@id='zastita-blokada_select_blokada-volana']"},
		new() {Enum = SecurityBlockade.WheelBlockade, Value = "//*[@id='zastita-blokada_select_blokada-tocka']"},
		new() {Enum = SecurityBlockade.ElectricBlockade, Value = "//*[@id='zastita-blokada_select_elektricna-blokada']"},
		new() {Enum = SecurityBlockade.ElectricAndMechanicalBlockade, Value = "//*[@id='zastita-blokada_select_elektricna-plusmehanicka']"},
		new() {Enum = SecurityBlockade.Others, Value = "//*[@id='zastita-blokada_select_ostalo']"},
	};
}
