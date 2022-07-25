using System;

namespace GenericCollection {
    internal class Program {
        static void Main(string[] args) {
            //StackGenericClass.StackGenericMethod();
            //QueueGenericClass.QueueGenericMethod();
            int[] arrObj = { 7, 2, 5, 9, 1, 5, 2 };
            ArrayAsArgument.SortArray(arrObj);
            ArrayAsArgument.printArray(arrObj);
        }
    }
}
