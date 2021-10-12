using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rodya
{
    class Program
    {
        enum Op
        {
            Add,
            Sep,
            Mul,
            Delit,
        }
        static void Main(string[] args)
        {
            int FirstNumber, SecondNumber;
            FirstNumber = In(out int x);
            Console.WriteLine("Хмм а теперь второе");
            SecondNumber = In(out int z);
            Op s = Operation();
            switch (s)
            {
                case Op.Add:
                    Console.WriteLine(FirstNumber + SecondNumber);
                    break;
                case Op.Delit:
                    Console.WriteLine(FirstNumber / SecondNumber);
                    break;
                case Op.Mul:
                    Console.WriteLine(FirstNumber * SecondNumber);
                    break;
                case Op.Sep:
                    Console.WriteLine(FirstNumber - SecondNumber);
                    break;
            }
            Console.ReadKey();

        }
        private static int In(out int x)
        {
            
            bool True;
            do
            {
                Console.WriteLine("Введите число");
                True = int.TryParse(Console.ReadLine(), out x);
                if (True == false) { Console.WriteLine("Введи норм тему дибил"); }
            } while (!True);
            return x;
        }
        private static Op Operation()
        {
            Op CheKavo = Op.Add;
            bool True;
            do
            {
                Console.WriteLine("Йоу мужичок че делать будем?\nВведи крч +,-,/ или *");
                string rep = Console.ReadLine();
                if (rep == "*" | rep == "/" | rep == "-" | rep == "+")
                {
                    if (rep == "*")
                    {
                        CheKavo = Op.Mul;
                    }
                    else if (rep == "-")
                    {
                        CheKavo = Op.Sep;
                    }
                    else if (rep == "/")
                    {
                        CheKavo = Op.Delit;
                    }
                    else
                    {
                        CheKavo = Op.Add;
                    }
                    True = true;
                }
                else
                {
                    Console.WriteLine("Бро введи тип плюсик там или такую тему шаришь");
                    True = false;
                }
            } while (!True);
            return CheKavo;
        }
    }
}
