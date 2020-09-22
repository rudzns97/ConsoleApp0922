using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    class Class2
    {
        static void ChangeArray(int[] p)
        {
            p[0]++;
        }
        static int MyMax(int[] p)
        {
            int result=0;
            for(int i = 0; i < p.Length; i++)
            {
                if(p[i] > result)
                result = p[i];
                
            }return result;
        }
        static void Main()
        {
            int[] arr1 = new int[3] { 1, 2, 3 };
            Console.WriteLine(arr1[0]);
            ChangeArray(arr1);
            Console.WriteLine(arr1[0]);

            int[] arr2 = new int[3] { 1, 2, 3 };
            Console.WriteLine(arr2[0]);//1

            ChangeArray((int[])arr2.Clone());//Deep Copy
            Console.WriteLine(arr2[0]);//1

            Console.WriteLine(arr2.Min());
            Console.WriteLine(arr2.Max());

            int[] target = new int[5];
            arr2.CopyTo(target, 2);
            PrintArray(target);
            Array.Copy(arr2,  target,3);

            int[] arr3 = new int[10] { 5, 3, 8, 9, 2, 4, 1, 7, 6, 0 };
            PrintArray(arr3);
            Array.Sort((int[])arr3.Clone());
            PrintArray(arr3);
            Array.Reverse(arr3);
            PrintArray(arr3);

            string str = "advfostsge";
            Console.WriteLine(str);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str);
            //Console.WriteLine(str.Replace("str", "00000000000000000"));
            str = str.Replace("5f3d","00000000");
            
            Console.WriteLine(str);

            int[,] s_arr = new int[2, 3]
            {
                {1,2,3 },{4,5,6}
            };
            //Console.WriteLine(PrintArray(s_arr));
            PrintArray(s_arr);
        }

        private static void PrintArray(int[] target)
        {
            for (int i = 0; i < target.Length; i++)
            {
                Console.Write(target.GetValue(i) + " ");
            }
            Console.WriteLine();
        }
        private static void PrintArray(int[,] target)
        {
            for (int i = 0; i < target.GetLength(0); i++)
            {
                for(int k = 0; k < target.GetLength(1); k++) 
                {
                    Console.Write(target[i, k] + " ");
                }
                
            }
            Console.WriteLine(); 
            foreach (int temp in target)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine();
        }
    }
}
