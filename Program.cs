using System;
using System.Linq;
using System.Text;


namespace _08102020dz
{
    class Program
    {
        static void task1()
        {
            /*
            Задание 1. Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
            Программа должна сосчитать количество введенных пользователем пробелов. 
            */
            Console.OutputEncoding = Encoding.Unicode;
            char input;
            int spaсeCount = 0;
            do
            {
                input = Console.ReadKey().KeyChar;
                if (input == ' ')
                    spaсeCount++;
            } while (input != '.');
            Console.WriteLine("Quantity of spaces: " + spaсeCount);
            Console.ReadKey();
        }

        static void task2()
        {
            /*
            Задание 2. Ввести с клавиатуры номер трамвайного билета (6-значное число) и про-верить является ли данный билет счастливым 
            (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, 
            то этот билет считается счастливым).
            */
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите номер трамвайного билета(6-значное число): \n\t");
            string str = Console.ReadLine();
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int[] ticketNumber = ch.Select(s => int.Parse(s.ToString())).ToArray();
            if (ch.Length == 6)
            {
                int leftNumber = 0;
                int rightNumber = 0;
                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                        leftNumber += ticketNumber[i];
                    else
                        rightNumber += ticketNumber[i];
                }
                if (leftNumber == rightNumber)
                    Console.WriteLine("А Вы везунчик :) : {0} = {1}", leftNumber, rightNumber);
                else
                    Console.WriteLine("Вам не повезло ! : {0} != {1}", leftNumber, rightNumber);
            }
            else
                Console.WriteLine("Попробуйте еще раз, а вдруг получиться !");
            Console.Read();
        }

        static void task3()
        {
            /*
            Задание 3. Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра 
            на величину 32. Используя эту  информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы 
            нижнего регистра в символы верхнего регистра и наоборот.
            */
            ConsoleKeyInfo symbol;
            do
            {
                Console.WriteLine("Введите символ для конвертации регистра");
                Console.WriteLine("Для окончания ввода нажмите ESC ");
                symbol = Console.ReadKey();
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Введенный символ " + symbol.KeyChar);
                if (char.IsLetter(Convert.ToChar(symbol.KeyChar)))
                {
                    if (char.IsUpper(Convert.ToChar(symbol.KeyChar)))
                    {
                        Console.WriteLine("Конвертируемый символ " + char.ToLower(Convert.ToChar(symbol.KeyChar)));
                    }
                    else
                    {
                        Console.WriteLine("Конвертируемый символ " + char.ToUpper(Convert.ToChar(symbol.KeyChar)));
                    }
                }
                if (Convert.ToInt32(symbol.KeyChar) == 27)
                {
                    break;
                }
            } while (true);
        }

        static void task4()
        {
            /*
            Задание 4.  Даны целые положительные числа A и B (A < B). 
            Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; 
            при этом каждое число должно выводиться количество раз, равное его значению. Например: если А = 3, а В = 7, 
            то программа должна сформировать в консоли следующий вывод:
            3 3 3
            4 4 4 4
            5 5 5 5 5
            */
            Console.WriteLine("Необходимо ввести А и В, причем А<B");
            do
            {
                Console.WriteLine("Введите А");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите B");
                int B = Convert.ToInt32(Console.ReadLine());
                if (A >= B || A <= 0 || B <= 0)
                {
                    Console.WriteLine("Не соблюдено условие А<B либо числа A и B не положительные ");
                    return;
                }
                Console.Clear();
                for (int i = A; i <= B; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i);
                        Console.Write(' ');
                    }
                    Console.WriteLine();
                }
            } while (true);
        }

        static void task5()
        {
            /*
            Задание 5.  Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. 
            Например, если было введено число 345,  то  программа должна вывести число 543.
            */
            do
            {
                Console.WriteLine("Введите N");
                string N = Console.ReadLine();
                if (Convert.ToInt32(N) < 0)
                {
                    Console.WriteLine("Не соблюдено условие N>0");
                    return;
                }
                Console.Clear();
                Console.WriteLine("Полученное число");
                for (int i = N.Length - 1; i >= 0; i--)
                {
                    Console.Write(N[i]);
                }
                Console.Write('\n');
            } while (true);
        }

        static void Main(string[] args)
        {
            task5();
        }
    }
}
