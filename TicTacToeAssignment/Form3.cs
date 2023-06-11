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
    public partial class StartForm : Form
    {

        //variables to store the names of the players
        private static string playerName1;
        private static string playerName2;
        public string PlayerName1
        {
            get { return playerName1; }
            set { playerName1 = value; }
        }
        public string PlayerName2
        {
            get { return playerName2; }
            set { playerName2 = value; }
        }
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            string value = Form2.formFlag;
            if (value == "computer")
            {
                Xlabel.Text = "Player Name";
                Olabel.Text = string.Empty;
                playerTextBox2.Text = "Computer";
                playerTextBox2.Enabled= false;
            }
            else
            {
                Xlabel.Text = "Player1 Name";
                Olabel.Text = "Player2 Name";

            }
        }
        private void StartGameButtonClick(object sender, EventArgs e)
        {
              PlayerName1 = playerTextBox1.Text;
              PlayerName2 = playerTextBox2.Text;
              if (PlayerName1 != "" && PlayerName2 != "")
              {
                GameBoardForm form4 = new GameBoardForm(); //Gaming board form class object
                form4.ShowDialog();
              }
              else
              {
                MessageBox.Show("Please enter the players name"); //shows alert box on empty players textbox.
              }
        }

    }
}
