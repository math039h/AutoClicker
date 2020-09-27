namespace MyAwesomeAutoClikerFormsFramework
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
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMinuter = new System.Windows.Forms.TextBox();
            this.textBoxSekunder = new System.Windows.Forms.TextBox();
            this.textBoxMilisekunder = new System.Windows.Forms.TextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBoxRandomNumber = new System.Windows.Forms.CheckBox();
            this.textBoxMinimum = new System.Windows.Forms.TextBox();
            this.textBoxMaximum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxXAksis = new System.Windows.Forms.TextBox();
            this.textBoxYAksis = new System.Windows.Forms.TextBox();
            this.labelXAksis = new System.Windows.Forms.Label();
            this.labelYAksis = new System.Windows.Forms.Label();
            this.checkBoxCursorPlacement = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSecondXAksis = new System.Windows.Forms.TextBox();
            this.textBoxSecondYAksis = new System.Windows.Forms.TextBox();
            this.checkBoxSecondCursorPlacement = new System.Windows.Forms.CheckBox();
            this.buttonStartNetflixAndChill = new System.Windows.Forms.Button();
            this.buttonStopNetflixAndChill = new System.Windows.Forms.Button();
            this.textBoxNetflixXAksis = new System.Windows.Forms.TextBox();
            this.textBoxNetflixYAksis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxNetflixCursorPlacement = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.Location = new System.Drawing.Point(49, 45);
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.Size = new System.Drawing.Size(93, 20);
            this.textBoxTimer.TabIndex = 0;
            this.textBoxTimer.Text = "0";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Interval";
            // 
            // textBoxMinuter
            // 
            this.textBoxMinuter.Location = new System.Drawing.Point(148, 45);
            this.textBoxMinuter.Name = "textBoxMinuter";
            this.textBoxMinuter.Size = new System.Drawing.Size(93, 20);
            this.textBoxMinuter.TabIndex = 9;
            this.textBoxMinuter.Text = "2";
            // 
            // textBoxSekunder
            // 
            this.textBoxSekunder.Location = new System.Drawing.Point(247, 45);
            this.textBoxSekunder.Name = "textBoxSekunder";
            this.textBoxSekunder.Size = new System.Drawing.Size(93, 20);
            this.textBoxSekunder.TabIndex = 10;
            this.textBoxSekunder.Text = "35";
            // 
            // textBoxMilisekunder
            // 
            this.textBoxMilisekunder.Location = new System.Drawing.Point(346, 45);
            this.textBoxMilisekunder.Name = "textBoxMilisekunder";
            this.textBoxMilisekunder.Size = new System.Drawing.Size(93, 20);
            this.textBoxMilisekunder.TabIndex = 11;
            this.textBoxMilisekunder.Text = "0";
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(247, 246);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(192, 43);
            this.buttonStop.TabIndex = 12;
            this.buttonStop.Text = "Stop (F6)";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Timer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Minuter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sekunder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Milisekunder";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(49, 246);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(192, 43);
            this.buttonStart.TabIndex = 17;
            this.buttonStart.Text = "Start (F6)";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkBoxRandomNumber
            // 
            this.checkBoxRandomNumber.AutoSize = true;
            this.checkBoxRandomNumber.Checked = true;
            this.checkBoxRandomNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRandomNumber.Location = new System.Drawing.Point(260, 86);
            this.checkBoxRandomNumber.Name = "checkBoxRandomNumber";
            this.checkBoxRandomNumber.Size = new System.Drawing.Size(80, 17);
            this.checkBoxRandomNumber.TabIndex = 18;
            this.checkBoxRandomNumber.Text = "Tilfældig tal";
            this.checkBoxRandomNumber.UseVisualStyleBackColor = true;
            // 
            // textBoxMinimum
            // 
            this.textBoxMinimum.Location = new System.Drawing.Point(49, 84);
            this.textBoxMinimum.Name = "textBoxMinimum";
            this.textBoxMinimum.Size = new System.Drawing.Size(93, 20);
            this.textBoxMinimum.TabIndex = 19;
            this.textBoxMinimum.Text = "1";
            // 
            // textBoxMaximum
            // 
            this.textBoxMaximum.Location = new System.Drawing.Point(148, 84);
            this.textBoxMaximum.Name = "textBoxMaximum";
            this.textBoxMaximum.Size = new System.Drawing.Size(93, 20);
            this.textBoxMaximum.TabIndex = 20;
            this.textBoxMaximum.Text = "1001";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Minimum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Maximum";
            // 
            // textBoxXAksis
            // 
            this.textBoxXAksis.Location = new System.Drawing.Point(49, 123);
            this.textBoxXAksis.Name = "textBoxXAksis";
            this.textBoxXAksis.Size = new System.Drawing.Size(93, 20);
            this.textBoxXAksis.TabIndex = 23;
            this.textBoxXAksis.Text = "1400";
            // 
            // textBoxYAksis
            // 
            this.textBoxYAksis.Location = new System.Drawing.Point(148, 123);
            this.textBoxYAksis.Name = "textBoxYAksis";
            this.textBoxYAksis.Size = new System.Drawing.Size(93, 20);
            this.textBoxYAksis.TabIndex = 24;
            this.textBoxYAksis.Text = "600";
            // 
            // labelXAksis
            // 
            this.labelXAksis.AutoSize = true;
            this.labelXAksis.Location = new System.Drawing.Point(46, 107);
            this.labelXAksis.Name = "labelXAksis";
            this.labelXAksis.Size = new System.Drawing.Size(39, 13);
            this.labelXAksis.TabIndex = 25;
            this.labelXAksis.Text = "x-aksis";
            // 
            // labelYAksis
            // 
            this.labelYAksis.AutoSize = true;
            this.labelYAksis.Location = new System.Drawing.Point(145, 107);
            this.labelYAksis.Name = "labelYAksis";
            this.labelYAksis.Size = new System.Drawing.Size(39, 13);
            this.labelYAksis.TabIndex = 26;
            this.labelYAksis.Text = "y-aksis";
            // 
            // checkBoxCursorPlacement
            // 
            this.checkBoxCursorPlacement.AutoSize = true;
            this.checkBoxCursorPlacement.Location = new System.Drawing.Point(260, 125);
            this.checkBoxCursorPlacement.Name = "checkBoxCursorPlacement";
            this.checkBoxCursorPlacement.Size = new System.Drawing.Size(104, 17);
            this.checkBoxCursorPlacement.TabIndex = 27;
            this.checkBoxCursorPlacement.Text = "Placering af mus";
            this.checkBoxCursorPlacement.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "x-aksis";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "y-aksis";
            // 
            // textBoxSecondXAksis
            // 
            this.textBoxSecondXAksis.Location = new System.Drawing.Point(49, 162);
            this.textBoxSecondXAksis.Name = "textBoxSecondXAksis";
            this.textBoxSecondXAksis.Size = new System.Drawing.Size(93, 20);
            this.textBoxSecondXAksis.TabIndex = 30;
            this.textBoxSecondXAksis.Text = "1500";
            // 
            // textBoxSecondYAksis
            // 
            this.textBoxSecondYAksis.Location = new System.Drawing.Point(148, 162);
            this.textBoxSecondYAksis.Name = "textBoxSecondYAksis";
            this.textBoxSecondYAksis.Size = new System.Drawing.Size(93, 20);
            this.textBoxSecondYAksis.TabIndex = 31;
            this.textBoxSecondYAksis.Text = "600";
            // 
            // checkBoxSecondCursorPlacement
            // 
            this.checkBoxSecondCursorPlacement.AutoSize = true;
            this.checkBoxSecondCursorPlacement.Location = new System.Drawing.Point(260, 164);
            this.checkBoxSecondCursorPlacement.Name = "checkBoxSecondCursorPlacement";
            this.checkBoxSecondCursorPlacement.Size = new System.Drawing.Size(137, 17);
            this.checkBoxSecondCursorPlacement.TabIndex = 32;
            this.checkBoxSecondCursorPlacement.Text = "Anden placering af mus";
            this.checkBoxSecondCursorPlacement.UseVisualStyleBackColor = true;
            // 
            // buttonStartNetflixAndChill
            // 
            this.buttonStartNetflixAndChill.Location = new System.Drawing.Point(49, 295);
            this.buttonStartNetflixAndChill.Name = "buttonStartNetflixAndChill";
            this.buttonStartNetflixAndChill.Size = new System.Drawing.Size(192, 43);
            this.buttonStartNetflixAndChill.TabIndex = 34;
            this.buttonStartNetflixAndChill.Text = "Start Netflix And Chill (N)";
            this.buttonStartNetflixAndChill.UseVisualStyleBackColor = true;
            this.buttonStartNetflixAndChill.Click += new System.EventHandler(this.buttonNetflixAndChill_Click);
            // 
            // buttonStopNetflixAndChill
            // 
            this.buttonStopNetflixAndChill.Enabled = false;
            this.buttonStopNetflixAndChill.Location = new System.Drawing.Point(248, 296);
            this.buttonStopNetflixAndChill.Name = "buttonStopNetflixAndChill";
            this.buttonStopNetflixAndChill.Size = new System.Drawing.Size(191, 42);
            this.buttonStopNetflixAndChill.TabIndex = 35;
            this.buttonStopNetflixAndChill.Text = "Stop Netflix And Chill (N)";
            this.buttonStopNetflixAndChill.UseVisualStyleBackColor = true;
            this.buttonStopNetflixAndChill.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNetflixXAksis
            // 
            this.textBoxNetflixXAksis.Location = new System.Drawing.Point(49, 205);
            this.textBoxNetflixXAksis.Name = "textBoxNetflixXAksis";
            this.textBoxNetflixXAksis.Size = new System.Drawing.Size(93, 20);
            this.textBoxNetflixXAksis.TabIndex = 36;
            this.textBoxNetflixXAksis.Text = "0";
            // 
            // textBoxNetflixYAksis
            // 
            this.textBoxNetflixYAksis.Location = new System.Drawing.Point(148, 205);
            this.textBoxNetflixYAksis.Name = "textBoxNetflixYAksis";
            this.textBoxNetflixYAksis.Size = new System.Drawing.Size(90, 20);
            this.textBoxNetflixYAksis.TabIndex = 37;
            this.textBoxNetflixYAksis.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "x-aksis";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "y-aksis";
            // 
            // checkBoxNetflixCursorPlacement
            // 
            this.checkBoxNetflixCursorPlacement.AutoSize = true;
            this.checkBoxNetflixCursorPlacement.Location = new System.Drawing.Point(260, 207);
            this.checkBoxNetflixCursorPlacement.Name = "checkBoxNetflixCursorPlacement";
            this.checkBoxNetflixCursorPlacement.Size = new System.Drawing.Size(93, 17);
            this.checkBoxNetflixCursorPlacement.TabIndex = 40;
            this.checkBoxNetflixCursorPlacement.Text = "Netflix Custom";
            this.checkBoxNetflixCursorPlacement.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 388);
            this.Controls.Add(this.checkBoxNetflixCursorPlacement);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxNetflixYAksis);
            this.Controls.Add(this.textBoxNetflixXAksis);
            this.Controls.Add(this.buttonStopNetflixAndChill);
            this.Controls.Add(this.buttonStartNetflixAndChill);
            this.Controls.Add(this.checkBoxSecondCursorPlacement);
            this.Controls.Add(this.textBoxSecondYAksis);
            this.Controls.Add(this.textBoxSecondXAksis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxCursorPlacement);
            this.Controls.Add(this.labelYAksis);
            this.Controls.Add(this.labelXAksis);
            this.Controls.Add(this.textBoxYAksis);
            this.Controls.Add(this.textBoxXAksis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMaximum);
            this.Controls.Add(this.textBoxMinimum);
            this.Controls.Add(this.checkBoxRandomNumber);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.textBoxMilisekunder);
            this.Controls.Add(this.textBoxSekunder);
            this.Controls.Add(this.textBoxMinuter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTimer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMinuter;
        private System.Windows.Forms.TextBox textBoxSekunder;
        private System.Windows.Forms.TextBox textBoxMilisekunder;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBoxRandomNumber;
        private System.Windows.Forms.TextBox textBoxMinimum;
        private System.Windows.Forms.TextBox textBoxMaximum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxXAksis;
        private System.Windows.Forms.TextBox textBoxYAksis;
        private System.Windows.Forms.Label labelXAksis;
        private System.Windows.Forms.Label labelYAksis;
        private System.Windows.Forms.CheckBox checkBoxCursorPlacement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSecondXAksis;
        private System.Windows.Forms.TextBox textBoxSecondYAksis;
        private System.Windows.Forms.CheckBox checkBoxSecondCursorPlacement;
        private System.Windows.Forms.Button buttonStartNetflixAndChill;
        private System.Windows.Forms.Button buttonStopNetflixAndChill;
        private System.Windows.Forms.TextBox textBoxNetflixXAksis;
        private System.Windows.Forms.TextBox textBoxNetflixYAksis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxNetflixCursorPlacement;
    }
}

