using System;
using ArrayAndArrayList;
using System.Collections;

namespace ArrayAndArrayList {
    public class Program {
        static void Main(string[] args) {
            ArrayExample.ArrayMethods();

            int i;
            var arrlst = new ArrayList();
            arrlst.Add(54);
            arrlst.Add("Bananas");
            arrlst.Add(null);
            arrlst.Add("sweet");
            arrlst.Add(3.5f);
            arrlst.Add("apples");
            arrlst.Add(null);
            arrlst.Add("crunchy");

            ArrayList arrlst2 = new ArrayList() {
                2,"foo",5,"bar"
            };

            arrlst[0] = "grand";

            for (i = 0; i < arrlst.Count; i++) {
                Console.Write(arrlst[i] + ",");
            }
            Console.WriteLine("\n");

            Console.WriteLine("\nvalue of position: ");
            Console.WriteLine("4th position value is " + arrlst[3]);
            Console.WriteLine("\n");

            arrlst.Insert(1, "John");
            Console.WriteLine("Inserted element at 1st position: ");
            for (i = 0; i < arrlst.Count; i++) {
                Console.Write(arrlst[i] + ",");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Inserting array in another array from specific range");
            arrlst.InsertRange(3, arrlst2);
            for (i = 0; i < arrlst.Count; i++) {
                Console.Write(arrlst[i] + ",");
            }
            Console.WriteLine("\n");

            Console.WriteLine("removing first occurence null");
            arrlst.Remove(null);
            for (i = 0; i < arrlst.Count; i++) {
                Console.Write(arrlst[i] + ",");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Removing value of index 5: ");
            arrlst.RemoveAt(6);
            for (i = 0; i < arrlst.Count; i++) {
                Console.Write(arrlst[i] + ",");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Removing value from range 1-3: ");
            arrlst.RemoveRange(1,3);
            for (i = 0; i < arrlst.Count; i++) {
                Console.Write(arrlst[i] + ",");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Reversing the arraylist: ");
            arrlst.Reverse();
            for (i = 0; i < arrlst.Count; i++) {
                Console.Write(arrlst[i] + ",");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Appending ArrayList: ");
            arrlst.AddRange(arrlst2);
            for (i = 0; i < arrlst.Count; i++) {
                Console.Write(arrlst[i] + ",");
            }
            Console.WriteLine("\n");
        }
    }
}
