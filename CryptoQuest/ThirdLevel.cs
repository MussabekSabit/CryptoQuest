using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoQuest
{
    public partial class ThirdLevel : Form
    {
        public ThirdLevel()
        {
            InitializeComponent();
        }
        string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
     
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            button3.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = path_desktop + @"\Кілттік сөз.txt";
            if (textBox1.Text.ToLower() == "biz kaznu studentimiz")
            {
                MessageBox.Show("Келесі деңгейлер жақын арада дайын болады!");
                File.Delete(path);
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Жауап қате!");
            }
        }

        private void ThirdLevel_Load(object sender, EventArgs e)
        {
            string path = path_desktop + @"\Кілттік сөз.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine("кілт :" + " 2019 ");          
            sw.Flush();
            sw.Close();
            File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Гронсфельд");
        }
    }
}
