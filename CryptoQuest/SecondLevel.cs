using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoQuest
{
    public partial class SecondLevel : Form
    {
        public SecondLevel()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);
        const uint SPI_SETDESKWALLPAPER = 0x14;
        const uint SPIF_UPDATEINIFILE = 0x01;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(UInt32 uAction, int uParam, string lpvParam, int fuWinIni);
        private const UInt32 SPI_GETDESKWALLPAPER = 0x73;
        private const int MAX_PATH = 260;
        string currentWallpaper = new string('\0', MAX_PATH);

        //wallpaper
        public void SetDWallpaper(string path)
        {
            //SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE);
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE);
        }

        //current walpeper path
        public string GetCurrentDesktopWallpaper()
        {
            SystemParametersInfo(SPI_GETDESKWALLPAPER, currentWallpaper.Length, currentWallpaper, 0);
            return currentWallpaper.Substring(0, currentWallpaper.IndexOf('\0'));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button1.Visible = false;
            button3.Visible = true;
            textBox1.Enabled = true;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetDWallpaper("C:\\Users\\mussa\\Downloads\\1.png");
        }

        private void SecondLevel_Load(object sender, EventArgs e)
        {
            GetCurrentDesktopWallpaper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                SetDWallpaper(currentWallpaper);
                this.Hide();
                ThirdLevel thirdLevel = new ThirdLevel();
                thirdLevel.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Жауап қате!");
            }
            
        }
    }
}
