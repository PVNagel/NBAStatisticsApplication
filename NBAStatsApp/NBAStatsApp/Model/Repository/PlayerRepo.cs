using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using NBAStatsApp.API.API;
using System.Threading;

namespace NBAStatsApp.Model.Repository
{
    public class PlayerRepo
    {
        List<Player> players = new List<Player>();
        
        public Player GetById(int id)
        {
            foreach (Player player in players)
            {
                if (player.id == id)
                {
                    return player;
                }
            }
            throw new Exception("Player does not exist in list.");
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

                    Thread.Sleep(100);
                }
            }
        }
    }
}
