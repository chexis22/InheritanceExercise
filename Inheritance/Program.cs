using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var eagle = new Bird();

            eagle.HasFeathers = true;
            eagle.Beak = 1;
            eagle.HasGizzard = true;
            eagle.Tallon = 6;
            Console.WriteLine($"Do eagles have feathers? :{eagle.HasFeathers}. Eagles have {eagle.Beak} beak and {eagle.Tallon} tallons!");

            var alligator = new Reptile();
            alligator.IsColdBlooded = true;
            alligator.HasScales = true;
            alligator.Teeth = 100;
            alligator.Tail = 1;
            alligator.Legs = 4;

            Console.WriteLine($"Alligators are cold-blooded is {alligator.IsColdBlooded} and alligators have scales is {alligator.HasScales}!");
            Console.WriteLine($"Alligators have {alligator.Eyes} eyes");
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
