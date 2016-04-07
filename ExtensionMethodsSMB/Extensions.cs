using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsSMB
{
    public static class Extensions
    {
        public static int[] EvenElements(this int[] array)
        {
            int[] evenArray;
            if (array.Length%2==0)
            {
               evenArray  = new int[array.Length/2];
            }
            else
            {
                evenArray = new int[array.Length / 2+1];
            }
            
            int j = 0;
            for (int i = 0; i < array.Length; i+=2)
            {
                evenArray[j] = array[i];
                j++;
            }
            return evenArray;

        }
        public static void ToScreen(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, array[i]);
            }
        }


    }
}
