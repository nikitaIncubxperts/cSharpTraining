using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection {
    public class ListGenericClass {
        public static void ListGenericClassMethod() { 
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(9);
            list.Add(32);
            list.Add(5);
            list.Add(7);
            list.Add(12);
            list.Add(54);
            list.Add(8);

            Console.WriteLine("\nPrinting List: ");
            foreach (int i in list) {
                Console.Write(i+",");
            }

            list.Sort();
            Console.WriteLine("\n\nSorted List: ");
            foreach (int i in list) {
                Console.Write(i + ",");
            }

            list.Remove(1);
            Console.WriteLine("\n\nList after removing '1': ");
            foreach (int i in list) {
                Console.Write(i + ",");
            }

            list.RemoveAt(1);
            Console.WriteLine("\n\nList after removing 1st index: ");
            foreach (int i in list) {
                Console.Write(i + ",");
            }

            list.RemoveRange(2,3);  //index,count
            Console.WriteLine("\n\nList after removing 4-7 range: ");
            foreach (int i in list) {
                Console.Write(i + ",");
            }
        }
    }
}
