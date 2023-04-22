using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsApp.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int? HeightFeet { get; set; }
        public int? HeightInches { get; set; }
        public int? WeightPounds { get; set; }
        public Team Team { get; set; }
        public string teamImagePath { get; set; }

        public Player(int id, string first_name, int? height_feet, int? height_inches, string last_name, string position, Team team, int? weight_pounds)
        {
            Id = id;
            FirstName = first_name;
            HeightFeet = height_feet;
            HeightInches = height_inches;
            LastName = last_name;
            Position = position;
            Team = team;
            if (team != null) { teamImagePath = $"/Images/Teams/{team.Name}.png"; }
            if (team == null) { teamImagePath = $"/Images/Teams/SeirinLogo.png"; }
            WeightPounds = weight_pounds ?? 0;
        }
    }
}
