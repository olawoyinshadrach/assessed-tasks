using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    //Generic insert sort implementation for Assessed Exercise 3

    //Hints : 
    //Use lecture materials from Week 7
    // to aid with implementation...

    //Use the provided insert sort function as a starting point for
    // adjusting the functionality to make it generic. Make use of IComparable
    // as you have done during other structure implementations

    //Double check your implemented generic functionality against the provided
    // inserted sort function

    //Your implemented function can be utilised as part EX.3C

    // - Adam.M 

    class SortUtils
    {

        static public void InsertSort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int value = a[i];
                int j = i;

                for (; j > 0 && value < a[j - 1]; j--)
                {
                    a[j] = a[j - 1];
                }
                a[j] = value;
            }
        }

        static public void GenericInsertSort<T>(T[] a) where T : Icomparable
        {
            //for a null or empty array	
            if (a == null || a.Length == 0)
            {
                throw new ArgumentException("You must add items to the array");
            }
            //to be removed when the needed compareTo() function is added
            //throw new NotImplementedException("Required implementation in development phase");
            for (int i = 1; i < a.Length; i++)
            {
                T value = a[i];
                int j = i;
                for (; j > 0 && value.CompareTo(a[j - 1]) < 0; j--)
                {
                    a[j] = a[j - 1];
                }
                a[j] = value;
            }
        }

    }
}
