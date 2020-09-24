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
            this.components = new System.ComponentModel.Container();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxMinimum = new System.Windows.Forms.TextBox();
            this.textBoxMaximum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxXAksis = new System.Windows.Forms.TextBox();
            this.textBoxYAksis = new System.Windows.Forms.TextBox();
            this.labelXAksis = new System.Windows.Forms.Label();
            this.labelYAksis = new System.Windows.Forms.Label();
            this.checkBoxCursorPlacement = new System.Windows.Forms.CheckBox();
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
            this.textBoxMinuter.Text = "0";
            // 
            // textBoxSekunder
            // 
            this.textBoxSekunder.Location = new System.Drawing.Point(247, 45);
            this.textBoxSekunder.Name = "textBoxSekunder";
            this.textBoxSekunder.Size = new System.Drawing.Size(93, 20);
            this.textBoxSekunder.TabIndex = 10;
            this.textBoxSekunder.Text = "0";
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
            this.buttonStop.Location = new System.Drawing.Point(247, 246);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(192, 43);
            this.buttonStop.TabIndex = 12;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Visible = false;
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
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkBoxRandomNumber
            // 
            this.checkBoxRandomNumber.AutoSize = true;
            this.checkBoxRandomNumber.Location = new System.Drawing.Point(260, 86);
            this.checkBoxRandomNumber.Name = "checkBoxRandomNumber";
            this.checkBoxRandomNumber.Size = new System.Drawing.Size(80, 17);
            this.checkBoxRandomNumber.TabIndex = 18;
            this.checkBoxRandomNumber.Text = "Tilfældig tal";
            this.checkBoxRandomNumber.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxMinimum
            // 
            this.textBoxMinimum.Location = new System.Drawing.Point(49, 84);
            this.textBoxMinimum.Name = "textBoxMinimum";
            this.textBoxMinimum.Size = new System.Drawing.Size(93, 20);
            this.textBoxMinimum.TabIndex = 19;
            this.textBoxMinimum.Text = "0";
            // 
            // textBoxMaximum
            // 
            this.textBoxMaximum.Location = new System.Drawing.Point(148, 84);
            this.textBoxMaximum.Name = "textBoxMaximum";
            this.textBoxMaximum.Size = new System.Drawing.Size(93, 20);
            this.textBoxMaximum.TabIndex = 20;
            this.textBoxMaximum.Text = "1";
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
            this.textBoxXAksis.Text = "100";
            // 
            // textBoxYAksis
            // 
            this.textBoxYAksis.Location = new System.Drawing.Point(148, 123);
            this.textBoxYAksis.Name = "textBoxYAksis";
            this.textBoxYAksis.Size = new System.Drawing.Size(90, 20);
            this.textBoxYAksis.TabIndex = 24;
            this.textBoxYAksis.Text = "100";
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
            this.checkBoxCursorPlacement.Location = new System.Drawing.Point(260, 123);
            this.checkBoxCursorPlacement.Name = "checkBoxCursorPlacement";
            this.checkBoxCursorPlacement.Size = new System.Drawing.Size(104, 17);
            this.checkBoxCursorPlacement.TabIndex = 27;
            this.checkBoxCursorPlacement.Text = "Placering af mus";
            this.checkBoxCursorPlacement.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 388);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxMinimum;
        private System.Windows.Forms.TextBox textBoxMaximum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxXAksis;
        private System.Windows.Forms.TextBox textBoxYAksis;
        private System.Windows.Forms.Label labelXAksis;
        private System.Windows.Forms.Label labelYAksis;
        private System.Windows.Forms.CheckBox checkBoxCursorPlacement;
    }
}

