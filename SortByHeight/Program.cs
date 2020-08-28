using System;

namespace SortByHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter loop length: ");
            int length = int.Parse(Console.ReadLine());
            int[] a = new int[length];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter element: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Sorted loop by height: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(sortByHeight(a)[i] + " ");
            }
            Console.ReadLine();
        }
        static int[] sortByHeight(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] == -1)
                {
                    continue;
                }
                for (int j = i + 1; j < a.Length; j++)
                {
                    if(a[i] > a[j] && a[j] != -1)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;
        }
    }
}
