using System;

/*
 * Create a function that finds the index of a given item
 * If the item is not present, return -1
 */
namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
				var result1 = IndexOf(new int[] {1,5,3}, 5);
				var result2 = IndexOf(new int[] {9,8,3}, 3);
				var result3 = IndexOf(new int[] {1,2,3}, 4);

				Console.WriteLine($"{result1}\n{result2}\n{result3}");
        }

			static int IndexOf(int[] list, int target)
			{
				for (var i = 0; i < list.Length; i++)
					if (list[i] == target) return i;

				return -1;
			}
    }
}
