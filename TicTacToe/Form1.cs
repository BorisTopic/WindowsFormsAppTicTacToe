using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    public partial class TicTacToeForm : Form
    {
        /// <summary>
        /// Handles the "business" logic of playing Tic Tac Toe.
        /// </summary>
        clsTicTacToe clsTicTac;
        /// <summary>
        /// Tells us if the game has started.
        /// </summary>
        bool bIsGameStarted;
        public TicTacToeForm()
        {
            InitializeComponent();

            clsTicTac = new clsTicTacToe();
            clsTicTac.saBoard = new String[3,3];
            bIsGameStarted = false;
            gameStatusLabel.Text = "Player 1 Turn";
        }

        /// <summary>
        /// Begins a new game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startGameButton_Click(object sender, EventArgs e)
        {
            bIsGameStarted = true;
            ClearLabels();
            ResetColors();
            ResetArray();
            clsTicTac.bPlayer1Won = false;
        }

        /// <summary>
        /// Handles all of the logic for when a space is clicked on the gameboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Space_Click(object sender, EventArgs e)
        {
            if (bIsGameStarted == true)
            {

                Label MyLabel = (Label)sender;

                if (gameStatusLabel.Text == "Player 1 Turn" && MyLabel.Text == "")
                {
                    MyLabel.Text = "X";
                    LoadBoard(MyLabel);
                    gameStatusLabel.Text = "Player 2 Turn";
                }
                else if (gameStatusLabel.Text == "Player 2 Turn" && MyLabel.Text == "")
                {
                    MyLabel.Text = "O";
                    LoadBoard(MyLabel);
                    gameStatusLabel.Text = "Player 1 Turn";
                }

                if (clsTicTac.isWinningMove() == true)
                {
                    if (clsTicTac.bPlayer1Won == true)
                    {
                        gameStatusLabel.Text = "Player 1 Wins!";
                    }
                    else
                    {
                        gameStatusLabel.Text = "Player 2 Wins!";
                    }
                    HighlightWinningMove();
                    UpdateScores();
                    bIsGameStarted = false;
                }
                else if (clsTicTac.isTie() == true)
                {
                    gameStatusLabel.Text = "It's a tie!";
                    UpdateScores();
                    bIsGameStarted = false;
                }

                //1. bIsGameStarted check to see if the game has started
                //2. Check to see if space is blank
                //3. LoadBoard() load our gameboard
                //4. clsTicTac.IsWinningMove()
                //5. HighlightWinningMove() and UpdateScores()
                //6. clsTicTac.IsTie()
                //7. UpdateScores()
            }
        }

        /// <summary>
        /// Method to clear and reset the gameboard's text.
        /// </summary>
        private void ClearLabels()
        {
            label00.Text = "";
            label01.Text = "";
            label02.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            gameStatusLabel.Text = "Player 1 Turn";
        }

        /// <summary>
        /// Method to reset the highlighted spaces on the gameboard.
        /// </summary>
        private void ResetColors()
        {
            label00.BackColor = Color.Transparent;
            label01.BackColor = Color.Transparent;
            label02.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label20.BackColor = Color.Transparent;
            label21.BackColor = Color.Transparent;
            label22.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Method to load the gameboard into clsTicTacToe.
        /// </summary>
        /// <param name="MyLabel"></param>
        private void LoadBoard(Label MyLabel)
        {
            int tag = Convert.ToInt32(MyLabel.Tag);
            switch (tag)
            {
                case 1: clsTicTac.saBoard[0, 0] = MyLabel.Text; break;
                case 2: clsTicTac.saBoard[0, 1] = MyLabel.Text; break;
                case 3: clsTicTac.saBoard[0, 2] = MyLabel.Text; break;
                case 4: clsTicTac.saBoard[1, 0] = MyLabel.Text; break;
                case 5: clsTicTac.saBoard[1, 1] = MyLabel.Text; break;
                case 6: clsTicTac.saBoard[1, 2] = MyLabel.Text; break;
                case 7: clsTicTac.saBoard[2, 0] = MyLabel.Text; break;
                case 8: clsTicTac.saBoard[2, 1] = MyLabel.Text; break;
                case 9: clsTicTac.saBoard[2, 2] = MyLabel.Text; break;
            }
        }

        /// <summary>
        /// Method to reset the gameboard array in clsTicTacToe.
        /// </summary>
        private void ResetArray()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    clsTicTac.saBoard[i, j] = "";
                }
            }
        }

       /// <summary>
       /// Highlights the spaces of the winning move.
       /// </summary>
        private void HighlightWinningMove()
        {
            if (clsTicTac.MyWinningMove == clsTicTacToe.WinningMove.Row1)
            {
                label00.BackColor = Color.Yellow;
                label01.BackColor = Color.Yellow;
                label02.BackColor = Color.Yellow;
            }
            else if (clsTicTac.MyWinningMove == clsTicTacToe.WinningMove.Row2)
            {
                label10.BackColor = Color.Yellow;
                label11.BackColor = Color.Yellow;
                label12.BackColor = Color.Yellow;
            }
            else if (clsTicTac.MyWinningMove == clsTicTacToe.WinningMove.Row3)
            {
                label20.BackColor = Color.Yellow;
                label21.BackColor = Color.Yellow;
                label22.BackColor = Color.Yellow;
            }
            else if (clsTicTac.MyWinningMove == clsTicTacToe.WinningMove.Col1)
            {
                label00.BackColor = Color.Yellow;
                label10.BackColor = Color.Yellow;
                label20.BackColor = Color.Yellow;
            }
            else if (clsTicTac.MyWinningMove == clsTicTacToe.WinningMove.Col2)
            {
                label01.BackColor = Color.Yellow;
                label11.BackColor = Color.Yellow;
                label21.BackColor = Color.Yellow;
            }
            else if (clsTicTac.MyWinningMove == clsTicTacToe.WinningMove.Col3)
            {
                label02.BackColor = Color.Yellow;
                label12.BackColor = Color.Yellow;
                label22.BackColor = Color.Yellow;
            }
            else if (clsTicTac.MyWinningMove == clsTicTacToe.WinningMove.Diag1)
            {
                label20.BackColor = Color.Yellow;
                label11.BackColor = Color.Yellow;
                label02.BackColor = Color.Yellow;
            }
            else if (clsTicTac.MyWinningMove == clsTicTacToe.WinningMove.Diag2)
            {
                label22.BackColor = Color.Yellow;
                label11.BackColor = Color.Yellow;
                label00.BackColor = Color.Yellow;
            }
        }
        
        /// <summary>
        /// Updates the scores for Player 1, Player 2, and Tie.
        /// </summary>
        private void UpdateScores()
        {
            player1WinsCountLabel.Text = clsTicTac.IPlayer1Wins.ToString();
            player2WinsCountLabel.Text = clsTicTac.IPlayer2Wins.ToString();
            tiesCountLabel.Text = clsTicTac.ITies.ToString();
        }  
    }
}
