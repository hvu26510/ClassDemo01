using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SinhVien sv1 = new SinhVien();

            sv1.setSV(1,2);
            

            Console.WriteLine(sv1.getDiem());

            Console.ReadLine();

            


        }
    }


}
