using System;

namespace CalculatorWithSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор 2.0");
            string cmd;
            double number1;
            double number2;
            bool completed;
            double result = 0;
            string operation = "";
            Console.WriteLine("");
            Console.Title = "Калькулятор 2.0";
            Console.WriteLine("Напомню, что калькулятор одноразовый! Используй с умом! Допускаются дроби. Для дробей используй знак - ','.");
            Console.WriteLine("");
            Console.WriteLine("Введите число 1:");
            number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Число 1 получено! Введите число 2:");
            number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Число 2 получено! Теперь необходимо выбрать операцию. Для просмотра списка операций, введите showop; для пропуска, нажмите Enter");
            cmd = Console.ReadLine();
            if (cmd == "showop") 
            {
                Console.WriteLine("Клавиша: '+' - сложение");
                Console.WriteLine("Клавиша: '-' - вычитание");
                Console.WriteLine("Клавиша: '/' - деление");
                Console.WriteLine("Клавиша: '*' - умножение");
                Console.WriteLine("Клавиши нажимай напрямую с NumPad, NumLock не важен");
            }
            Console.WriteLine("Нажмите клавишу для операции...");
            ConsoleKey operationkey = Console.ReadKey().Key;
            switch (operationkey)
            {
                
                case ConsoleKey.Multiply:
                    {
                        result = number2 * number2;
                        operation = "*";
                        completed = true;
                    }break;
                case ConsoleKey.Add:
                    {
                        result = number1 + number2;
                        operation = "+";
                        completed = true;
                    }
                    break;
                case ConsoleKey.Divide:
                    {
                        result = number1 / number2;
                        operation = "/";
                        completed = true;
                    }
                    break;
                case ConsoleKey.Subtract:
                    {
                        result = number1 - number2;
                        operation = "-";
                        completed = true;
                    }
                    break;
                default:
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Была нажата кнопка не для операций... Программа завершает работу.");
                        completed = false;
                    }
                    break;
            }
            if (completed)
            {
                Console.WriteLine("");
                Console.WriteLine(number1 + " " + operation + " " + number2 + " = " + result);
            }
        }
    }
}
