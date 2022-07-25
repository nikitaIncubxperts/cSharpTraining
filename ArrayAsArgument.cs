using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection {
    public class ArrayAsArgument {
        public static void SortArray(int[] arr) {           
            for (int i = 0; i < arr.Length; i++) { 
                for(int j = i+1; j < arr.Length; j++) {
                    if (arr[j] < arr[i]) {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public static void printArray(int[] arr) {
            Console.WriteLine("Sorted array: ");
            foreach (var item in arr) {
                Console.Write(item + ",");
            }
        }
    }
}
