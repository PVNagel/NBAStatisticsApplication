using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using HtmlAgilityPack;
using Microsoft.VisualBasic;
using System.Windows.Controls;
using Newtonsoft.Json;
using NBAStatsApp.API;

namespace NBAStatsApp.Model.Repository
{
    public class PlayerRepo
    {
        List<Player> players = new List<Player>();

        public void API()
        {
            using (HttpClient client = new HttpClient())
            {
                Uri endpoint = new Uri("https://www.balldontlie.io/api/v1/players");
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;

                Root playerList = JsonConvert.DeserializeObject<Root>(json);
                players = playerList.data;
            }
        }
        public List<Player> GetAll()
        {
            return players;
        }
    }
}
