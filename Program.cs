using System;

namespace GenericCollection {
    public class Program {
        static void Main(string[] args) {
            StackGenericClass.StackGenericMethod();
            QueueGenericClass.QueueGenericMethod();
            int[] arrObj = { 7, 2, 5, 9, 1, 5, 2 };
            ArrayAsArgument.SortArray(arrObj);
            foreach (var item in arrObj) {
                Console.Write(item + ",");
            }
            DictionaryGenericClass.DictionaryGenericClassMethod();
            ListGenericClass.ListGenericClassMethod();
        }
    }
}
