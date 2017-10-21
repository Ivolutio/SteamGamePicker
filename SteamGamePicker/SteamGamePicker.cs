using SteamWebAPI2.Interfaces;
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

namespace SteamGamePicker
{
    public partial class SteamGamePicker : Form
    {
        public string SteamWebAPIKey = "git gud";
        private ulong steamid;

        public SteamGamePicker()
        {
            InitializeComponent();
        }

        private void SteamGamePicker_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://steamidfinder.com/";
            linkLabel1.Links.Add(link);
        }

        private async Task RunSteamStuff()
        {
            // this will map to the ISteamUser endpoint
            var steamInterface = new SteamUser(SteamWebAPIKey);
            var player = new PlayerService(SteamWebAPIKey);
            TimeSpanConverter converter = new TimeSpanConverter();

            var playerSummaryResponse = await steamInterface.GetPlayerSummaryAsync(steamid);
            var playerSummaryData = playerSummaryResponse.Data;
            outputText.Text = playerSummaryData.Nickname;

            var timespan = converter.ConvertFromString(hourInput.Text + ":" + minuteInput.Text + ":" + secondInput.Text);
            var ownedgames = await player.GetOwnedGamesAsync(steamid, true, false);
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

        private void startButton_Click(object sender, EventArgs e)
        {
            if (steamidInput.TextLength != 17)
                return;
            steamid = ulong.Parse(steamidInput.Text);
            gamesList.Items.Clear();
            outputText.Text = "Fetching.....";
            RunSteamStuff().RunSynchronously();
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            int count = gamesList.Items.Count;
            if (count > 0)
            {
                Random random = new Random();
                int game = random.Next(0, count);
                string gamename = gamesList.Items[game].ToString();
                randomGameBox.Text = gamename;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            hourInput.Enabled = !hourInput.Enabled;
            minuteInput.Enabled = !minuteInput.Enabled;
            secondInput.Enabled = !secondInput.Enabled;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }
    }
}
