using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    class Account<T>
    {
        T Num { get; set; }
        int Balance { get; set; }
        string Name {get; set; }

        public Account(T num, int balance, string name)
        {
            Num = num;
            Balance = balance;
            Name = name;
        }
        public string PrintData()
        {
            return $"{Num} {Balance} {Name}";
        }
    }
}
