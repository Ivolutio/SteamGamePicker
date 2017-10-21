using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SteamWebAPI2.Interfaces;
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
    public partial class SteamGamePicker : Form
    {
        private GamePickerConfig config;

        public SteamGamePicker()
        {
            // We're checking config before the form loads ;)
            // Preload Config
            if (!File.Exists("config.json"))
                new FirstBoot().ShowDialog();
            config = JObject.Parse(File.ReadAllText("config.json")).ToObject<GamePickerConfig>();
            InitializeComponent();
        }

        private void SteamGamePicker_Load(object sender, EventArgs e)
        {
            steamidInput.Text = config.UserId.ToString();
        }

        private async Task RunSteamStuff()
        {
            // this will map to the ISteamUser endpoint
            var steamInterface = new SteamUser(config.ApiKey);
            var player = new PlayerService(config.ApiKey);
            TimeSpanConverter converter = new TimeSpanConverter();

            var playerSummaryResponse = await steamInterface.GetPlayerSummaryAsync(ulong.Parse(steamidInput.Text));
            var playerSummaryData = playerSummaryResponse.Data;
            outputText.Text = playerSummaryData.Nickname;

            var timespan = converter.ConvertFromString(hourInput.Text + ":" + minuteInput.Text + ":" + secondInput.Text);
            var ownedgames = await player.GetOwnedGamesAsync(config.UserId, true, false);
            var gamesdata = ownedgames.Data;
            var games = gamesdata.OwnedGames;

            foreach(var game in games)
            {
                if (!checkBox1.Checked || game.PlaytimeForever.CompareTo(timespan) <= 0)
                {
                    gamesList.Items.Add(game.PlaytimeForever + " | " + game.Name);
                }
            }
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            if (steamidInput.TextLength != 17)
                return;
            config.UserId = ulong.Parse(steamidInput.Text);
            gamesList.Items.Clear();
            outputText.Text = "Fetching.....";
            await RunSteamStuff();
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            int count = gamesList.Items.Count;
            if (count > 0)
            {
                Random random = new Random();
                int game = random.Next(0, count);
                string gamename = gamesList.Items[game].ToString();
                gamesList.SelectedIndex = game;
                randomGameBox.Text = gamename;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            hourInput.Enabled = checkBox1.Checked;
            minuteInput.Enabled = checkBox1.Checked;
            secondInput.Enabled = checkBox1.Checked;
        }

        private void steamIDFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://steamidfinder.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            steamidInput.Text = config.UserId.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FirstBoot().ShowDialog();
            config = JObject.Parse(File.ReadAllText("config.json")).ToObject<GamePickerConfig>();
            steamidInput.Text = config.UserId.ToString();
            this.Show();
        }

        private void steamDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://steamcommunity.com/dev/apikey");
        }
    }
}
