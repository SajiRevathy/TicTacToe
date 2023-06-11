using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeAssignment
{
    //This class display the symbols on each player move and perform winning check on each move  
    public class HumanPlayer
    {
        //2 player mode
        public void TwoPlayerGame(GameBoardForm GameBoardForm,object senderclickObj)
        {

            string buttontxt = ((Button)senderclickObj).Text;
            int count = (GameBoardForm.count);
            if (buttontxt == "")
            {

                if (count % 2 == 0)
                {
                    ((Button)senderclickObj).Text = "O";
                    ((Button)senderclickObj).Enabled = false;



                }
                else
                {
                    ((Button)senderclickObj).Text = "X";
                    ((Button)senderclickObj).Enabled = false;


                }
                GameBoardForm.CheckGameWinner();

            }
        }
    }
}
