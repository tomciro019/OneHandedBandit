using System;

namespace OneHandedBandit
{
    class Program
    {
        static void Main(string[] args)
        {
            Bandit bandit = new Bandit(10000);

            
 

            while (bandit.Wallet > 0)
            {
                Console.WriteLine("Stav účtu: " + bandit.Wallet);
                Console.WriteLine("vsazené peníze: ");
                string convert = Console.ReadLine();
                int Bet = int.Parse(convert);
                bool ot = bandit.Verify();
                Console.WriteLine("{0}|{1}|{2}", bandit.x, bandit.y, bandit.z);
                if (ot == true)
                {
                    bandit.Wallet = bandit.Vypocet( Bet, bandit.Wallet);
                    Console.WriteLine("Vyhrál jsi: "+ Bet*10  );
                    

                    
                    

                }
                else if (ot == false)
                {
                    bandit.Wallet = bandit.vypocet2(Bet, bandit.Wallet);
                    
                    Console.WriteLine("Prohrál jsi: "+ Bet);
                    
                }


            }

        }
    }
}
