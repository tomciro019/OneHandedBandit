﻿using System;

namespace OneHandedBandit
{
    class Program
    {
        static void Main(string[] args)
        {
            Bandit bandit = new Bandit(10000);
            Console.WriteLine("Stav účtu: " + bandit.Wallet);
            Console.WriteLine("vsazené peníze: ");
            string convert = Console.ReadLine();
            int Bet = int.Parse(convert);
            bool ot = bandit.Verify();
            if (ot == true)
            {
                Console.WriteLine("Vyhrál jsi");
            }
            else if (ot == false)
            {
                Console.WriteLine("Prohrál jsi");
            }


        }
    }
}
