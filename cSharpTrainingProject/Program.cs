using System;
using cSharpTrainingProject;

namespace cSharpTrainingProject {
    public class Program {
        static void Main(string[] args) {
            ForLoop f = new ForLoop();
            f.ForLoopMethod();
            f.DoWhileLoop();
            int factorial = f.WhileLoopMethod(5);
            Console.WriteLine("Factorial of 5: "+factorial);
            f.NestedLoopMethod();
            f.TernaryOperatorMethod();
            SwitchStatementExample s = new SwitchStatementExample();
            s.SwitchExample();
        }
    }
}
