using System;
using static System.Formats.Asn1.AsnWriter;

namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
        public int Cylinders { get; set; } = 6;
        public int NumbersOfWheels { get; set; } = 8;
        public string Color { get; set; } = "white";
        public bool HasTrunk { get; set; } = false;
        public string Logo { get; set; } = "Chevy";
        public bool HasFactory { get; set; } = true;

        public int BedLength { get; set; }
		public int TowCapacity { get; set; }

        public void Drive()
        {
            if (HasTrunk == true)
            {
                Console.WriteLine($"The {GetType().Name} cannot be ordered with a trunk.");
            }
            else
            {
                Console.WriteLine($"The {GetType().Name} can be ordered with a trunk.");
            }
        }

        public void Reverse()
        {
            Console.WriteLine($"This {GetType().Name} can go into reverse.");
        }

        public void IsFast()
        {
            Console.WriteLine($"This {GetType().Name} is really heavy!");
        }
    }
}

