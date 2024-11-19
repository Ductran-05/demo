using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap thang :");
            int th = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nam :");
            int nm = Convert.ToInt32(Console.ReadLine());
            switch (th)
            {
                case 1: case 3: case 5:case 7: case 8: case 10: case 12:
                    Console.WriteLine(31);
                    break;
                case 4: case 6: case 9: case 11:
                    Console.WriteLine(30);
                    break;
                case 2:
                    {
                        if ((nm % 4 == 0 && nm % 100 != 0) || nm % 400 == 0)
                        {
                            Console.WriteLine(29);
                        }
                        else Console.WriteLine(28);
                        break;
                    }
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
