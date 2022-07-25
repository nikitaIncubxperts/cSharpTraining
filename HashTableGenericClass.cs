using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//it is default generic collection

namespace GenericCollection {
    public class HashTableGenericClass {
        public static void HashTableGenericClassMethod() { 
            HashSet<int> intSet = new HashSet<int>();
            intSet.Add(398);
            intSet.Add(397);
            intSet.Add(396);
            intSet.Add(395);
            intSet.Add(394);

            intSet.RemoveWhere(IsOdd);

            Console.WriteLine("Hashset: ");
            foreach (int i in intSet) {
                Console.Write(i+",");
            }

            Console.WriteLine("\n\nChecking existance of element: "+intSet.Contains(396));
            Console.WriteLine("\nRemoving 397: "+intSet.Remove(397));

            Console.WriteLine("\nTotal elements are: "+intSet.Count);
            foreach (int i in intSet) {
                Console.Write(i + ",");
            }

            
        }

        public static bool IsOdd(int i) {
            return ((i % 2) == 1);
        }
    }
}
