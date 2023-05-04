using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int Cylinders { get; set; }
		public int NumbersOfWheels { get; set; }
		public string Color { get; set; }
		public bool HasTrunk { get; set; }

		public void Drive();
		public void Reverse();
		public void IsFast();
	}
}

