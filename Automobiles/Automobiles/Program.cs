using System;

namespace Automobiles
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("List of Automobiles For Sale");
			Console.WriteLine("");

			Car honda = new Honda();

			Console.WriteLine("Type: " + honda.Type);
			Console.WriteLine("Model: " + honda.Model + ", " + honda.NumberOfDoors);
			Console.WriteLine("Year: " + honda.Year);
			Console.WriteLine("Transmission Type: " + honda.TransmissionType);
			Console.WriteLine("All Wheel Drive: " + honda.AllWheelDrive);
			Console.WriteLine("Gas Miles Per Gallon: " + honda.MilesPerGallon);

			Console.WriteLine("________________________________________");

			Car audi = new Audi();

			Console.WriteLine("Type: " + audi.Type);
			Console.WriteLine("Model: " + audi.Model + ", " + audi.NumberOfDoors);
			Console.WriteLine("Year: " + audi.Year);
			Console.WriteLine("Transmission Type: " + audi.TransmissionType);
			Console.WriteLine("All Wheel Drive: " + audi.AllWheelDrive);
			Console.WriteLine("Gas Miles Per Gallon: " + audi.MilesPerGallon);

			Console.WriteLine("________________________________________");

			Car bmw = new BMW();

			Console.WriteLine("Type: " + bmw.Type);
			Console.WriteLine("Model: " + bmw.Model + ", " + bmw.NumberOfDoors);
			Console.WriteLine("Year: " + bmw.Year);
			Console.WriteLine("Transmission Type: " + bmw.TransmissionType);
			Console.WriteLine("All Wheel Drive: " + bmw.AllWheelDrive);
			Console.WriteLine("Gas Miles Per Gallon: " + bmw.MilesPerGallon);
			
		}
	}
}
