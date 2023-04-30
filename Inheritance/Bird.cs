using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
			AnimalClass = "Bird";
            ScientificName = "Strigiformes";
            IsVertebrate = true;
			IsWarmBlooded = true;
			HabitatType = "Air";
        }

		public string BirdSpecies { get; set; }
		public bool CanFly { get; set; }
		public string Color { get; set; }
		public double WingSpan { get; set; }
		public bool BirdOfPrey { get; set; }
	}
}

