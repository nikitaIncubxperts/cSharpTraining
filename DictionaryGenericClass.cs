using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection {
    public class DictionaryGenericClass {
        public static void DictionaryGenericClassMethod() { 
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(201, "size");
            dict.Add(202, "galaxy");
            dict.Add(203, "move");
            dict.Add(204, "flemingo");
            dict.Add(205, "rock");

            Console.WriteLine("Dictionary: ");
            foreach (KeyValuePair<int, string> kvp in dict) {
                Console.WriteLine(kvp.Key+" : "+kvp.Value);
            }

            dict.Remove(205);
            Console.WriteLine("\nUpdated Dictionary: ");
            Console.WriteLine("\ntotal objects are: "+dict.Count);
            foreach (KeyValuePair<int, string> kvp in dict) {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
            }

            Console.WriteLine("\nChecking existance of elememt '204': " + dict.ContainsKey(204));
            Console.WriteLine("\nChecking existance of elememt 'move: " + dict.ContainsValue("move"));

            dict.Clear();
            Console.WriteLine("\nCleared Dictionary: ");
            foreach (KeyValuePair<int, string> kvp in dict) {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
            }            
        }
    }
}
/*
 Note:
The working of Dictionary is quite similar to the non-generic hashtable. 
The advantage of Dictionary is, it is generic type. Dictionary is defined under System.Collection.Generic namespace. 
It is dynamic in nature means the size of the dictionary is grows according to the need.
 */