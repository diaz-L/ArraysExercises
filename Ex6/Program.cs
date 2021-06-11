using System;

/*
 * Write a function to reverse an array
 */
namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
				string[] list1 = {"bmw", "mazda", "volvo"};
				int[] list2 = new int[] {1,2,3,4};
				int[] list3 = new int[] {9, 9, 2, 3, 4};
				int[] list4 = new int[] {};

				var result1 = Reverse(list1);
				var result2 = Reverse(list2);
				var result3 = Reverse(list3);
				var result4 = Reverse(list4);

				PrintList(list1, result1);
				PrintList(list2, result2);
				PrintList(list3, result3);
				PrintList(list4, result4);
        }

			static T[] Reverse<T>(T[] list)
			{
				T[] temp = new T[list.Length];

				for (int i = list.Length - 1, j = 0; i >= 0; i--, j++) 
					temp[j] = list[i];

				return temp;
			}

			static string ArrayToString<T>(T[] list)
			{
				string output = "[ ";

				foreach (var item in list)
					output += $"{item} ";

				return output + "]";
			}

			static void PrintList<T>(T[] list1, T[] list2)
			{
				Console.WriteLine("Before: {0}", ArrayToString(list1));
				Console.WriteLine("After: {0}", ArrayToString(list2));
				Console.WriteLine();
			}
    }
}
