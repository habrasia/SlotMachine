using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    internal class Game
    {
        private Wallet Wallet { get; }
        private decimal Stake { get; set; } = 0;

        public Game(Wallet wallet)
        {
            Wallet = wallet;
        }

        public void SetStake(decimal stake)
        {
            Stake = stake;
        }

        public void Spin(decimal stake)
        {
            Board board = new Board();
            board.DisplayBoard();
            board.CheckForWins();
            decimal coefficient = board.CalculateCoefficient();
            decimal win = CalculateWin(coefficient, stake);
            Wallet.CalculateBalance(win);
        }

        private decimal CalculateWin(decimal coefficient, decimal stake)
        {
            return coefficient * stake;
        }
    }
}
