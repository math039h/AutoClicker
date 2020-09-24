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
        private int miliseconds;
        private int intervals;
        public int parsedValue;
        private bool click1 = false;
        private int rndNum;
        private int randomIntervals;
        private int mouseX;
        private int mouseY;
        public int Hour { get => hour; set => hour = value; }
        public int Minutes { get => minutes; set => minutes = value; }
        public int Seconds { get => seconds; set => seconds = value; }
        public int RndNum { get => rndNum; set => rndNum = value; }
        public int RandomIntervals { get => randomIntervals; set => randomIntervals = value; }
        public int Intervals { get => intervals; set => intervals = value; }
        public bool Click1 { get => click1; set => click1 = value; }
        public int Miliseconds { get => miliseconds; set => miliseconds = value; }
        public int MouseX { get => mouseX; set => mouseX = value; }
        public int MouseY { get => mouseY; set => mouseY = value; }

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
                if (Click1 == true)
                {
                    if (!checkBoxRandomNumber.Checked)
                    {
                        mouse_event(dwFlags: leftUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                        Thread.Sleep(1);
                        mouse_event(dwFlags: leftDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                        Thread.Sleep(Intervals);
                    }
                    else if (checkBoxRandomNumber.Checked)
                    {
                        mouse_event(dwFlags: leftUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                        Thread.Sleep(1);
                        mouse_event(dwFlags: leftDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                        RndNum = Next(Convert.ToInt32(textBoxMinimum.Text), Convert.ToInt32(textBoxMaximum.Text));
                        RandomIntervals = Intervals + RndNum;
                        Thread.Sleep(RandomIntervals);
                    }

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
                    Click1 = true;
                    Thread.Sleep(1);
                }
                else if (buttonStart.Visible)
                {
                    Click1 = false;
                    Thread.Sleep(1);
                }
                if (GetAsyncKeyState(Keys.Up) < 0)
                {
                    buttonStart.Visible = false;
                    buttonStop.Visible = true;
                    Click1 = true;
                    Thread.Sleep(1);
                }
                else if (GetAsyncKeyState(Keys.Down) < 0)
                {
                    buttonStart.Visible = true;
                    buttonStop.Visible = false;
                    Click1 = false;
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
                if (checkBoxCursorPlacement.Checked)
                {
                    MoveCursor();
                }

                TimeConverter();
                Intervals = Hour + Minutes + Seconds + Miliseconds;
                buttonStart.Visible = false;
                buttonStop.Visible = true;
            }
        }

        private static readonly Random Global = new Random();
        [ThreadStatic] private static Random _local;

        public int Next(int min, int max)
        {
            var localBuffer = _local;
            if (localBuffer == null)
            {
                int seed;
                lock (Global) seed = Global.Next();
                localBuffer = new Random(seed);
                _local = localBuffer;
            }
            return localBuffer.Next(min, max);
        }

        private void TimeConverter()
        {
            Hour = Convert.ToInt32(textBoxTimer.Text) * 3600000;
            Minutes = Convert.ToInt32(textBoxMinuter.Text) * 60000;
            Seconds = Convert.ToInt32(textBoxSekunder.Text) * 1000;
            Miliseconds = Convert.ToInt32(textBoxMilisekunder.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = true;
            buttonStop.Visible = false;
        }

        private void MoveCursor()
        {
            // Set the Current cursor, move the cursor's Position,
            // and set its clipping rectangle to the form. 

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Convert.ToInt32(textBoxXAksis.Text), Convert.ToInt32(textBoxYAksis.Text));
        }
    }
}
