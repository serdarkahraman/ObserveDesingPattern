using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Serdar Tournament.");
            Console.WriteLine("============================================================================================================");
            int x, y;
            Console.Write("Oyuncu X hareketini gir : ");
            x = Convert.ToInt16(Console.ReadLine());

            Console.Write("Oyuncu X hareketini gir : ");
            y = Convert.ToInt16(Console.ReadLine());

            // Console.Write("Oyuncu tipi nedir Örnek : Type1, Type2, boş geç sonra bakarız buna: ");



            // Kullanım
            Player player = new Player();
            Referee referee = new Referee();
 
            player.CreateObserver(referee);

            player.Move(x, y);  // Oyuncunun hareketi
            Console.ReadLine();
        }
    }
}
