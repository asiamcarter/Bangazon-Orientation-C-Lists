using System;
using System.Collections.Generic;

namespace c_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            // Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            // Create another List that contains that last two planet of our solar system.
            List<string> lastTwoPlanets = new List<string>(){"Uranus","Neptune"};
            // Combine the two lists by using AddRange().
            planetList.AddRange(lastTwoPlanets);
            // Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            // Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");
            // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            List<string> rockyPlanets = planetList.GetRange(0,4);
            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.Remove("Pluto");
                foreach(string planet in planetList) {
                // Console.WriteLine(planet);
            }

            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
                };
                foreach(int number in numbers) {
                Console.WriteLine(number);
                }
                Console.WriteLine();

            // Use a for loop to iterate over all numbers between 0 and numbers.Count - 1.
            // Inside the body of the for loop determine if the current loop index is contained inside of the numbers list. Print a message to the console indicating whether the index is in the list.

               for(int i=0; i <= numbers.Count-1; i++) {
                   if (numbers.Contains(i)) {
                    //composite formatting
                       Console.WriteLine("numbers list contains {0}", i );
                    //string interpolation
                   } else {
                       Console.WriteLine($"numbers list does not contain {i}");
                   }
               }

        }



    }
}
