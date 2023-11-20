using System;
using System.Windows.Forms;

namespace CATchingFish
{
    public partial class PLAYWITHFRIENDS : Form
    {
        private Timer panelTimer; // Timer to make the panel invisible after 2 seconds
        private Timer FillFishesInthePlate; // Timer to fill the plate with fishes
        private Timer NoFishesInthePlate;
        public PLAYWITHFRIENDS()
        {
            InitializeComponent();

            // Add the timer and set its properties
            panelTimer = new Timer();
            panelTimer.Interval = 1000;

            // Add the event handler for the timer
            panelTimer.Tick += PanelTimer_Tick;

          
            Bone.Visible = false;
            Fishes.Visible = false;

            FillFishesInthePlate = new Timer();
            FillFishesInthePlate.Interval = generateRandomNumber();
            FillFishesInthePlate.Tick += DisplayFishesOrBone;
            FillFishesInthePlate.Start();

            // auto Disappear the fishes in the plate after a random time from 2 to 3 seconds
            NoFishesInthePlate = new Timer();
            NoFishesInthePlate.Interval = generateRandomNumber();
            NoFishesInthePlate.Tick += Disappear;
            NoFishesInthePlate.Start();
        }

      
        // Event handler when pressing the Q key (First Player)
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Q)
            {
                // Timer event handler - make the panel invisible when the timer ticks
                FirstHandPanel.Visible = false;
                panelTimer.Start();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

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
            FillFishesInthePlate.Stop();
            NoFishesInthePlate.Start();
        }

        private void Disappear(object sender, EventArgs e)
        {
            Bone.Visible = false;
            Fishes.Visible = false;
            NoFishesInthePlate.Stop();
            FillFishesInthePlate.Start();
        }

        private int generateRandomNumber()
        {
            Random rnd = new Random();
            int num = rnd.Next(2000, 3500);
            return num;
        }

        private object generateRandomFishesOrBone()
        {
            Random rnd = new Random();
            object[] Food = { Fishes, Bone };
            int num = rnd.Next(0, 2);
            return Food[num];
        }

        private void FirstHandPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
