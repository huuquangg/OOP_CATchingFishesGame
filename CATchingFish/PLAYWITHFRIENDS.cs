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

            // Add the timer and set its properties
            panelTimer = new Timer();
            panelTimer.Interval = 1000;

            // Add the event handler for the button (Optional)
            // FirstHandButton.Click += FirstHandButton_Click;

            // Add the event handler for the timer
            panelTimer.Tick += PanelTimer_Tick;

            // Add the event handler when pressing the Q key (First Player)
            this.KeyPress += q_pressed_event;
            this.KeyPreview = true;
        }

        // Event handler when pressing the Q key (First Player)
        private void q_pressed_event(object sender, KeyPressEventArgs e)
        {
            if (Char.ToLower(e.KeyChar) == 'q')
            {
                // Timer event handler - make the panel invisible when the timer ticks
                FirstHandPanel.Visible = false;
                panelTimer.Start();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

/*       Event handler for the button (Optional)
         private void FirstHandButton_Click(object sender, EventArgs e) // FirstHandButton click event handler
         {
         // Timer event handler - make the panel invisible when the timer ticks
         FirstHandPanel.Visible = !FirstHandPanel.Visible;
         panelTimer.Start();
         }
*/
        // Timer event handler
        private void PanelTimer_Tick(object sender, EventArgs e) 
        {
            panelTimer.Stop(); // Stop the timer
            FirstHandPanel.Visible = true;
        }

        private void PLAYWITHFRIENDS_Load(object sender, EventArgs e)
        {

        }

        private void PLAYWITHFRIENDS_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
