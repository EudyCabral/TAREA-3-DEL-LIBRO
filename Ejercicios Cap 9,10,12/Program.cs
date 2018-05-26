using Ejercicios_Cap_9_10_12.Cap_10;
using Ejercicios_Cap_9_10_12.Cap_12;
using Ejercicios_Cap_9_10_12.Cap_9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios_Cap_9_10_12
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Program m = new Program();
            m.menuprincipal();
        }

        public void menuprincipal()
        {
            Console.Write("1)Cap 9\n2)Cap 10\n3)Cap 12\nDigite el numero de capitulo que decea ver: ");
            int i;
            i = int.Parse(Console.ReadLine());

            if (i < 1 || i > 3)
            {
                Console.Clear();
                Console.WriteLine("Digite un numero del 1 al 3");
                menuprincipal();
            }
            else
            {

                switch (i)
                {
                    case 1:

                        Ejercicios_del_Cap_9 ec9 = new Ejercicios_del_Cap_9();
                        Console.Clear();
                        ec9.Ejercicios();
                        break;
                    case 2:
                        Ejercicios_cap_10 e10 = new Ejercicios_cap_10();
                        e10.Ejercicios();
                        break;
                    case 3:
                        Ejercicios_del_Cao_12 e12 = new Ejercicios_del_Cao_12();
                        e12.Ejercicios();
                        break;
                        //
                }
            }
        }
    }
}
