using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGamePicker
{
    class GamePickerConfig
    {
        [JsonProperty("apikey")]
        internal string ApiKey = "Your API key here";
        // DO NOT FILL THIS IN. EDIT YOUR CONFIGURATION FILE (config.json)

        [JsonProperty("userid")]
        internal ulong UserId = 0;
    }
}
