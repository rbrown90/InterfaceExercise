using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
		public Car()
		{

		}
		public int Cylinders { get; set; } = 8;
		public int NumbersOfWheels { get; set; } = 5;
		public string Color { get; set; } = "black";
		public bool HasTrunk { get; set; } = false;
		public string Logo { get; set; } = "Pagani";
		public bool HasFactory { get; set; } = true;

		public bool IsCoupe { get; set; } = true;
		public string LowProfileTires { get; set; } = "yes";

		public void Drive()
		{
			if(IsCoupe == true)
			{
				Console.WriteLine($"The {GetType().Name} is a coupe.");
			}
			else
			{
				Console.WriteLine($"The {GetType().Name} is not a coupe.");
			}
		}

		public void Reverse()
		{
			Console.WriteLine($"This {GetType().Name} can go into reverse.");
		}

		public void IsFast()
		{
			Console.WriteLine($"This {GetType().Name} is really fast!");
		}


	}

		
		
}