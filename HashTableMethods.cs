using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable {
    public class HashTableMethods {
        public void HashMethods() {
            Hashtable hashdata = new Hashtable();
            Hashtable hashdata3 = new Hashtable();

            hashdata.Add(101, "harry");
            hashdata.Add(102, "greko");
            hashdata.Add(103, "malphoy");
            hashdata.Add(104, "harmieny");
            hashdata.Add(105, "ginger");

            Console.WriteLine("keys   Values");
            Console.WriteLine("--------------");
            foreach (DictionaryEntry k in hashdata) {
                Console.WriteLine(k.Key + "   " + k.Value);
            }

            Console.WriteLine("\n");
            hashdata[103] = "dumbledore";
            Console.WriteLine("updated 103th index value in hashtable: ");
            foreach (DictionaryEntry k in hashdata) {
                Console.WriteLine(k.Key + "   " + k.Value);
            }

            Console.WriteLine("\n");
            hashdata.Remove(103);
            Console.WriteLine("Removed 103th index value: ");
            foreach (DictionaryEntry k in hashdata) {
                Console.WriteLine(k.Key + "   " + k.Value);
            }

            Console.WriteLine("\n checking existing key and value");
            bool decision = hashdata.Contains(101);
            Console.WriteLine(decision);
            Console.WriteLine(hashdata.ContainsKey(101));
            Console.WriteLine(hashdata.ContainsValue("greko"));

            Console.WriteLine("\n");
            DictionaryEntry[] hashdata2 = new DictionaryEntry[hashdata.Count];
            hashdata.CopyTo(hashdata2, 0);
            Console.WriteLine("copying hashdata values to hashdata2");
            foreach (DictionaryEntry k in hashdata2) {
                Console.WriteLine(k.Key + "   " + k.Value);
            }

            hashdata3 = hashdata;
            Console.WriteLine("copying hashdata values to hashdata2 by another way: ");
            foreach (DictionaryEntry k in hashdata3) {
                Console.WriteLine(k.Key + "   " + k.Value);
            }

            Console.WriteLine("\n");
            hashdata.Clear();
            Console.WriteLine("cleared table: ");
            foreach (DictionaryEntry k in hashdata) {
                Console.WriteLine(k.Key + "   " + k.Value);
            }
        }
    }
}
