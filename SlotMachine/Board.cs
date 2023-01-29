using System.Linq;
using System.Text;

namespace SlotMachine
{
    internal class Board
    {
        private char[,] SingleBoard { get; set; }

        public Board()
        {
            SingleBoard = new char[4, 3];
            GenerateSingleBoardResult();
        }

        private void GenerateSingleBoardResult()
        {
            throw new NotImplementedException();
        }

        internal void DisplayBoard()
        {
            for (int i = 0; i < SingleBoard.GetLength(0); i++)
            {
                for (int j = 0; j < SingleBoard.GetLength(1); j++)
                {
                    Console.Write(SingleBoard[i, j] + " ");

                }
                Console.WriteLine();
            }
        }

        internal string CheckForWins()
        {
            StringBuilder winningString = new StringBuilder();
            bool win;
            string winningRow = "";
            for (int i = 0; i < SingleBoard.GetLength(0); i++)
            {
                char currentSymbol = SingleBoard[i, 0];
                for (int j = 0; j < SingleBoard.GetLength(1); j++)
                {
                    winningRow = "";
                    if (SingleBoard[i, j] == currentSymbol || SingleBoard[i, j] == '*')
                    {
                        win = true;
                        winningRow.Append(SingleBoard[i, j]);
                    }
                    else
                    {
                        win = false;
                        winningRow = "";
                        break;
                    }
                }
                winningString.Append(winningRow);
            }
            return winningString.ToString();
        }

        internal decimal CalculateCoefficient(string winningString)
        {
            throw new NotImplementedException();
        }
    }
}
