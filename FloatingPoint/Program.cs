using System;

class Program
{
    static void Main()
    {
        double a, b;
        char оператор;

        Console.Write("Введiть перше число: ");
        if (double.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Введiть операцiю (+, -, *, /): ");
            оператор = Convert.ToChar(Console.ReadLine());

            Console.Write("Введiть друге число: ");
            if (double.TryParse(Console.ReadLine(), out b))
            {
                double результат = 0.0;

                switch (оператор)
                {
                    case '+':
                        результат = a + b;
                        break;
                    case '-':
                        результат = a - b;
                        break;
                    case '*':
                        результат = a * b;
                        break;
                    case '/':
                        if (b != 0)
                            результат = a / b;
                        else
                            Console.WriteLine("Помилка: Дiлення на нуль.");
                        break;
                    default:
                        Console.WriteLine("Непiдтримувана операція.");
                        break;
                }

                Console.WriteLine("Результат: " + результат);
            }
            else
            {
                Console.WriteLine("Некоректне друге число.");
            }
        }
        else
        {
            Console.WriteLine("Некоректне перше число.");
        }
    }
}
