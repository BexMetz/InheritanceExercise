using System;
using System.Collections.Generic;

namespace Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			var barnOwl = new Bird();
			barnOwl.BirdSpecies = "Barn Owl";
			barnOwl.BirdOfPrey = true;
			barnOwl.CanFly = true;
			barnOwl.WingSpan = 52.8;
			barnOwl.Color = "Muted Colors";

			var rattleSnake = new Reptile();
			rattleSnake.ReptileSpecies = "Rattle Snake";
			rattleSnake.HasLegs = false;
			rattleSnake.IsVenemous = true;
			rattleSnake.SkinType = "Scaly";
			rattleSnake.DangerLevel = 8;

			var animalList = new Animal[] { barnOwl, rattleSnake };

			foreach(var animal in animalList)
			{
				Console.WriteLine($"Animal Class: {animal.AnimalClass}");
				Console.WriteLine($"Scientific name: {animal.ScientificName}");
				Console.WriteLine($"Has a vertebrae: {animal.IsVertebrate}");
				Console.WriteLine($"Is warm blooded: {animal.IsWarmBlooded}");
				Console.WriteLine($"Type of habitat: {animal.HabitatType}");
				Console.WriteLine("");
			}


			// TODO Be sure to follow best practice when creating your classes

			// Create a class Animal
			// give this class 4 members that all Animals have in common


			// Create a class Bird
			// give this class 4 members that are specific to Bird
			// Set this class to inherit from your Animal Class

			// Create a class Reptile
			// give this class 4 members that are specific to Reptile
			// Set this class to inherit from your Animal Class




			/*Create an object of your Bird class
			 *  give values to your members using the object of your Bird class
			 *  
			 * Creatively display the class member values 
			 */

			/*Create an object of your Reptile class
			 *  give values to your members using the object of your Reptile class
			 *  
			 * Creatively display the class member values 
			 */
		}
	}
}
