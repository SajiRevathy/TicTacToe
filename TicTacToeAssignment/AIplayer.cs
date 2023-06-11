using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeAssignment
{

    //Computer player class
    public class AIplayer
    {

        //player move while playing with computer
        public void OnePlayerGame(GameBoardForm GameBoardForm, object senderObj)
        {
            var button = (Button)senderObj;
            button.Text = "X";
            GameBoardForm.CheckGameWinner();
            button.Enabled = false;
            GameBoardForm.AItimer.Start();
        }
    }
}
