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
            this.SecondHand = new System.Windows.Forms.Panel();
            this.ThirdHand = new System.Windows.Forms.Panel();
            this.FourthHand = new System.Windows.Forms.Panel();
            this.Plate = new System.Windows.Forms.Panel();
            this.Fishes = new System.Windows.Forms.Panel();
            this.Bone = new System.Windows.Forms.Panel();
            this.FirstHandPanel = new System.Windows.Forms.Panel();
            this.Table.SuspendLayout();
            this.Plate.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AutoSize = true;
            this.Table.BackColor = System.Drawing.Color.Transparent;
            this.Table.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Table.BackgroundImage")));
            this.Table.ColumnCount = 3;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
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
            // SecondHand
            // 
            this.SecondHand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SecondHand.BackgroundImage")));
            this.SecondHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SecondHand.Location = new System.Drawing.Point(735, 0);
            this.SecondHand.Margin = new System.Windows.Forms.Padding(0);
            this.SecondHand.Name = "SecondHand";
            this.SecondHand.Size = new System.Drawing.Size(236, 194);
            this.SecondHand.TabIndex = 5;
            // 
            // ThirdHand
            // 
            this.ThirdHand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ThirdHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ThirdHand.BackgroundImage")));
            this.ThirdHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ThirdHand.Location = new System.Drawing.Point(3, 399);
            this.ThirdHand.Name = "ThirdHand";
            this.ThirdHand.Size = new System.Drawing.Size(236, 193);
            this.ThirdHand.TabIndex = 3;
            // 
            // FourthHand
            // 
            this.FourthHand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FourthHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FourthHand.BackgroundImage")));
            this.FourthHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.Plate.Location = new System.Drawing.Point(245, 201);
            this.Plate.Name = "Plate";
            this.Plate.Size = new System.Drawing.Size(479, 192);
            this.Plate.TabIndex = 6;
            this.Plate.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Fishes
            // 
            this.Fishes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fishes.BackgroundImage")));
            this.Fishes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fishes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fishes.Location = new System.Drawing.Point(0, 0);
            this.Fishes.Name = "Fishes";
            this.Fishes.Size = new System.Drawing.Size(479, 192);
            this.Fishes.TabIndex = 0;
            // 
            // Bone
            // 
            this.Bone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bone.BackgroundImage")));
            this.Bone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bone.Location = new System.Drawing.Point(0, 0);
            this.Bone.Name = "Bone";
            this.Bone.Size = new System.Drawing.Size(479, 192);
            this.Bone.TabIndex = 1;
            // 
            // FirstHandPanel
            // 
            this.FirstHandPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirstHandPanel.BackgroundImage")));
            this.FirstHandPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FirstHandPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.FirstHandPanel.Location = new System.Drawing.Point(0, 0);
            this.FirstHandPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FirstHandPanel.Name = "FirstHandPanel";
            this.FirstHandPanel.Size = new System.Drawing.Size(236, 198);
            this.FirstHandPanel.TabIndex = 4;
            this.FirstHandPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FirstHandPanel_Paint);
            // 
            // PLAYWITHFRIENDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 595);
            this.Controls.Add(this.Table);
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

