using NBAStatsApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsApp.ViewModel
{
    public class PlayerViewModel
    {
        private Player player;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int? HeightFeet{ get; set; }
        public int? HeightInches { get; set; }
        public string Position { get; set; }
        public Team Team { get; set; }
        public string TeamImagePath { get; set; }
        public int? WeightPounds { get; set; }

        public PlayerViewModel(Player player)
        {
            Id = player.Id;
            FirstName = player.FirstName;
            LastName = player.LastName;
            HeightFeet = player.HeightFeet;
            HeightInches = player.HeightInches;
            Position = player.Position;
            Team = player.Team;
            TeamImagePath = player.teamImagePath;
            WeightPounds = player.WeightPounds;
        }
    }
}
