using System;
using System.Collections.Generic;

/*
 * Create a function that takes an array containing only values of the same type and return the first element
 */
namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
				string[] cars = { "bmw", "mazda", "volvo", "subaru" };
				
				string first = FirstOf(cars);

				Console.WriteLine(first);
				Console.WriteLine("done.");
        }

		static T FirstOf<T>(T[] list)
		{
			return list.Length == 0 ? default(T) : list[0];
		}
    }
}
