using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        private string userChoice;
        private int total = 0;

        public int PromptUser()
        {
            foreach (Options chose in Enum.GetValues(typeof(Options)))
            {
                Log($"{(int)chose}:{chose}");
            }

            userChoice = Console.ReadLine();

            Options useroption;
            if (Enum.TryParse(userChoice, out useroption))
            {
                if (useroption == Options.Add)
                {
                    Add();
                }
                else if (useroption == Options.Subtract)
                {
                    Subtract();
                }
                else if (useroption == Options.Multiply)
                {
                    Multiply();
                }
                else if (useroption == Options.Divide)
                {
                    Divide();
                }
                else
                {
                    Log("Please enter a valid choice");
                }
                
            }
            return int.Parse(userChoice);
        }
        public void Divide()
        {
            Log($"Please enter the first number you want to {Options.Multiply}");
            var userNumber1 = Convert.ToInt32(Console.ReadLine());
            Log($"Please enter the second number you want to {Options.Multiply}");
            var userNumber2 = Convert.ToInt32(Console.Read());

            total = userNumber1 / userNumber2;

            Log($"The sum of your numbers is: {total} ");
        }

        public int Multiply()
        {
            Log($"The multiplication of your numbers is: {total}");
            return total;
        }


        public void Subtract()
        {
            AskUserNumbers();
            Log($"The sum of your numbers is: {total} ");
        }

        public void AskUserNumbers()
        {
            if(int.Parse(userChoice) == (int)Options.Subtract)
            {
                Log($"Please enter the first number you want to {Options.Subtract}");
                var usersInputNumber1 = Convert.ToInt32(Console.ReadLine());
                Log($"Please enter the second number you want to {Options.Subtract}");
                var userInputNumber2 = Convert.ToInt32(Console.ReadLine());

                total = usersInputNumber1 - userInputNumber2;
            }
            else if (int.Parse(userChoice) == (int) Options.Multiply)
            {
                Log($"Please enter the first number you want to {Options.Multiply}");
                var userNumber1 = Convert.ToInt32(Console.ReadLine());
                Log($"Please enter the second number you want to {Options.Multiply}");
                var userNumber2 = Convert.ToInt32(Console.Read());

                total = userNumber1 * userNumber2;
            }
            else if (int.Parse(userChoice) == (int)Options.Divide)
            {
                Log($"Please enter the first number you want to {Options.Multiply}");
                var userNumber1 = Convert.ToInt32(Console.ReadLine());
                Log($"Please enter the second number you want to {Options.Multiply}");
                var userNumber2 = Convert.ToInt32(Console.Read());
            }
        }

        public void Add()
        {
            CalulatorAdd();
            Log($"The sum of your numbers is:{total}" );
        }

        public void CalulatorAdd()
        {
            while (true)
            {
                Log("Please enter numbers you want to add, then enter ok when you're done");
                var usersInput = Console.ReadLine();

                if (usersInput.ToLower() == "ok")
                    break;
                total += Convert.ToInt32(usersInput);
            }
        }

        public enum Options
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }
        public void Log(object input)
        {
            Console.WriteLine(input);
        }
    }
}
