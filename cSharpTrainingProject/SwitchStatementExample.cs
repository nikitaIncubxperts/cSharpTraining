using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTrainingProject {
    public class SwitchStatementExample {
        public void SwitchExample() {
        start:
            Console.WriteLine("choose pizza 1.small 2.medium 3.large");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) {
                case 1:
                    Console.WriteLine("you choose one small pizza");
                    break;
                case 2:
                    Console.WriteLine("you choose one medium pizza");
                    break;
                case 3:
                    Console.WriteLine("you choose one large pizza");
                    break;
                default:
                    Console.WriteLine("please enter valid size of pizza");
                    goto start;
            }

        decisionmaking:
            Console.WriteLine("do want to add one more pizza ?: yes/no");
            string decision = Console.ReadLine();
            switch (decision) {
                case "yes":
                    goto start;
                case "no":
                    Console.WriteLine("thank you for order..");
                    break;
                default:
                    Console.WriteLine("please enter yes/no");
                    goto decisionmaking;
            }
        }
    }
}

