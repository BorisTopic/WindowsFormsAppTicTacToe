using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class clsTicTacToe
    {
        /// <summary>
        /// An array to hold the gameboard.
        /// </summary>
        public string[,] saBoard;
        /// <summary>
        /// Number of wins for Player 1.
        /// </summary>
        private int iPlayer1Wins;
        /// <summary>
        /// Number of wins for Player 2.
        /// </summary>
        private int iPlayer2Wins;
        /// <summary>
        /// Number of ties.
        /// </summary>
        private int iTies;
        /// <summary>
        /// Let's us know which spaces were the winning move.
        /// </summary>
        private WinningMove eWinningMove;
        /// <summary>
        /// Tells us if Player 1 has won.
        /// </summary>
        public bool bPlayer1Won;

        /// <summary>
        /// Returns which Row, Column, or Diagonal was the winning move.
        /// </summary>
        public WinningMove MyWinningMove
        {
            get { return eWinningMove; }
        }

        /// <summary>
        /// Returns number of wins Player 1 has.
        /// </summary>
        public int IPlayer1Wins
        {
            get { return iPlayer1Wins;  }
        }

        /// <summary>
        /// Returns number of wins Player 2 has.
        /// </summary>
        public int IPlayer2Wins
        {
            get { return iPlayer2Wins; }
        }

        /// <summary>
        /// Returns number of ties.
        /// </summary>
        public int ITies
        {
            get { return iTies; }
        }

        /// <summary>
        /// Enumeration to let us know which spaces were the winning move.
        /// </summary>
        public enum WinningMove
        {
            Row1,
            Row2,
            Row3,
            Col1,
            Col2,
            Col3,
            Diag1,
            Diag2
        }

        /// <summary>
        /// Determines which spaces were the winning move and adds win to appropriate player (or tie)
        /// </summary>
        /// <returns></returns>
        public bool isWinningMove()
        {
            if (saBoard[0, 0] == "X" && saBoard[0, 1] == "X" && saBoard[0, 2] == "X")
            {
                eWinningMove = WinningMove.Row1;
                iPlayer1Wins++;
                bPlayer1Won = true;
                return true;
            }
            else if (saBoard[0, 0] == "O" && saBoard[0, 1] == "O" && saBoard[0, 2] == "O")
            {
                eWinningMove = WinningMove.Row1;
                iPlayer2Wins++;
                return true;
            }
            else if (saBoard[1, 0] == "X" && saBoard[1, 1] == "X" && saBoard[1, 2] == "X")
            {
                eWinningMove = WinningMove.Row2;
                iPlayer1Wins++;
                bPlayer1Won = true;
                return true;
            }
            else if (saBoard[1, 0] == "O" && saBoard[1, 1] == "O" && saBoard[1, 2] == "O")
            {
                eWinningMove = WinningMove.Row2;
                iPlayer2Wins++;
                return true;
            }
            else if (saBoard[2, 0] == "X" && saBoard[2, 1] == "X" && saBoard[2, 2] == "X")
            {
                eWinningMove = WinningMove.Row3;
                iPlayer1Wins++;
                bPlayer1Won = true;
                return true;
            }
            else if (saBoard[2, 0] == "O" && saBoard[2, 1] == "O" && saBoard[2, 2] == "O")
            {
                eWinningMove = WinningMove.Row3;
                iPlayer2Wins++;
                return true;
            }
            else if (saBoard[0, 0] == "X" && saBoard[1, 0] == "X" && saBoard[2, 0] == "X")
            {
                eWinningMove = WinningMove.Col1;
                iPlayer1Wins++;
                bPlayer1Won = true;
                return true;
            }
            else if (saBoard[0, 0] == "O" && saBoard[1, 0] == "O" && saBoard[2, 0] == "O")
            {
                eWinningMove = WinningMove.Col1;
                iPlayer2Wins++;
                return true;
            }
            else if (saBoard[0, 1] == "X" && saBoard[1, 1] == "X" && saBoard[2, 1] == "X")
            {
                eWinningMove = WinningMove.Col2;
                iPlayer1Wins++;
                bPlayer1Won = true;
                return true;
            }
            else if (saBoard[0, 1] == "O" && saBoard[1, 1] == "O" && saBoard[2, 1] == "O")
            {
                eWinningMove = WinningMove.Col2;
                iPlayer2Wins++;
                return true;
            }
            else if (saBoard[0, 2] == "X" && saBoard[1, 2] == "X" && saBoard[2, 2] == "X")
            {
                eWinningMove = WinningMove.Col3;
                iPlayer1Wins++;
                bPlayer1Won = true;
                return true;
            }
            else if (saBoard[0, 2] == "O" && saBoard[1, 2] == "O" && saBoard[2, 2] == "O")
            {
                eWinningMove = WinningMove.Col3;
                iPlayer2Wins++;
                return true;
            }
            else if (saBoard[2, 0] == "X" && saBoard[1, 1] == "X" && saBoard[0, 2] == "X")
            {
                eWinningMove = WinningMove.Diag1;
                iPlayer1Wins++;
                bPlayer1Won = true;
                return true;
            }
            else if (saBoard[2, 0] == "O" && saBoard[1, 1] == "O" && saBoard[0, 2] == "O")
            {
                eWinningMove = WinningMove.Diag1;
                iPlayer2Wins++;
                return true;
            }
            else if (saBoard[2, 2] == "X" && saBoard[1, 1] == "X" && saBoard[0, 0] == "X")
            {
                eWinningMove = WinningMove.Diag2;
                iPlayer1Wins++;
                bPlayer1Won = true;
                return true;
            }
            else if (saBoard[2, 2] == "O" && saBoard[1, 1] == "O" && saBoard[0, 0] == "O")
            {
                eWinningMove = WinningMove.Diag2;
                iPlayer2Wins++;
                return true;
            }
            else
            {
                return false;
            }
        }

       /// <summary>
       /// Determines if a tie has occured in the game.
       /// </summary>
       /// <returns></returns>
        public bool isTie()
        {
            if (saBoard[0, 0] != "" && saBoard[0, 1] != "" && saBoard[0, 2] != ""
                && saBoard[1, 0] != "" && saBoard[1, 1] != "" && saBoard[1, 2] != ""
                && saBoard[2, 0] != "" && saBoard[2, 1] != "" && saBoard[2, 2] != "")
            {
                iTies++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
