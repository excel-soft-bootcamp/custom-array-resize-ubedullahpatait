using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUtility
{
    public static class ArrayUtility
    {

        public static int Resize(ref int[] array, int newSize)
        {

			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array[i]);
				//newSize++;

			}
			array = new int[newSize];
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array[i]);
				//newSize++;

			}
			Console.WriteLine((array));
			// arr[5] = 'n';
			return array[5];


		
      


		}

	}
}
