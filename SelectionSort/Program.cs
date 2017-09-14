using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorting = new SortAlgorithms<int>();
            var arrayValues = new int[] { 9,5,2,1,7,3,4,6};

            Console.WriteLine("Array Not Organized: " );

            foreach(var value in arrayValues)
            {
                Console.WriteLine(value);
            }
            sorting.SortSelection(arrayValues);

            Console.WriteLine("Array Already Organized: ");

            foreach (var value in arrayValues)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
