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
        private Timer FillFishesInthePlate; // Timer to fill the plate with fishes
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

            // auto Display the fishes in the plate after a random time from 2 to 3 seconds

            Bone.Visible = false;
            Fishes.Visible = false;

            FillFishesInthePlate = new Timer();
            FillFishesInthePlate.Interval = generateRandomNumber();
            FillFishesInthePlate.Tick += DisplayFishesOrBone;
            FillFishesInthePlate.Start();

            // auto Disappear the fishes in the plate after a random time from 2 to 3 seconds
            //FillFishesInthePlate = new Timer();
            //FillFishesInthePlate.Interval = generateRandomNumber();
            FillFishesInthePlate.Tick += Disappear;
            //FillFishesInthePlate.Start();


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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayFishesOrBone(object sender, EventArgs e)
        {
            object Food = generateRandomFishesOrBone();
            if (Food == Fishes)
            {
                // set fishes in the front of the plate
                Bone.Visible = false;
                Fishes.Visible = true;
                Fishes.BringToFront();
            }
            else
            {
                Fishes.Visible = false;
                Bone.Visible = true;
                Bone.BringToFront();
            }
            FillFishesInthePlate.Start();
        }

        private void Disappear(object sender, EventArgs e)
        {
            Bone.Visible = false;
            Fishes.Visible = false;
            FillFishesInthePlate.Stop();
        }

        private int generateRandomNumber()
        {
            Random rnd = new Random();
            int num = rnd.Next(1000, 1500);
            return num;
        }

        private object generateRandomFishesOrBone()
        {
            Random rnd = new Random();
            object[] Food = { Fishes ,Bone};
            int num = rnd.Next(0, 2);
            return Food[num];
        }

    }
}
