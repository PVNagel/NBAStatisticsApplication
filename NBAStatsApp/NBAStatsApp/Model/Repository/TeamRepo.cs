using NBAStatsApp.API;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsApp.Model.Repository
{
    public class TeamRepo
    {
        List<Team> teams = new List<Team>();

        public TeamRepo()
        {
            using (HttpClient client = new HttpClient())
            {
                Uri endpoint = new Uri("https://www.balldontlie.io/api/v1/teams");
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;

            }
        }
    }
}
