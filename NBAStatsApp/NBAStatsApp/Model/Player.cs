using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsApp.Model
{
    public class Player
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public int? height_feet { get; set; }
        public int? height_inches { get; set; }
        public string last_name { get; set; }
        public string position { get; set; }
        public Team team { get; set; }
        public int? weight_pounds { get; set; }

        public Player(int id, string first_name, int? height_feet, int? height_inches, string last_name, string position, Team team, int? weight_pounds)
        {
            this.id = id;
            this.first_name = first_name;
            this.height_feet = height_feet;
            this.height_inches = height_inches;
            this.last_name = last_name;
            this.position = position;
            this.team = team;
            this.weight_pounds = weight_pounds;
        }
    }
}
