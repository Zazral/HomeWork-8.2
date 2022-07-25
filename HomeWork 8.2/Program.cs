using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneNumbers = new Dictionary<string, string>();
            Console.WriteLine("введите номер телефона и фио\nввод пустой строки останавливает запись");
            string[] arr = new string[3];
            while(true)
            {
                arr = Console.ReadLine().Split(' ');
                if (arr[0] != "")
                {
                    PhoneNumbers.Add(arr[0], $"{arr[1]} {arr[2]}");
                }
                else break;
            }
            Console.WriteLine("чей телефон хотите найти?");
            string number = Console.ReadLine();
            if (PhoneNumbers.TryGetValue(number, out string value))
            {
                Console.WriteLine($"телефоном {number} владеет {value}");
            }
            else Console.WriteLine("такого телефона в базе нет");
            Console.ReadKey();
        }
    }
}
