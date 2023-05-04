using System;
using static System.Formats.Asn1.AsnWriter;

namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
        public int Cylinders { get; set; } = 4;
        public int NumbersOfWheels { get; set; } = 4;
        public string Color { get; set; } = "silver";
        public bool HasTrunk { get; set; } = true;
        public string Logo { get; set; } = "Kia";
        public bool HasFactory { get; set; } = true;

        public bool Escalade { get; set; }
		public int Passengers { get; set; }

        public void Drive()
        {
            if (Escalade == true)
            {
                Console.WriteLine($"The {GetType().Name} can seat 8 people.");
            }
            else
            {
                Console.WriteLine($"The {GetType().Name} cannot seat 8 people.");
            }
        }

        public void Reverse()
        {
            Console.WriteLine($"This {GetType().Name} can go into reverse.");
        }

        public void IsFast()
        {
            Console.WriteLine($"This {GetType().Name} is not as fast as the car!");
        }
    }
}

