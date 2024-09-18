namespace Picture_Puzzle_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn6 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSuffle = new Guna.UI2.WinForms.Guna2Button();
            this.btnStartGame = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfTries = new System.Windows.Forms.Label();
            this.lblTimeTaken = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.gbDifficultyLvl = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbEasy = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbMedium = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbHard = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.gbDifficultyLvl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(58, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.ImageIndex = 6;
            this.btn6.ImageList = this.imageList1;
            this.btn6.Location = new System.Drawing.Point(285, 3);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(135, 134);
            this.btn6.TabIndex = 6;
            this.btn6.Tag = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            this.imageList1.Images.SetKeyName(1, "2.jpg");
            this.imageList1.Images.SetKeyName(2, "3.jpg");
            this.imageList1.Images.SetKeyName(3, "4.jpg");
            this.imageList1.Images.SetKeyName(4, "5.jpg");
            this.imageList1.Images.SetKeyName(5, "6.jpg");
            this.imageList1.Images.SetKeyName(6, "Gray.jpg");
            this.imageList1.Images.SetKeyName(7, "8.jpg");
            this.imageList1.Images.SetKeyName(8, "9.jpg");
            this.imageList1.Images.SetKeyName(9, "7.jpg");
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.ImageIndex = 4;
            this.btn4.ImageList = this.imageList1;
            this.btn4.Location = new System.Drawing.Point(144, 143);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(135, 134);
            this.btn4.TabIndex = 4;
            this.btn4.Tag = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.ImageIndex = 3;
            this.btn3.ImageList = this.imageList1;
            this.btn3.Location = new System.Drawing.Point(285, 143);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(135, 134);
            this.btn3.TabIndex = 3;
            this.btn3.Tag = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.ImageIndex = 1;
            this.btn1.ImageList = this.imageList1;
            this.btn1.Location = new System.Drawing.Point(144, 283);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(135, 134);
            this.btn1.TabIndex = 1;
            this.btn1.Tag = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.ImageIndex = 8;
            this.btn8.ImageList = this.imageList1;
            this.btn8.Location = new System.Drawing.Point(3, 3);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(135, 134);
            this.btn8.TabIndex = 8;
            this.btn8.Tag = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.ImageIndex = 7;
            this.btn7.ImageList = this.imageList1;
            this.btn7.Location = new System.Drawing.Point(144, 3);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(135, 134);
            this.btn7.TabIndex = 7;
            this.btn7.Tag = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Transparent;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.ImageIndex = 0;
            this.btn0.ImageList = this.imageList1;
            this.btn0.Location = new System.Drawing.Point(285, 283);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(136, 135);
            this.btn0.TabIndex = 0;
            this.btn0.Tag = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.ImageIndex = 5;
            this.btn5.ImageList = this.imageList1;
            this.btn5.Location = new System.Drawing.Point(3, 143);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(135, 134);
            this.btn5.TabIndex = 5;
            this.btn5.Tag = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.ImageIndex = 2;
            this.btn2.ImageList = this.imageList1;
            this.btn2.Location = new System.Drawing.Point(3, 283);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(135, 134);
            this.btn2.TabIndex = 2;
            this.btn2.Tag = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Picture_Puzzle_Game.Properties.Resources.BatCat;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(508, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(209, 188);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnSuffle
            // 
            this.btnSuffle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuffle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuffle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuffle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuffle.FillColor = System.Drawing.Color.Beige;
            this.btnSuffle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSuffle.ForeColor = System.Drawing.Color.Gray;
            this.btnSuffle.Location = new System.Drawing.Point(547, 326);
            this.btnSuffle.Name = "btnSuffle";
            this.btnSuffle.Size = new System.Drawing.Size(130, 45);
            this.btnSuffle.TabIndex = 2;
            this.btnSuffle.Text = "Suffle";
            this.btnSuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartGame.FillColor = System.Drawing.Color.Beige;
            this.btnStartGame.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnStartGame.ForeColor = System.Drawing.Color.Gray;
            this.btnStartGame.Location = new System.Drawing.Point(547, 245);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(130, 45);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(725, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number Of Tries:";
            // 
            // lblNumberOfTries
            // 
            this.lblNumberOfTries.AutoSize = true;
            this.lblNumberOfTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTries.ForeColor = System.Drawing.Color.Gray;
            this.lblNumberOfTries.Location = new System.Drawing.Point(875, 28);
            this.lblNumberOfTries.Name = "lblNumberOfTries";
            this.lblNumberOfTries.Size = new System.Drawing.Size(19, 20);
            this.lblNumberOfTries.TabIndex = 5;
            this.lblNumberOfTries.Text = "0";
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.AutoSize = true;
            this.lblTimeTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTaken.ForeColor = System.Drawing.Color.Gray;
            this.lblTimeTaken.Location = new System.Drawing.Point(769, 81);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(111, 29);
            this.lblTimeTaken.TabIndex = 6;
            this.lblTimeTaken.Text = "00:00:00";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // gbDifficultyLvl
            // 
            this.gbDifficultyLvl.Controls.Add(this.rbHard);
            this.gbDifficultyLvl.Controls.Add(this.rbMedium);
            this.gbDifficultyLvl.Controls.Add(this.rbEasy);
            this.gbDifficultyLvl.CustomBorderColor = System.Drawing.Color.Moccasin;
            this.gbDifficultyLvl.FillColor = System.Drawing.Color.Transparent;
            this.gbDifficultyLvl.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbDifficultyLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbDifficultyLvl.Location = new System.Drawing.Point(729, 245);
            this.gbDifficultyLvl.Name = "gbDifficultyLvl";
            this.gbDifficultyLvl.Size = new System.Drawing.Size(259, 204);
            this.gbDifficultyLvl.TabIndex = 7;
            this.gbDifficultyLvl.Text = "Difficulty Lvl";
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Checked = true;
            this.rbEasy.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbEasy.CheckedState.BorderThickness = 0;
            this.rbEasy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbEasy.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbEasy.CheckedState.InnerOffset = -4;
            this.rbEasy.Location = new System.Drawing.Point(13, 55);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(69, 29);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbEasy.UncheckedState.BorderThickness = 2;
            this.rbEasy.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbEasy.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMedium.CheckedState.BorderThickness = 0;
            this.rbMedium.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMedium.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbMedium.CheckedState.InnerOffset = -4;
            this.rbMedium.Location = new System.Drawing.Point(127, 55);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(100, 29);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbMedium.UncheckedState.BorderThickness = 2;
            this.rbMedium.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbMedium.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbHard.CheckedState.BorderThickness = 0;
            this.rbHard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbHard.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbHard.CheckedState.InnerOffset = -4;
            this.rbHard.Location = new System.Drawing.Point(13, 121);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(73, 29);
            this.rbHard.TabIndex = 2;
            this.rbHard.Text = "Hard";
            this.rbHard.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbHard.UncheckedState.BorderThickness = 2;
            this.rbHard.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbHard.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btnReset
            // 
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.Enabled = false;
            this.btnReset.FillColor = System.Drawing.Color.Beige;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnReset.ForeColor = System.Drawing.Color.Gray;
            this.btnReset.Location = new System.Drawing.Point(547, 404);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 45);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1006, 506);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbDifficultyLvl);
            this.Controls.Add(this.lblTimeTaken);
            this.Controls.Add(this.lblNumberOfTries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnSuffle);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "frmImagesPuzzleGame";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.gbDifficultyLvl.ResumeLayout(false);
            this.gbDifficultyLvl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private Guna.UI2.WinForms.Guna2Button btnSuffle;
        private Guna.UI2.WinForms.Guna2Button btnStartGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfTries;
        private System.Windows.Forms.Label lblTimeTaken;
        private System.Windows.Forms.Timer GameTimer;
        private Guna.UI2.WinForms.Guna2GroupBox gbDifficultyLvl;
        private Guna.UI2.WinForms.Guna2RadioButton rbHard;
        private Guna.UI2.WinForms.Guna2RadioButton rbMedium;
        private Guna.UI2.WinForms.Guna2RadioButton rbEasy;
        private Guna.UI2.WinForms.Guna2Button btnReset;
    }
}

