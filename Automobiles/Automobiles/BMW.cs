using System;
namespace Automobiles
{
	public class BMW : Car
	{
		public BMW()
		{
			this.Type = "BMW";
			this.Model = "750i";
			this.Year = 2014;
			this.MilesPerGallon = "25 Miles";
			this.NumberOfDoors = "Sedan";
			this.AllWheelDrive = true;
			this.TransmissionType = "Automatic";
		}
	}
}
