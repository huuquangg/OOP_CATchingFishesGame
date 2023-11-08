namespace CATchingFish
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ContainerBTN = new System.Windows.Forms.Panel();
            this.PAYWITHTEAM_btn = new System.Windows.Forms.Button();
            this.PLAYWITHFR_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.ContainerBTN.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ContainerBTN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 650);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ContainerBTN
            // 
            this.ContainerBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainerBTN.AutoSize = true;
            this.ContainerBTN.BackColor = System.Drawing.Color.Transparent;
            this.ContainerBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContainerBTN.Controls.Add(this.PAYWITHTEAM_btn);
            this.ContainerBTN.Controls.Add(this.PLAYWITHFR_btn);
            this.ContainerBTN.Location = new System.Drawing.Point(247, 435);
            this.ContainerBTN.Name = "ContainerBTN";
            this.ContainerBTN.Size = new System.Drawing.Size(483, 212);
            this.ContainerBTN.TabIndex = 2;
            this.ContainerBTN.Paint += new System.Windows.Forms.PaintEventHandler(this.ContainerBTN_Paint);
            // 
            // PAYWITHTEAM_btn
            // 
            this.PAYWITHTEAM_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PAYWITHTEAM_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.PAYWITHTEAM_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PAYWITHTEAM_btn.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAYWITHTEAM_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PAYWITHTEAM_btn.Location = new System.Drawing.Point(72, 111);
            this.PAYWITHTEAM_btn.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.PAYWITHTEAM_btn.Name = "PAYWITHTEAM_btn";
            this.PAYWITHTEAM_btn.Size = new System.Drawing.Size(344, 51);
            this.PAYWITHTEAM_btn.TabIndex = 2;
            this.PAYWITHTEAM_btn.Text = "PLAY WITH TEAM";
            this.PAYWITHTEAM_btn.UseVisualStyleBackColor = false;
            this.PAYWITHTEAM_btn.Click += new System.EventHandler(this.PAYWITHTEAM_btn_Click);
            // 
            // PLAYWITHFR_btn
            // 
            this.PLAYWITHFR_btn.AllowDrop = true;
            this.PLAYWITHFR_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PLAYWITHFR_btn.AutoEllipsis = true;
            this.PLAYWITHFR_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.PLAYWITHFR_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PLAYWITHFR_btn.FlatAppearance.BorderSize = 20;
            this.PLAYWITHFR_btn.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAYWITHFR_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PLAYWITHFR_btn.Location = new System.Drawing.Point(72, 30);
            this.PLAYWITHFR_btn.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.PLAYWITHFR_btn.Name = "PLAYWITHFR_btn";
            this.PLAYWITHFR_btn.Size = new System.Drawing.Size(344, 57);
            this.PLAYWITHFR_btn.TabIndex = 1;
            this.PLAYWITHFR_btn.Text = "PLAY WITH FRIENDS";
            this.PLAYWITHFR_btn.UseVisualStyleBackColor = false;
            this.PLAYWITHFR_btn.Click += new System.EventHandler(this.PLAYWITHFR_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(3, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 212);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(736, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 212);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(247, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 210);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATCHING FISHES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 644);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ContainerBTN.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button PLAYWITHFR_btn;
        private System.Windows.Forms.Panel ContainerBTN;
        private System.Windows.Forms.Button PAYWITHTEAM_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}