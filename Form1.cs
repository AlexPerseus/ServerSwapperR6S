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

namespace Server_Swapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            popUp.Location = new Point(12, 12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (string dir in Directory.GetDirectories(@"C:\Users\" + Environment.UserName + @"\Documents\My Games\Rainbow Six - Siege"))
            {
                DirectoryInfo info = new DirectoryInfo(dir);
                var GameSettings = new IniFile(info.FullName + @"\GameSettings.ini");
                GameSettings.Write("DataCenterHint", comboBox1.Items[comboBox1.SelectedIndex].ToString(), "ONLINE");
                count++;
            }
            MessageBox.Show("Server successfuly changed for " + count + " Accounts.", "Created By AlexPerseus - Github");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
        int tickCount = 0;
        private void removePopup_Tick(object sender, EventArgs e)
        {
            if (tickCount > 100)
                popUp.Location = new Point(popUp.Location.X, popUp.Location.Y + 2);
            tickCount++;
        }
    }
}
