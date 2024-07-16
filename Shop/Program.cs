using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerCoin = 0;
            int cristalPrice = 10;
            int byingCristal;

            Console.WriteLine("Сколько золота у вас в кармане?");
            playerCoin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"У вас {playerCoin} монет, один кристал стоит {cristalPrice}, сколько кристалов вы хотите купить?");
            byingCristal = Convert.ToInt32(Console.ReadLine());
            playerCoin -= cristalPrice * byingCristal;
            Console.WriteLine($"Вы купили {byingCristal} и у вас осталось {playerCoin} монет");
            Console.ReadKey();
        }
    }
}
