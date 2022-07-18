using System;

namespace Calculator {
    internal class Program {
        static void Main(string[] args) {

            // Make a calculator program

            // Desenvolver uma calculadora com os seguintes requisitos:
            // 1. Ter operadores aritméticos básicos: soma, subtração, multiplicação e divisão;
            // 2. A calculadora deve ter um botão para ligar e desligar, não pode parar de rodar
            // enquanto o botão de desligar não for ativado;

            Console.WriteLine("Press 1 to start the calculator.");
            int onOrOff = int.Parse(Console.ReadLine());
            while (onOrOff == 1) {
                Console.WriteLine("What type of operation would like to use? \n" +
                    "Multiplication [1] \n" +
                    "Division [2] \n" +
                    "Sum [3] \n" +
                    "Subtraction [4] ");
                string operat = Console.ReadLine();
                Console.Write("What is your first number to calculate: ");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.Write("What is your second number to calculate: ");
                double secondNumber = double.Parse(Console.ReadLine());

                if (operat == "1") {
                    Console.WriteLine($"The multiplication between {firstNumber} and {secondNumber} is {firstNumber * secondNumber}");
                }
                else if (operat == "2") {
                    Console.WriteLine($"The division between {firstNumber} and {secondNumber} is {firstNumber / secondNumber}");
                }
                else if (operat == "3") {
                    Console.WriteLine($"The sum between {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");
                }
                else if ((operat == "4")) {
                    Console.WriteLine($"The subtraction of {firstNumber} and {secondNumber} is {firstNumber - secondNumber}");
                }
                Console.Write("Would you like to continue [Y] or [N]: ");
                string cont = Console.ReadLine();
                if (cont == "n") {
                    break;
                }
                else {
                    continue;
                }
            }
        }
    }
}

