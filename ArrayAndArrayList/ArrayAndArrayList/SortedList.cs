using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList {
    public class SortedList {
        public static void SortedListMethods() {
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(301, "Foo");
            sortedList.Add(302, "Bar");
            sortedList.Add(303, "Zoo");
            sortedList.Add(304, "Marks");
            sortedList.Add(305, "Marine");

            foreach(var keyValue in sortedList) {
                Console.WriteLine(keyValue);
            }

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
        }
    }
}
