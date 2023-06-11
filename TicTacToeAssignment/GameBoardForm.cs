using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TicTacToeAssignment
{
    //class checks the stages of the game and the winning conditions
    public partial class GameBoardForm : Form
    {
        int Player1WinCount = 0; // store the win count of player1
        int Player2WinCount = 0; // store the win count of player2
        public int count = 0;
        List<Button> buttons;

    
        public GameBoardForm()
        {
            InitializeComponent();
        }

        private void GameBoardForm_Load(object sender, EventArgs e)
        {
            string value = Form2.formFlag;
            StartForm formobj = new StartForm();
            if (value == "computer")
            {
                Firstlabel.Text = formobj.PlayerName1;
            }
            else
            {
                Firstlabel.Text = formobj.PlayerName1;
                label3.Text = formobj.PlayerName2;

            }
        }

        public void ClickButton(object sender, EventArgs e)
        {
            string value = Form2.formFlag; 

            if (value == "humans")
            {
                count++;
                HumanPlayer playerobj = new HumanPlayer();
                playerobj.TwoPlayerGame(this, sender);
            }
            else
            {
                AIplayer aiPlayerobj = new AIplayer();
                aiPlayerobj.OnePlayerGame(this, sender);

            }
        }
       
        // for finding the winner of the game
        public void CheckGameWinner()
        {
            bool flag = false;
            StartForm formobj = new StartForm();
            
            if (GameButton1.Text == "X" && GameButton2.Text == "X" && GameButton3.Text == "X"
                || GameButton4.Text == "X" && GameButton5.Text == "X" && GameButton6.Text == "X"
                || GameButton7.Text == "X" && GameButton8.Text == "X" && GameButton9.Text == "X"
                || GameButton1.Text == "X" && GameButton4.Text == "X" && GameButton7.Text == "X"
                || GameButton2.Text == "X" && GameButton5.Text == "X" && GameButton8.Text == "X"
                || GameButton3.Text == "X" && GameButton6.Text == "X" && GameButton9.Text == "X"
                || GameButton1.Text == "X" && GameButton5.Text == "X" && GameButton9.Text == "X"
                || GameButton3.Text == "X" && GameButton5.Text == "X" && GameButton7.Text == "X")
            {
                
                AItimer.Stop();
                MessageBox.Show(formobj.PlayerName1 + " wins the game");

                flag = true;
                Player1WinCount++;
                Secondlabel.Text = Player1WinCount + " Wins";


                RestartGame();

            }
            else if (GameButton1.Text == "O" && GameButton2.Text == "O" && GameButton3.Text == "O"
               || GameButton4.Text == "O" && GameButton5.Text == "O" && GameButton6.Text == "O"
               || GameButton7.Text == "O" && GameButton8.Text == "O" && GameButton9.Text == "O"
               || GameButton1.Text == "O" && GameButton4.Text == "O" && GameButton7.Text == "O"
               || GameButton2.Text == "O" && GameButton5.Text == "O" && GameButton8.Text == "O"
               || GameButton3.Text == "O" && GameButton6.Text == "O" && GameButton9.Text == "O"
               || GameButton1.Text == "O" && GameButton5.Text == "O" && GameButton9.Text == "O"
               || GameButton3.Text == "O" && GameButton5.Text == "O" && GameButton7.Text == "O")
            {
                AItimer.Stop();
                
                MessageBox.Show(formobj.PlayerName2 + " wins the game");

                flag = true;
                Player2WinCount++;
                label2.Text = Player2WinCount + " Wins";
                RestartGame();
            }
            else if (flag == false && GameButton1.Text != "" && GameButton2.Text != ""
                && GameButton3.Text != "" && GameButton4.Text != "" && GameButton5.Text != ""
                && GameButton6.Text != "" && GameButton7.Text != "" && GameButton8.Text != ""
                && GameButton9.Text != "")
            {
                AItimer.Stop();
                MessageBox.Show("Draw");
                RestartGame();
            }

        }
        private void RestartGame()
        {

            buttons = new List<Button> { GameButton1, GameButton2, GameButton3, GameButton4, GameButton5, GameButton6, GameButton7, GameButton8, GameButton9 };
            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Text = "";


            }
            count = 0;
        }
        // restart button event 
        private void RestartButtonClick(object sender, EventArgs e)
        {
            RestartGame();
        }
       
        //Computer moves while playing player vs computer mode
        private void AIclickEvent(object sender, EventArgs e)
        {
            Button move = null;
            move = Check_BlockWin_Chance("O");
            if (move == null)
            {
                move = Check_BlockWin_Chance("X");
                if (move == null)
                {
                    move = Check_FreeSpace();

                }

            }
            performAction(move);

        }

        public void performAction(Button move)
        {
            if(move == null)
            {
                CheckGameWinner();
                AItimer.Stop();
            }
            else 
            {
                move.Text = "O";
                move.Enabled = false;
                CheckGameWinner();
                AItimer.Stop();
            }
            
        }
        // check if there is any winning or blocking condition
        private Button Check_BlockWin_Chance(string chance)
        {
            //Checking in the rows
            if ((GameButton1.Text == chance) && (GameButton2.Text == chance) && (GameButton3.Text == ""))
                return GameButton3;
            if ((GameButton2.Text == chance) && (GameButton3.Text == chance) && (GameButton1.Text == ""))
                return GameButton1;
            if ((GameButton1.Text == chance) && (GameButton3.Text == chance) && (GameButton2.Text == ""))
                return GameButton2;

            if ((GameButton4.Text == chance) && (GameButton5.Text == chance) && (GameButton6.Text == ""))
                return GameButton6;
            if ((GameButton5.Text == chance) && (GameButton6.Text == chance) && (GameButton4.Text == ""))
                return GameButton4;
            if ((GameButton4.Text == chance) && (GameButton6.Text == chance) && (GameButton5.Text == ""))
                return GameButton5;

            if ((GameButton7.Text == chance) && (GameButton8.Text == chance) && (GameButton9.Text == ""))
                return GameButton9;
            if ((GameButton8.Text == chance) && (GameButton9.Text == chance) && (GameButton7.Text == ""))
                return GameButton7;
            if ((GameButton7.Text == chance) && (GameButton9.Text == chance) && (GameButton8.Text == ""))
                return GameButton8;

            //Checking in the columns
            if ((GameButton1.Text == chance) && (GameButton4.Text == chance) && (GameButton7.Text == ""))
                return GameButton7;
            if ((GameButton4.Text == chance) && (GameButton7.Text == chance) && (GameButton1.Text == ""))
                return GameButton1;
            if ((GameButton1.Text == chance) && (GameButton7.Text == chance) && (GameButton4.Text == ""))
                return GameButton4;

            if ((GameButton2.Text == chance) && (GameButton5.Text == chance) && (GameButton8.Text == ""))
                return GameButton8;
            if ((GameButton5.Text == chance) && (GameButton8.Text == chance) && (GameButton2.Text == ""))
                return GameButton2;
            if ((GameButton2.Text == chance) && (GameButton8.Text == chance) && (GameButton5.Text == ""))
                return GameButton5;

            if ((GameButton3.Text == chance) && (GameButton6.Text == chance) && (GameButton9.Text == ""))
                return GameButton9;
            if ((GameButton6.Text == chance) && (GameButton9.Text == chance) && (GameButton3.Text == ""))
                return GameButton3;
            if ((GameButton3.Text == chance) && (GameButton9.Text == chance) && (GameButton6.Text == ""))
                return GameButton6;

            //Checking in the diagonals
            if ((GameButton1.Text == chance) && (GameButton5.Text == chance) && (GameButton9.Text == ""))
                return GameButton9;
            if ((GameButton5.Text == chance) && (GameButton9.Text == chance) && (GameButton1.Text == ""))
                return GameButton1;
            if ((GameButton1.Text == chance) && (GameButton9.Text == chance) && (GameButton5.Text == ""))
                return GameButton5;

            if ((GameButton3.Text == chance) && (GameButton5.Text == chance) && (GameButton7.Text == ""))
                return GameButton7;
            if ((GameButton5.Text == chance) && (GameButton7.Text == chance) && (GameButton3.Text == ""))
                return GameButton3;
            if ((GameButton3.Text == chance) && (GameButton7.Text == chance) && (GameButton5.Text == ""))
                return GameButton5;
            return null;
        }
       
        private Button Check_FreeSpace()
        {
            Button move = null;
            move = Check_MiddleSpace();
            if (move == null)
            {
                move = Check_CornerSpace();
                if (move == null)
                {
                    move = Check_SquaresSpace();
                }
            }
            return move;

        }
        
        // find the free middle position
        private Button Check_MiddleSpace()
        {
            if (GameButton5.Text == "")
            {
                return GameButton5;
            }
            return null;
        }
       
        //find the free corner position
        private Button Check_CornerSpace()
        {
            if (GameButton1.Text == "")
                return GameButton1;
            if (GameButton3.Text == "")
                return GameButton3;
            if (GameButton7.Text == "")
                return GameButton7;
            if (GameButton9.Text == "")
                return GameButton9;
            return null;
        }
         
        //find the free square positions
        private Button Check_SquaresSpace()
        {
            if (GameButton2.Text == "")
                return GameButton2;
            if (GameButton4.Text == "")
                return GameButton4;
            if (GameButton6.Text == "")
                return GameButton6;
            if (GameButton8.Text == "")
                return GameButton8;
            return null;
        }


    }

}
