namespace Assignment_3_Cards
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Dealbutton = new System.Windows.Forms.Button();
            this.SaveHandbutton = new System.Windows.Forms.Button();
            this.LoadHandbutton = new System.Windows.Forms.Button();
            this.Keep1checkBox = new System.Windows.Forms.CheckBox();
            this.Keep2checkBox = new System.Windows.Forms.CheckBox();
            this.Keep3checkBox = new System.Windows.Forms.CheckBox();
            this.Keep4checkBox = new System.Windows.Forms.CheckBox();
            this.Keep5checkBox = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Card1pictureBox = new System.Windows.Forms.PictureBox();
            this.Card2pictureBox = new System.Windows.Forms.PictureBox();
            this.Card3pictureBox = new System.Windows.Forms.PictureBox();
            this.Card4pictureBox = new System.Windows.Forms.PictureBox();
            this.Card5pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Card1pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Dealbutton
            // 
            this.Dealbutton.Location = new System.Drawing.Point(28, 45);
            this.Dealbutton.Name = "Dealbutton";
            this.Dealbutton.Size = new System.Drawing.Size(133, 64);
            this.Dealbutton.TabIndex = 0;
            this.Dealbutton.Text = "&Deal";
            this.Dealbutton.UseVisualStyleBackColor = true;
            this.Dealbutton.Click += new System.EventHandler(this.Dealbutton_Click);
            // 
            // SaveHandbutton
            // 
            this.SaveHandbutton.Location = new System.Drawing.Point(476, 45);
            this.SaveHandbutton.Name = "SaveHandbutton";
            this.SaveHandbutton.Size = new System.Drawing.Size(133, 64);
            this.SaveHandbutton.TabIndex = 6;
            this.SaveHandbutton.Text = "&Save Hand";
            this.SaveHandbutton.UseVisualStyleBackColor = true;
            this.SaveHandbutton.Click += new System.EventHandler(this.SaveHandbutton_Click);
            // 
            // LoadHandbutton
            // 
            this.LoadHandbutton.Location = new System.Drawing.Point(630, 45);
            this.LoadHandbutton.Name = "LoadHandbutton";
            this.LoadHandbutton.Size = new System.Drawing.Size(133, 64);
            this.LoadHandbutton.TabIndex = 7;
            this.LoadHandbutton.Text = "&Load Hand";
            this.LoadHandbutton.UseVisualStyleBackColor = true;
            this.LoadHandbutton.Click += new System.EventHandler(this.LoadHandbutton_Click);
            // 
            // Keep1checkBox
            // 
            this.Keep1checkBox.AutoSize = true;
            this.Keep1checkBox.Location = new System.Drawing.Point(14, 153);
            this.Keep1checkBox.Name = "Keep1checkBox";
            this.Keep1checkBox.Size = new System.Drawing.Size(60, 17);
            this.Keep1checkBox.TabIndex = 1;
            this.Keep1checkBox.Text = "Keep 1";
            this.Keep1checkBox.UseVisualStyleBackColor = true;
            // 
            // Keep2checkBox
            // 
            this.Keep2checkBox.AutoSize = true;
            this.Keep2checkBox.Location = new System.Drawing.Point(176, 153);
            this.Keep2checkBox.Name = "Keep2checkBox";
            this.Keep2checkBox.Size = new System.Drawing.Size(60, 17);
            this.Keep2checkBox.TabIndex = 2;
            this.Keep2checkBox.Text = "Keep 2";
            this.Keep2checkBox.UseVisualStyleBackColor = true;
            // 
            // Keep3checkBox
            // 
            this.Keep3checkBox.AutoSize = true;
            this.Keep3checkBox.Location = new System.Drawing.Point(344, 153);
            this.Keep3checkBox.Name = "Keep3checkBox";
            this.Keep3checkBox.Size = new System.Drawing.Size(60, 17);
            this.Keep3checkBox.TabIndex = 2;
            this.Keep3checkBox.Text = "Keep 3";
            this.Keep3checkBox.UseVisualStyleBackColor = true;
            // 
            // Keep4checkBox
            // 
            this.Keep4checkBox.AutoSize = true;
            this.Keep4checkBox.Location = new System.Drawing.Point(509, 153);
            this.Keep4checkBox.Name = "Keep4checkBox";
            this.Keep4checkBox.Size = new System.Drawing.Size(60, 17);
            this.Keep4checkBox.TabIndex = 4;
            this.Keep4checkBox.Text = "Keep 4";
            this.Keep4checkBox.UseVisualStyleBackColor = true;
            // 
            // Keep5checkBox
            // 
            this.Keep5checkBox.AutoSize = true;
            this.Keep5checkBox.Location = new System.Drawing.Point(663, 153);
            this.Keep5checkBox.Name = "Keep5checkBox";
            this.Keep5checkBox.Size = new System.Drawing.Size(60, 17);
            this.Keep5checkBox.TabIndex = 5;
            this.Keep5checkBox.Text = "Keep 5";
            this.Keep5checkBox.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "p0.png");
            this.imageList1.Images.SetKeyName(1, "p1.png");
            this.imageList1.Images.SetKeyName(2, "p2.png");
            this.imageList1.Images.SetKeyName(3, "p3.png");
            this.imageList1.Images.SetKeyName(4, "p4.png");
            this.imageList1.Images.SetKeyName(5, "p5.png");
            this.imageList1.Images.SetKeyName(6, "p6.png");
            this.imageList1.Images.SetKeyName(7, "p7.png");
            this.imageList1.Images.SetKeyName(8, "p8.png");
            this.imageList1.Images.SetKeyName(9, "p9.png");
            this.imageList1.Images.SetKeyName(10, "p10.png");
            this.imageList1.Images.SetKeyName(11, "p11.png");
            this.imageList1.Images.SetKeyName(12, "p12.png");
            this.imageList1.Images.SetKeyName(13, "p13.png");
            this.imageList1.Images.SetKeyName(14, "p14.png");
            this.imageList1.Images.SetKeyName(15, "p15.png");
            this.imageList1.Images.SetKeyName(16, "p16.png");
            this.imageList1.Images.SetKeyName(17, "p17.png");
            this.imageList1.Images.SetKeyName(18, "p18.png");
            this.imageList1.Images.SetKeyName(19, "p19.png");
            this.imageList1.Images.SetKeyName(20, "p20.png");
            this.imageList1.Images.SetKeyName(21, "p21.png");
            this.imageList1.Images.SetKeyName(22, "p22.png");
            this.imageList1.Images.SetKeyName(23, "p23.png");
            this.imageList1.Images.SetKeyName(24, "p24.png");
            this.imageList1.Images.SetKeyName(25, "p25.png");
            this.imageList1.Images.SetKeyName(26, "p26.png");
            this.imageList1.Images.SetKeyName(27, "p27.png");
            this.imageList1.Images.SetKeyName(28, "p28.png");
            this.imageList1.Images.SetKeyName(29, "p29.png");
            this.imageList1.Images.SetKeyName(30, "p30.png");
            this.imageList1.Images.SetKeyName(31, "p31.png");
            this.imageList1.Images.SetKeyName(32, "p32.png");
            this.imageList1.Images.SetKeyName(33, "p33.png");
            this.imageList1.Images.SetKeyName(34, "p34.png");
            this.imageList1.Images.SetKeyName(35, "p35.png");
            this.imageList1.Images.SetKeyName(36, "p36.png");
            this.imageList1.Images.SetKeyName(37, "p37.png");
            this.imageList1.Images.SetKeyName(38, "p38.png");
            this.imageList1.Images.SetKeyName(39, "p39.png");
            this.imageList1.Images.SetKeyName(40, "p40.png");
            this.imageList1.Images.SetKeyName(41, "p41.png");
            this.imageList1.Images.SetKeyName(42, "p42.png");
            this.imageList1.Images.SetKeyName(43, "p43.png");
            this.imageList1.Images.SetKeyName(44, "p44.png");
            this.imageList1.Images.SetKeyName(45, "p45.png");
            this.imageList1.Images.SetKeyName(46, "p46.png");
            this.imageList1.Images.SetKeyName(47, "p47.png");
            this.imageList1.Images.SetKeyName(48, "p48.png");
            this.imageList1.Images.SetKeyName(49, "p49.png");
            this.imageList1.Images.SetKeyName(50, "p50.png");
            this.imageList1.Images.SetKeyName(51, "p51 - Copy - Copy.png");
            // 
            // Card1pictureBox
            // 
            this.Card1pictureBox.Location = new System.Drawing.Point(14, 186);
            this.Card1pictureBox.Name = "Card1pictureBox";
            this.Card1pictureBox.Size = new System.Drawing.Size(100, 150);
            this.Card1pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card1pictureBox.TabIndex = 8;
            this.Card1pictureBox.TabStop = false;
            this.Card1pictureBox.Click += new System.EventHandler(this.Card1pictureBox_Click);
            // 
            // Card2pictureBox
            // 
            this.Card2pictureBox.Location = new System.Drawing.Point(176, 186);
            this.Card2pictureBox.Name = "Card2pictureBox";
            this.Card2pictureBox.Size = new System.Drawing.Size(100, 150);
            this.Card2pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card2pictureBox.TabIndex = 9;
            this.Card2pictureBox.TabStop = false;
            this.Card2pictureBox.Click += new System.EventHandler(this.Card2pictureBox_Click);
            // 
            // Card3pictureBox
            // 
            this.Card3pictureBox.Location = new System.Drawing.Point(344, 186);
            this.Card3pictureBox.Name = "Card3pictureBox";
            this.Card3pictureBox.Size = new System.Drawing.Size(100, 150);
            this.Card3pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card3pictureBox.TabIndex = 10;
            this.Card3pictureBox.TabStop = false;
            this.Card3pictureBox.Click += new System.EventHandler(this.Card3pictureBox_Click);
            // 
            // Card4pictureBox
            // 
            this.Card4pictureBox.Location = new System.Drawing.Point(509, 186);
            this.Card4pictureBox.Name = "Card4pictureBox";
            this.Card4pictureBox.Size = new System.Drawing.Size(100, 150);
            this.Card4pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card4pictureBox.TabIndex = 11;
            this.Card4pictureBox.TabStop = false;
            this.Card4pictureBox.Click += new System.EventHandler(this.Card4pictureBox_Click);
            // 
            // Card5pictureBox
            // 
            this.Card5pictureBox.Location = new System.Drawing.Point(663, 186);
            this.Card5pictureBox.Name = "Card5pictureBox";
            this.Card5pictureBox.Size = new System.Drawing.Size(100, 150);
            this.Card5pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card5pictureBox.TabIndex = 12;
            this.Card5pictureBox.TabStop = false;
            this.Card5pictureBox.Click += new System.EventHandler(this.Card5pictureBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.Card5pictureBox);
            this.Controls.Add(this.Card4pictureBox);
            this.Controls.Add(this.Card3pictureBox);
            this.Controls.Add(this.Card2pictureBox);
            this.Controls.Add(this.Card1pictureBox);
            this.Controls.Add(this.Keep5checkBox);
            this.Controls.Add(this.Keep4checkBox);
            this.Controls.Add(this.Keep3checkBox);
            this.Controls.Add(this.Keep2checkBox);
            this.Controls.Add(this.Keep1checkBox);
            this.Controls.Add(this.LoadHandbutton);
            this.Controls.Add(this.SaveHandbutton);
            this.Controls.Add(this.Dealbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Poker Hand Simulator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Card1pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dealbutton;
        private System.Windows.Forms.Button SaveHandbutton;
        private System.Windows.Forms.Button LoadHandbutton;
        private System.Windows.Forms.CheckBox Keep1checkBox;
        private System.Windows.Forms.CheckBox Keep2checkBox;
        private System.Windows.Forms.CheckBox Keep3checkBox;
        private System.Windows.Forms.CheckBox Keep4checkBox;
        private System.Windows.Forms.CheckBox Keep5checkBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox Card1pictureBox;
        private System.Windows.Forms.PictureBox Card2pictureBox;
        private System.Windows.Forms.PictureBox Card3pictureBox;
        private System.Windows.Forms.PictureBox Card4pictureBox;
        private System.Windows.Forms.PictureBox Card5pictureBox;
    }
}

