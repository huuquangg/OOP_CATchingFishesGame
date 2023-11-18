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
        private Timer panelTimer; // Timer to make the panel invisible after 2 seconds
        public PLAYWITHFRIENDS()
        {
            InitializeComponent();

            panelTimer = new Timer();
            panelTimer.Interval = 1000;
            FirstHandButton.Click += FirstHandButton_Click;
            panelTimer.Tick += PanelTimer_Tick;
             
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FirstHandButton_Click(object sender, EventArgs e)
        {
            // Timer event handler - make the panel invisible when the timer ticks
            FirstHandPanel.Visible = !FirstHandPanel.Visible;
            panelTimer.Start();
        }
        private void PanelTimer_Tick(object sender, EventArgs e)
        {
            panelTimer.Stop(); // Stop the timer
            FirstHandPanel.Visible = !FirstHandPanel.Visible;
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
