using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeAssignment
{
    public partial class Form2 : Form
    {
        // global variable to check the game mode is one player or two players
        public static string formFlag;
        public Form2()
        {
            InitializeComponent();
        }

        //Move to one player mode
        private void OnePlayerButton_Click(object sender, EventArgs e)
        {
              formFlag = "computer"; // play with computer
              StartForm form3 = new StartForm();
              form3.ShowDialog();
        }

        //Move to two player mode
        private void TwoPlayerButton_Click(object sender, EventArgs e)
        {
            formFlag = "humans"; // play with other person
            StartForm form3 = new StartForm();
            form3.ShowDialog();
        }
    }
}
