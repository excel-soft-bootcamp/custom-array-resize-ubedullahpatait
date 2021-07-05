using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUtility
{
    public static class ArrayUtility
    {

        public static void Resize(ref int[] array, int newSize)
        {

			int[] ArrayTemp =new int[newSize];
		       for(int i=0; i<array.Length; i++)
		       {
			       ArrayTemp[i] = array[i];
		       }

	               array =ArrayTemp;


		}

	}
}
