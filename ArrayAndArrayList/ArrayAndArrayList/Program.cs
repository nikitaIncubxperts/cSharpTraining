using System;

namespace ArrayAndArrayList {
    public class Program {
        static void Main(string[] args) {
            int i;
            int[] num = { 6, 2, 8, 12, 4, 32, 8, 43, 33 };
            Console.WriteLine("Array Elements: ");
            for (i = 0; i < num.Length; i++) {
                Console.Write(num[i] + ",");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Length of array: " + num.Length);
            Console.WriteLine();

            Array.Sort(num);    //sort array in Asc order
            Console.WriteLine("Sorted array: ");
            for (i = 0; i < num.Length; i++) {
                Console.Write(num[i] + ",");
            }
            Console.WriteLine("\n");

            var varIndex = Array.IndexOf(num, 33);
            Console.WriteLine("Index position of value: ");
            Console.WriteLine("33 is at " + varIndex + "th position");   //returns index of value
            Console.WriteLine("\nvalue of position: ");
            Console.WriteLine("4th position value is " + num[3]);
            Console.WriteLine();

            Array.Reverse(num);
            Console.WriteLine("Reverse array: ");
            for (i = 0; i < num.Length; i++) {
                Console.Write(num[i] + ",");
            }
            Console.WriteLine("\n");

            int[] num2 = new int[9];
            Array.Copy(num, num2, num.Length);
            Console.WriteLine("printing copied array: ");
            for (i = 0; i < num2.Length; i++) {
                Console.Write(num2[i] + ",");
            }

            Console.WriteLine("\n\nprinting array using foreach loop: ");
            string[] names = { "raghavi", "shaunak", "Grishma", "Jay" };
            foreach (string name in names) {
                Console.Write(name+",");
            }
            Console.WriteLine("\n");
        }
    }
}
