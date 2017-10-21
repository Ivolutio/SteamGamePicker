using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamGamePicker
{
    public partial class FirstBoot : Form
    {
        public FirstBoot()
        {
            InitializeComponent();
            if (File.Exists("config.json"))
            {
                var config = JObject.Parse(File.ReadAllText("config.json")).ToObject<GamePickerConfig>();
                this.textBox1.Text = config.ApiKey;
                this.textBox2.Text = config.UserId.ToString();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Don't worry about your API key or Steam ID!\nThese are safely stored in a file called config.json, right here on your PC.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://steamcommunity.com/dev/apikey");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://steamidfinder.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Create("config.json").Close();
            GamePickerConfig cfg = new GamePickerConfig();
            cfg.ApiKey = textBox1.Text;
            try
            {
                cfg.UserId = ulong.Parse(textBox2.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Failed topare your ID! please make sure it is a valid Steam ID64 (ulong)");
                return;
            }
            File.WriteAllText("config.json", JObject.FromObject(cfg).ToString());
            this.Close();
        }
    }
}
