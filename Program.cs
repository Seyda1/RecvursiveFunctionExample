using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("çalışma gününü giriniz");//işçi ilk gün 3 lira ücre talıyor her gün bir öncekinin 2 katı ücret alıyor.sonuç toplam ücret
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isfonk(x));
            Console.ReadLine();
        }
        static int isfonk(int x)
        {
            if (x == 1)
                return 3;
            else
                return (3 + 2*isfonk(x - 1));
        
        
        }
    }
}
