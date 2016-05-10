using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qsort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ReadLine();
        }
#region Sort
        private static void Qsort(int[] a, int low, int high)
        {
            var p = low;
            var r = high;
            int q = a[low + (high - low)/2];

            do
            {
                while (a[p] < q) p++;
                while (a[r] > q) r--;
                if (p <= r)
                {
                    var temp = a[p];
                    a[p] = a[r];
                    a[r] = temp;
                    p++;
                    r--;
                }
            } while (p <= r);
            if (low < r) Qsort(a, low, r);
            if (p < high) Qsort(a, p, high);

        }
        private static void SelectionSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                var min = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[min] > a[j])
                    {
                        min = j;
                    }
                }
                var temp = a[i];
                a[i] = a[min];
                a[min] = temp;
            }
        }
        private static void InsrertSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++) // int[] arr = new[] {10, 2, 3, 0, 55, 199,20,24,500,0, 1, 6, 3};
            {
                var cur = a[i];
                var j = i;
                while (j > 0 && cur < a[j - 1])
                {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = cur;
                Console.WriteLine("Cur - {0}", cur);
            }
        }
#endregion
    }
}
