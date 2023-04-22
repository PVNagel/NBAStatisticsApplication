using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading;
using NBAStatsApp.API;
using System.Linq;
using System.Threading.Tasks;

namespace NBAStatsApp.Model.Repository
{
    public class PlayerRepo
    {
        List<Player> players = new List<Player>();

        public static async Task<Player> GetPlayerById(int playerId)
        {
            string apiUrl = $"https://www.balldontlie.io/api/v1/players/{playerId}";

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var player = JsonConvert.DeserializeObject<Player>(content);
                    return player;
                }
                else
                {
                    throw new Exception($"Error retrieving player with ID {playerId}. Status code: {response.StatusCode}");
                }
            }
        }

        public List<Player> GetAll()
        {
            return players;
        }

        public void Add(Player player)
        {
            players.Add(player);
        }

        public void Delete(Player player)
        {
            players.Remove(player);
        }

        public void PlayerAPI()
        {
            int page = 0;
            int totalPages = 1;

            UriBuilder builder = new UriBuilder();
            builder.Scheme = "https";
            builder.Host = "balldontlie.io";
            builder.Path = "/api/v1/players";

            using (HttpClient client = new HttpClient())
            {
                while (page < totalPages)
                {
                    builder.Query = "?per_page=100&page=" + page;
                    Uri uri = builder.Uri;

                    var result = client.GetAsync(uri).Result;
                    var json = result.Content.ReadAsStringAsync().Result;

                    Root playerList = JsonConvert.DeserializeObject<Root>(json);
                    players.AddRange(playerList.data);

                    totalPages = playerList.meta.total_pages;
                    page++;

                    Thread.Sleep(250);
                }
            }
        }

        //public async Task PlayerStatsAPIAsync()
        //{
        //    UriBuilder builder = new UriBuilder();
        //    builder.Scheme = "https";
        //    builder.Host = "balldontlie.io";
        //    builder.Path = "/api/v1/stats";

        //    using (HttpClient client = new HttpClient())
        //    {
        //        foreach (Player player in players)
        //        {
        //                builder.Query = $"season_averages?season=2018&player_ids[]={player.Id}";
        //                Uri uri = builder.Uri;

        //                var result = await client.GetAsync(uri);
        //                var json = await result.Content.ReadAsStringAsync();

        //                Root statsList = JsonConvert.DeserializeObject<Root>(json);
        //                playerStats.AddRange(statsList.statsData);

        //                await Task.Delay(500);
        //        }
        //    }
        //}
    }
}
