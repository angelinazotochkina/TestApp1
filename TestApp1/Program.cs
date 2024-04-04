using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
 public class Program
    {
       public void Main()
        {
            Console.Write("Введите свое имя: ");
            var name = Console.ReadLine();     
            Console.WriteLine($"Привет {name}");    
        }
    }
}
