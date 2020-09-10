using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAwesomeAutoClikerFormsFramework
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]

        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        private const int leftUp = 0x0004;
        private const int leftDown = 0x0002;
        private int hour;
        private int minutes;
        private int seconds;
        private int milisconds;
        public int intervals = 5;
        public int parsedValue;
        public bool click = false;

        public int Hour { get => hour; set => hour = value; }
        public int Minutes { get => minutes; set => minutes = value; }
        public int Seconds { get => seconds; set => seconds = value; }
        public int Milisconds { get => milisconds; set => milisconds = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread AC = new Thread(AutoClick);
            backgroundWorker1.RunWorkerAsync();

            AC.Start();
        }

        private void AutoClick()
        {
            while (true)
            {
                if (click == true)
                {
                    mouse_event(dwFlags: leftUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(1);
                    mouse_event(dwFlags: leftDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(intervals);
                }
                Thread.Sleep(2);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {

                if (!buttonStart.Visible)
                {
                    click = true;
                    Thread.Sleep(1);
                }
                else if (buttonStart.Visible)
                {
                    click = false;
                    Thread.Sleep(1);
                }
                if (GetAsyncKeyState(Keys.Up) < 0)
                {
                    buttonStart.Visible = false;
                    buttonStop.Visible = true;
                    click = true;
                    Thread.Sleep(1);
                }
                if (GetAsyncKeyState(Keys.Down) < 0)
                {
                    buttonStart.Visible = true;
                    buttonStop.Visible = false;
                    click = false;
                    Thread.Sleep(1);
                }

                
                Thread.Sleep(1);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxMilisekunder.Text, out parsedValue) ||
                !int.TryParse(textBoxSekunder.Text, out parsedValue) ||
                !int.TryParse(textBoxMinuter.Text, out parsedValue) ||
                !int.TryParse(textBoxTimer.Text, out parsedValue))
            {
                MessageBox.Show("indtast venligst et tal");
                return;
            }
            else
            {
                TimeConverter();
                intervals = Hour + Minutes + Seconds + Milisconds;
                buttonStart.Visible = false;
                buttonStop.Visible = true;
            }
        }

        private void TimeConverter()
        {
            Hour = Convert.ToInt32(textBoxTimer.Text) * 3600000;
            Minutes = Convert.ToInt32(textBoxMinuter.Text) * 60000;
            Seconds = Convert.ToInt32(textBoxSekunder.Text) * 1000;
            Milisconds = Convert.ToInt32(textBoxMilisekunder.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = true;
            buttonStop.Visible = false;
        }
    }
}
