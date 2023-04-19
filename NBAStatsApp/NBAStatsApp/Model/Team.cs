using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsApp.Model
{
    public class Team
    {
        public int id { get; set; }
        public string abbreviation { get; set; }
        public string city { get; set; }
        public string conference { get; set; }
        public string division { get; set; }
        public string full_name { get; set; }
        public string name { get; set; }

        public Team(int id, string abbreviation, string city, string conference, string division, string full_name, string name)
        {
            this.id = id;
            this.abbreviation = abbreviation;
            this.city = city;
            this.conference = conference;
            this.division = division;
            this.full_name = full_name;
            this.name = name;
        }
    }
}
