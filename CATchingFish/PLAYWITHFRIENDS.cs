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
        private int Player1_score = 0; // Score of the player 1
        public PLAYWITHFRIENDS()
        {
            InitializeComponent();

            // Add the timer and set its properties
            panelTimer = new Timer();
            panelTimer.Interval = 1000;

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
            FillFishesInthePlate.Interval = generateRandomNumber();
            FillFishesInthePlate.Tick += DisplayFishesOrBone;
            FillFishesInthePlate.Start();
        }
        protected void DisappearFoodOnPlate()
        {
            NoFishesInthePlate = new Timer();
            NoFishesInthePlate.Interval = generateRandomNumber();
            NoFishesInthePlate.Tick += Disappear;
            NoFishesInthePlate.Start();
        }
        // Check collision between the hand and the food
        protected int CatfishOrBone()
        {
            if (FirstHandPanel.Bounds.IntersectsWith(Fishes.Bounds))
            {
                return 1;
            }    
            else if (FirstHandPanel.Bounds.IntersectsWith(Bone.Bounds))
            {
                return -1;
            }
            return 0;
        }   

        // Event handler when pressing the Q key (First Player)
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Q)
            {
                // Timer event handler - make the panel invisible when the timer ticks
                FirstHandPanel.Visible = false;
                if (FirstHandPanel.Visible == false) FirstLongHand.Visible = true;

/*                // Code duoi la psudocode de mota logic cong/ tru diem
                if (FirstLongHand.Visible && FillFishesInthePlate.Enabled && Fishes.Visible)
                    // Score++
                    DisappearFoodOnPlate();
                if (FirstLongHand.Visible && FillFishesInthePlate.Enabled && !Fishes.Visible)
                    // Score--
                    DisappearFoodOnPlate();*/
                panelTimer.Start();
                return true;
            }

            if (keyData == Keys.E)
            {
                // Timer event handler - make the panel invisible when the timer ticks
                SecondHand.Visible = false;
                if (SecondHand.Visible == false) SecondLongHand.Visible = true;
                panelTimer.Start();
                return true;
            }

            if (keyData == Keys.Z)
            {
                // Timer event handler - make the panel invisible when the timer ticks
                ThirdHand.Visible = false;
                if (ThirdHand.Visible == false) ThirdLongHand.Visible = true;
                panelTimer.Start();
                return true;
            }

            if (keyData == Keys.C)
            {
                // Timer event handler - make the panel invisible when the timer ticks
                FourthHand.Visible = false;
                if (FourthHand.Visible == false) FourthLongHand.Visible = true;
                panelTimer.Start();
                return true;
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Timer event handler
        private void PanelTimer_Tick(object sender, EventArgs e)
        {
            if (CatfishOrBone() == 1)
            {
                // Score++
                Player1_score++;
                Player1Score.Text = Player1_score.ToString();
            }
            else if (CatfishOrBone() == -1)
            {
                // Score--
                Player1_score--;
                Player1Score.Text = Player1_score.ToString();
            }
            else
            {
                // Do nothing
            }
            
            panelTimer.Stop(); // Stop the timer
            HandControl(FirstHandPanel, FirstLongHand);
            HandControl(SecondHand, SecondLongHand);
            HandControl(ThirdHand, ThirdLongHand);
            HandControl(FourthHand, FourthLongHand);
        }

        protected void HandControl(Panel Short_Hand, Panel Long_Hand)
        {
            Short_Hand.Visible = true;
            Long_Hand.Visible = false;
        }
        private void PLAYWITHFRIENDS_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool isFishOnPlate()
        {
            if (Fishes.Visible == true) return true;
            return false;
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
            int num = rnd.Next(0, 2);
            return Food[num];
        }

        private void FirstHandPanel_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
