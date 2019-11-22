using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoQuest.Properties;

namespace CryptoQuest
{
    public partial class FirstLevel : Form
    {
        public FirstLevel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", @"C:\Users\mussa\source\repos\CryptoQuest\CryptoQuest\Resources\HTMLPage1.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", @"C:\Users\mussa\source\repos\CryptoQuest\CryptoQuest\Resources\HTMLPage1.html");
            label3.Visible = true;
            label2.Visible = true;
            button1.Visible = true;
            pictureBox1.Visible = true;
            button3.Visible = false;
            label5.Visible = true;
            textBox1.Enabled = true;
            button2.Enabled = true;


            CountDownTimer timer = new CountDownTimer();
            //set to 30 mins
            timer.SetTime(5, 0);

            timer.Start();

            //update label text
            timer.TimeChanged += () => label5.Text = timer.TimeLeftMsStr;

            // show messageBox on timer = 00:00.000
            timer.CountDownFinished += () => MessageBox.Show("Уақыт бітті кеңес алуыңызға болады!");

            //timer step. By default is 1 second
            timer.StepMs = 33;
            timer.CountDownFinished += () => label4.Visible = true;
            timer.CountDownFinished += () => button4.Visible = true;
            timer.CountDownFinished += () => label5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.ToLower() == "керемет")
            {
                this.Hide();
                SecondLevel secondLevel = new SecondLevel();
                secondLevel.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Жауап қате!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сайт бетіндегі ақпарат маңызды емес...");
        }

        private void FirstLevel_Load(object sender, EventArgs e)
        {
            
        }
    }
}
