using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma a = new Firma();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1 - Добавить фирму" + " " +
                "2 - Вывести вывести фирму" + " " + "3 - Выход");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        {
                            a.Input();
                            break;
                        }
                    case 2:
                        {
                            a.Print();
                            break;
                        }
                    default:
                        {
                            flag = false;
                            break;
                        }
                }
            }
        }
    }
}
