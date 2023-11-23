using System;
using System.Media;
using System.Windows.Forms;

namespace CATchingFish
{
    public partial class PLAYWITHFRIENDS : Form
    {
        private Timer panelTimer; // Timer to make the panel invisible after 2 seconds
        private Timer FillFishesInthePlate; // Timer to fill the plate with fishes
        private Timer NoFishesInthePlate; // Timer to make the fishes disappear from the plate

        private static int Player1_score = 0; // Score of the player 1
        private static int Player2_score = 0; // Score of the player 2
        private static int Player3_score = 0; // Score of the player 3
        private static int Player4_score = 0; // Score of the player 4

        public PLAYWITHFRIENDS()
        {
            InitializeComponent();

            // Add the timer and set its properties
            panelTimer = new Timer();
            panelTimer.Interval = 300;

            // Add the event handler for the timer
            panelTimer.Tick += PanelTimer_Tick;

            // Play background music
            LoopMusic();

            FirstLongHand.Visible = false;
            SecondLongHand.Visible = false;
            ThirdLongHand.Visible = false;
            FourthLongHand.Visible = false;
            Bone.Visible = false;
            Fishes.Visible = false;


            FillFoodOnPlate();

            // auto Disappear the fishes in the plate after a random time from 2 to 3 seconds
            DisappearFoodOnPlate();

            // check if the player has 3 fishes, then he/she wins and show the winner message and stop the game
        }
        // Play background music
        private void LoopMusic()
        {
            string musicFilePath = Application.StartupPath + "\\BGMusic.wav";
            SoundPlayer BGMusic = new SoundPlayer(musicFilePath);
            BGMusic.PlayLooping();
        }
        protected void FillFoodOnPlate()
        {
            FillFishesInthePlate = new Timer();
            FillFishesInthePlate.Interval = generateRandomNumber(); // generate a random number from 2 to 3 seconds
            FillFishesInthePlate.Tick += DisplayFishesOrBone; // event handler
            FillFishesInthePlate.Start();// start the timer
        }
        protected void DisappearFoodOnPlate()
        {
            NoFishesInthePlate = new Timer();
            NoFishesInthePlate.Interval = generateRandomNumber();
            NoFishesInthePlate.Tick += Disappear;
            NoFishesInthePlate.Start();
        }

        // check if the player has 3 fishes, then he/she wins and show the winner message and stop the game


        // Event handler when pressing the Q key (First Player)
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Q)
            {
                // Timer event handler - make the panel invisible when the timer ticks
                FirstHandPanel.Visible = false;
                FirstLongHand.Visible = true;

                ScoreControl(ref Player1_score, Player1Score);

                panelTimer.Start();
                return true;
            }

            if (keyData == Keys.E)
            {
                // Timer event handler - make the panel invisible when the timer ticks
                SecondHand.Visible = false;
                SecondLongHand.Visible = true;

                ScoreControl(ref Player2_score, Player2Score);

                panelTimer.Start();
                return true;
            }

            if (keyData == Keys.Z)
            {
                // Timer event handler - make the panel invisible when the timer ticks
                ThirdHand.Visible = false;
                ThirdLongHand.Visible = true;

                ScoreControl(ref Player3_score, Player3Score);

                panelTimer.Start();
                return true;
            }

            if (keyData == Keys.C)
            {
                // Timer event handler - make the panel invisible when the timer ticks
                FourthHand.Visible = false;
                FourthLongHand.Visible = true;

                ScoreControl(ref Player4_score, Player4Score);

                panelTimer.Start();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                DialogResult result;
                result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Close();
                }
                return false;
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Timer event handler
        private void PanelTimer_Tick(object sender, EventArgs e)
        {

            panelTimer.Stop(); // Stop the timer
            HandControl(FirstHandPanel, FirstLongHand);
            HandControl(SecondHand, SecondLongHand);
            HandControl(ThirdHand, ThirdLongHand);
            HandControl(FourthHand, FourthLongHand);
        }

        protected void ScoreControl(ref int PlayerGOTFish, Button ScoreBoard)
        {
            // Check FillFishesInThePlate timer is running or DisappearFoodOnPlate timer is running
            // If FillFishesInThePlate timer is running, then score++
            // If DisappearFoodOnPlate timer is running, then score--
            if (!FillFishesInthePlate.Enabled && Fishes.Visible)
            {
                // Score++
                PlayerGOTFish++;
                ScoreBoard.Text = PlayerGOTFish.ToString();

                // Start the timer to fill the plate with fishes again
                FillFishesInthePlate.Start();
                Fishes.Visible = false;
            }
            else if (!FillFishesInthePlate.Enabled && !Fishes.Visible)
            {
                // Score--
                PlayerGOTFish--;
                if (PlayerGOTFish < 0) ScoreBoard.Text = "-" + (Math.Abs(PlayerGOTFish).ToString());
                else ScoreBoard.Text = PlayerGOTFish.ToString();
                FillFishesInthePlate.Start();
                Bone.Visible = false;
            }
            else
            {
                // Do nothing
            }

        }
        protected void HandControl(Panel Short_Hand, Panel Long_Hand)
        {
            Short_Hand.Visible = true;
            Long_Hand.Visible = false;

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

        public void Disappear(object sender, EventArgs e)
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
            int num = rnd.Next(Food.Length);
            return Food[num];
        }

    }
}
