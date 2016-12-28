using System;
namespace Automobiles
{
	public class Audi : Car
	{
		public Audi()
		{
			this.Type = "Audi";
			this.Model = "A4";
			this.Year = 2017;
			this.MilesPerGallon = "28 Miles";
			this.NumberOfDoors = "Sedan and Coupe available";
			this.AllWheelDrive = true;
			this.TransmissionType = "Automatic";
		}
	}
}
