using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList {
    public class SortedList {
        public static void SortedListMethods() {
            SortedList<int, string> sortedList = new SortedList<int, string> {
                { 301, "Foo" },
                { 302, "Bar" },
                { 303, "Zoo" },
                { 304, "Marks" },
                { 305, "Marine" }
            };

            foreach (var keyValue in sortedList) {
                Console.WriteLine(keyValue);
            }

            //SortedList<int, string> sortedList2 = new SortedList<int, string> {
            //    { 301, "Foo" },
            //    { 302, "Bar" },
            //    { 303, "Zoo" },
            //    { 304, "Marks" },
            //    { 305, "Marine" }
            //};
            //Console.WriteLine("\nComparing two Sortedlist: " + sortedList.Equals(sortedList2));

            sortedList.Remove(303);
            Console.WriteLine("\nSortedList after Removing value by key key: ");
            foreach (var keyValue in sortedList) {
                Console.WriteLine(keyValue);
            }

            sortedList.RemoveAt(3);
            Console.WriteLine("\nSortedList after Removing 3rd index value: ");
            foreach (var keyValue in sortedList) {
                Console.WriteLine(keyValue);
            }

            Console.WriteLine("\nChecking existance of key 301: ");
            Console.WriteLine(sortedList.ContainsKey(301));

            Console.WriteLine("\nChecking existance of value: ");
            Console.WriteLine(sortedList.ContainsValue("Marks"));   //case sensitive

            Console.WriteLine("\nSystem type of object: " + sortedList.GetType());
        }
    }
}
