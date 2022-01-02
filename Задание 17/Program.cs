using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    /*Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
     *Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета. 
     *Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. Создать  несколько экземпляров класса, параметризированного различными типам. 
     *Заполнить его поля и вывести информацию об экземпляре класса на печать.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ФИО:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите сумму баланса:");
            int balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числовой номер счёта:");
            int numInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строковый номер счёта:");
            string numString = Console.ReadLine();
            Account<int> account1 = new Account<int>(numInt, balance, name);
            Account<string> account2 = new Account<string>(numString, balance, name);
            Console.WriteLine("Данные с числовым счётом: {0}", account1.PrintData());
            Console.WriteLine("Данные со строковым счётом: {0}", account2.PrintData());
            Console.ReadKey();
        }
    }
 
}
