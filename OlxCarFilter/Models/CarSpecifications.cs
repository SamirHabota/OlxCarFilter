using OlxCarFilter.Enumerations;

namespace OlxCarFilter.Models;

public class CarSpecifications
{
	public CarState CarState { get; set; }
	public CarBrand CarBrand { get; set; }
	public decimal PriceFrom { get; set; }
	public decimal PriceTo { get; set; }
	public Location Location { get; set; }
	public int YearFrom { get; set; }
	public int YearTo { get; set; }
	public MileageFrom MileageFrom { get; set; }
	public MileageTo MileageTo { get; set; }
	public List<Fuel> Fuels { get; set; } = null!;
	public decimal HorsePowerFrom { get; set; }
	public decimal HorsePowerTo { get; set; }
	
	public decimal KilowattFrom { get; set; }
	public decimal KilowattTo { get; set; }
	public Kubikage KubikageFrom { get; set; }
	public Kubikage KubikageTo { get; set; }
	public List<MotorDriveMethod> MotorDriveMethods { get; set; } = null!;
	public List<Transmission> Transmissions { get; set; } = null!;
	public List<AmountOfDoors> AmountOfDoors { get; set; } = null!;
	public List<Sensors> Sensors { get; set; } = null!;
	public List<CarType> CarTypes { get; set; } = null!;
	public List<CarColor> CarColors { get; set; } = null!;
	public List<Gears> CarGears { get; set; } = null!;
	public List<RimSize> RimSizes { get; set; } = null!;
	public List<SoundSystem> SoundSystems { get; set; } = null!;
	public List<SecurityBlockade> SecurityBlockades { get; set; } = null!;
}
