namespace CATchingFish
{
    partial class PLAYWITHFRIENDS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PLAYWITHFRIENDS));
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.FirstHandPanel = new System.Windows.Forms.Panel();
            this.SecondHand = new System.Windows.Forms.Panel();
            this.ThirdHand = new System.Windows.Forms.Panel();
            this.FourthHand = new System.Windows.Forms.Panel();
            this.Plate = new System.Windows.Forms.Panel();
            this.Bone = new System.Windows.Forms.Panel();
            this.Fishes = new System.Windows.Forms.Panel();
            this.Table.SuspendLayout();
            this.Plate.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AutoSize = true;
            this.Table.BackColor = System.Drawing.Color.Transparent;
            this.Table.ColumnCount = 3;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Table.Controls.Add(this.FirstHandPanel, 0, 0);
            this.Table.Controls.Add(this.SecondHand, 2, 0);
            this.Table.Controls.Add(this.ThirdHand, 0, 2);
            this.Table.Controls.Add(this.FourthHand, 2, 2);
            this.Table.Controls.Add(this.Plate, 1, 1);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 3;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Table.Size = new System.Drawing.Size(971, 595);
            this.Table.TabIndex = 1;
            // 
            // FirstHandPanel
            // 
            this.FirstHandPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirstHandPanel.BackgroundImage")));
            this.FirstHandPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FirstHandPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.FirstHandPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FirstHandPanel.Location = new System.Drawing.Point(0, 0);
            this.FirstHandPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FirstHandPanel.Name = "FirstHandPanel";
            this.FirstHandPanel.Size = new System.Drawing.Size(206, 198);
            this.FirstHandPanel.TabIndex = 4;
            this.FirstHandPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FirstHandPanel_Paint);
            // 
            // SecondHand
            // 
            this.SecondHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SecondHand.BackgroundImage")));
            this.SecondHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SecondHand.Dock = System.Windows.Forms.DockStyle.Right;
            this.SecondHand.Location = new System.Drawing.Point(735, 0);
            this.SecondHand.Margin = new System.Windows.Forms.Padding(0);
            this.SecondHand.Name = "SecondHand";
            this.SecondHand.Size = new System.Drawing.Size(236, 198);
            this.SecondHand.TabIndex = 5;
            // 
            // ThirdHand
            // 
            this.ThirdHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ThirdHand.BackgroundImage")));
            this.ThirdHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ThirdHand.Dock = System.Windows.Forms.DockStyle.Left;
            this.ThirdHand.Location = new System.Drawing.Point(3, 399);
            this.ThirdHand.Name = "ThirdHand";
            this.ThirdHand.Size = new System.Drawing.Size(203, 193);
            this.ThirdHand.TabIndex = 3;
            // 
            // FourthHand
            // 
            this.FourthHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FourthHand.BackgroundImage")));
            this.FourthHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FourthHand.Dock = System.Windows.Forms.DockStyle.Right;
            this.FourthHand.Location = new System.Drawing.Point(730, 399);
            this.FourthHand.Name = "FourthHand";
            this.FourthHand.Size = new System.Drawing.Size(238, 193);
            this.FourthHand.TabIndex = 4;
            // 
            // Plate
            // 
            this.Plate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Plate.BackgroundImage")));
            this.Plate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Plate.Controls.Add(this.Bone);
            this.Plate.Controls.Add(this.Fishes);
            this.Plate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plate.Location = new System.Drawing.Point(391, 201);
            this.Plate.Name = "Plate";
            this.Plate.Size = new System.Drawing.Size(188, 192);
            this.Plate.TabIndex = 6;
            this.Plate.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Bone
            // 
            this.Bone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bone.BackgroundImage")));
            this.Bone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bone.Location = new System.Drawing.Point(0, 0);
            this.Bone.Name = "Bone";
            this.Bone.Size = new System.Drawing.Size(188, 192);
            this.Bone.TabIndex = 1;
            // 
            // Fishes
            // 
            this.Fishes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fishes.BackgroundImage")));
            this.Fishes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fishes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fishes.Location = new System.Drawing.Point(0, 0);
            this.Fishes.Name = "Fishes";
            this.Fishes.Size = new System.Drawing.Size(188, 192);
            this.Fishes.TabIndex = 0;
            // 
            // PLAYWITHFRIENDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(971, 595);
            this.Controls.Add(this.Table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PLAYWITHFRIENDS";
            this.Text = "PLAY WITH FRIENDS";
            this.Load += new System.EventHandler(this.PLAYWITHFRIENDS_Load);
            this.Table.ResumeLayout(false);
            this.Plate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Panel ThirdHand;
        private System.Windows.Forms.Panel FourthHand;
        private System.Windows.Forms.Panel SecondHand;
        private System.Windows.Forms.Panel Plate;
        private System.Windows.Forms.Panel Fishes;
        private System.Windows.Forms.Panel Bone;
        private System.Windows.Forms.Panel FirstHandPanel;
    }
}

