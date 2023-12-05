using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivityAlarm
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private NotifyIcon icon;
        private int elapsedTimeInSeconds;
        private WorkingStates currentState;
        private WorkingStates prevState;

        enum WorkingStates
        {
            Initializing,
            Working,
            Break,
            Pausing
        }

        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            elapsedTimeInSeconds = 0;
            prevState = WorkingStates.Initializing; 
            currentState = WorkingStates.Initializing;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the elapsed time
            elapsedTimeInSeconds++;

            // Show notification every 25 minutes
            if (elapsedTimeInSeconds % (25 * 60) == 0 && currentState == WorkingStates.Working)
            {
                bool userClickOK = ShowPopup("Timer Alert", "It's time to take a break!");
                timer.Stop();
                elapsedTimeInSeconds = 0;
                if (userClickOK)
                {
                    timer.Start();
                    currentState = WorkingStates.Break;
                }
            }
            else if (elapsedTimeInSeconds % (5 * 60) == 0 && currentState == WorkingStates.Break)
            {
                bool userClickOK = ShowPopup("Timer Alert", "Break is over!");
                timer.Stop();  
                elapsedTimeInSeconds = 0;
                if (userClickOK)
                {
                    timer.Start();
                    currentState = WorkingStates.Working;
                }
            }
            // Update the timer display on the form
            UpdateTimerDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                alarm_btn.Text = "Resume";
                prevState = currentState;
                currentState = WorkingStates.Pausing;
            }
            else if (currentState == WorkingStates.Pausing)
            {
                timer.Start();
                alarm_btn.Text = "Pause";
                currentState = prevState;
            }
            else // first click
            {
                timer.Start();
                alarm_btn.Text = "Pause";
                currentState = WorkingStates.Working;
            }
        }

        private bool ShowPopup(string title, string message)
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return result == DialogResult.OK;
        }

        private void currentTime_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTimerDisplay()
        {
            // Update the label or any other control to display the timer
            int minutes = elapsedTimeInSeconds / 60;
            int seconds = elapsedTimeInSeconds % 60;
            currentTime.Text = $"{minutes:D2}:{seconds:D2}";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the timer and hide the notify icon when the form is closing
            timer.Stop();
        }
    }
}
