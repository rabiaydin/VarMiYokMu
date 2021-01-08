using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varmıyokmu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Eskişehir", "Istanbul", "Ankara", "Izmir", "Diyarbakır", "Sinop","Artvin","Rize" };
            
            Console.WriteLine("Bir şehir giriniz.");
            string girilenSehir = Console.ReadLine();
            bool varMi = false;
            int dizisirasi = 0;
            for (int i=0; i<sehirler.Length;i++)
            {
                if (sehirler[i] == girilenSehir)
                {
                    varMi = true;
                    dizisirasi = i;
                    break;
                }
            }

            if (varMi)
            {
                Console.WriteLine($"{girilenSehir} array de vardır ve {dizisirasi}. indeskte yer alır. ");

            }
            else
            {
                Console.WriteLine($"{girilenSehir} array de yok");
            }


            Console.ReadLine();
        }
    }
}
