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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iTalk_ComboBox1.Items.Clear();
            foreach (var item in comboBox1.Items)
                iTalk_ComboBox1.Items.Add(item);

            iTalk_ComboBox1.SelectedIndex = 0;
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            while (Opacity > 0)
                Opacity = Opacity - 0.0005f;
            Environment.Exit(0);
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (string dir in Directory.GetDirectories(@"C:\Users\" + Environment.UserName + @"\Documents\My Games\Rainbow Six - Siege"))
            {
                DirectoryInfo info = new DirectoryInfo(dir);
                var GameSettings = new IniFile(info.FullName + @"\GameSettings.ini");
                GameSettings.Write("DataCenterHint", "playfab/" + comboBox1.Items[iTalk_ComboBox1.SelectedIndex].ToString(), "ONLINE");
                count++;
            }
            MessageBox.Show("Server successfuly changed for " + count + " Accounts.", "Created By AlexPerseus - Github");
        }
    }
}
