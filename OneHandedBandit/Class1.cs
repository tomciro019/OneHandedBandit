using System;
using System.Collections.Generic;
using System.Text;

namespace OneHandedBandit
{
    public class Bandit
    {
        private const int SYMBOL_COUNT = 5;
        private const int CYLINDERS = 3;
        private const double WIN_MULTIPLIER = 10;
        private int _wallet;
        Random rand = new Random();

        public int Wallet
        {
            get
            {
                return _wallet;
            }

            private set
            {
                _wallet = value;
            }
        }
        public Bandit(int wallet)
        {
            _wallet = wallet;
        }

        public bool Verify()
        {
            int ot1 = rand.Next(0, 5);
            int ot2 = rand.Next(0, 5);
            int ot3 = rand.Next(0, 5);

            if (ot1 == ot2 && ot1 == ot3)
            {
                return true;
            }
            else
            {
                return false;
            }






        }
    }
}
