using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
﻿using Steam.Models.SteamCommunity;
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
        private ulong steamid;
        private List<OwnedGameModel> games = new List<OwnedGameModel>();
        private TimeSpan timespan;

        public SteamGamePicker()
        {
            // We're checking config before the form loads ;)
            // Preload Config
            if (!File.Exists("config.json"))
                new FirstBoot().ShowDialog();
            config = JObject.Parse(File.ReadAllText("config.json")).ToObject<GamePickerConfig>();
            File.Create("game.txt").Close();
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
            
            timespan = (TimeSpan)converter.ConvertFromString(hourInput.Text + ":" + minuteInput.Text + ":" + secondInput.Text);
            var ownedgames = await player.GetOwnedGamesAsync(config.UserId, includeAppInfo: true, includeFreeGames: cb_freeGames.Checked);
            var gamesdata = ownedgames.Data;
            games = gamesdata.OwnedGames.ToList();
            if (radioSortNameA.Checked)
            {
                games = games.OrderBy(x => x.Name).ToList();
                DisplayGameList(games);
            }
            else if (radioSortTimeD.Checked)
            {
                games = games.OrderByDescending(x => x.PlaytimeForever).ToList();
                DisplayGameList(games);
            }
            else if (radioSortTimeA.Checked)
            {
                games = games.OrderBy(x => x.PlaytimeForever).ToList();
                DisplayGameList(games);
            }
            else if (radioSortNameD.Checked)
            {
                games = games.OrderByDescending(x => x.Name).ToList();
                DisplayGameList(games);
            }
            DisplayGameList(games);
        }

        private void DisplayGameList(List<OwnedGameModel> games)
        {
            gamesList.Items.Clear();
            foreach (var game in games)
            {
                if (!checkBox1.Checked || game.PlaytimeForever.CompareTo(timespan) <= 0)
                {
                    gamesList.Items.Add(new ListViewItem(new string[] { game.Name, game.PlaytimeForever.ToString() }));
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
                string gamename = gamesList.Items[game].Text;
                gamesList.Select();
                int index = gamesList.Items.IndexOf(gamesList.Items[game]);
                gamesList.Items[index].Selected = true;
                gamesList.Items[index].Focused = true;
                gamesList.EnsureVisible(index);
                randomGameBox.Text = gamename;
                if (checkBox2.Enabled)
                {
                    if(!File.Exists("game.txt"))
                        File.Create("game.txt").Close();
                    File.WriteAllText("game.txt", gamename.Substring(gamename.IndexOf('|') + 1));
                }
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

        private void radioSortNameA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSortNameA.Checked)
            {
                games = games.OrderBy(x => x.Name).ToList();
                DisplayGameList(games);
            }
        }

        private void radioSortTimeD_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSortTimeD.Checked)
            {
                games = games.OrderByDescending(x => x.PlaytimeForever).ToList();
                DisplayGameList(games);
            }
        }

        private void radioSortTimeA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSortTimeA.Checked)
            {
                games = games.OrderBy(x => x.PlaytimeForever).ToList();
                DisplayGameList(games);
            }
        }

        private void radioSortNameD_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSortNameD.Checked)
            {
                games = games.OrderByDescending(x => x.Name).ToList();
                DisplayGameList(games);
            }
        }
    }
}
