using System;
using System.Collections;
namespace HashTable {
    public class Program {
        static void Main(string[] args) {
            Hashtable hashdata = new Hashtable();
            hashdata.Add(101,"harry");
            hashdata.Add(102, "greko");
            hashdata.Add(103, "malphoy");
            hashdata.Add(104, "harmieny");
            hashdata.Add(105, "ginger");
            Console.WriteLine("keys   Values");
            Console.WriteLine("--------------");
            foreach (DictionaryEntry k in hashdata) {                
                Console.WriteLine(k.Key+"   "+k.Value);
            }
            Console.WriteLine("\n");
            hashdata[103] = "dumbledore";
            Console.WriteLine("updated 103th index hashtable: ");
            foreach (DictionaryEntry k in hashdata) {
                Console.WriteLine(k.Key + "   " + k.Value);
            }
        }
    }
}
