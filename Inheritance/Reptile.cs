using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
			AnimalClass = "Reptile";
            ScientificName = "Serpentes";
            IsVertebrate = true;
            IsWarmBlooded = false;
            HabitatType = "Land";

        }

		public string ReptileSpecies { get; set; }
		public bool HasLegs { get; set; }
		public bool IsVenemous { get; set; }
		public int DangerLevel { get; set; }
		public string SkinType { get; set; }
	}
}

