using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Data;
using MT.Core;
using MT.Account;

namespace MT.MConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Role role = new Role();
            role.ID = 10001;
            role.Name = "zhangsan";
            role.Num = 1;
            role.DeleteTime = DateTime.Now;
            Console.WriteLine(role.ID);
            Console.WriteLine(role.Num);
            Console.WriteLine(role.Name);
            Console.WriteLine(role.CreatTime.ToString());
            Console.WriteLine(role.DeleteTime.ToString());
            Console.ReadLine();
        }
    }
}
