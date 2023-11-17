using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATchingFish
{
    public partial class PLAYWITHFRIENDS : Form
    {
        public PLAYWITHFRIENDS()
        {
            InitializeComponent();

            //click on Button_FH to invisible panel

            Button Button_FH = new Button();
            Button_FH.Click += FirstHandButton_Click;


            Controls.Add(Button_FH);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FirstHandButton_Click(object sender, EventArgs e)
        {
            // panel invisible
            FirstHand.Visible = !FirstHand.Visible;
        }

        private void PLAYWITHFRIENDS_Load(object sender, EventArgs e)
        {

        }

        private void PLAYWITHFRIENDS_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
