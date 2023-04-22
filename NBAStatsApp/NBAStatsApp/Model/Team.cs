using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsApp.Model
{
    public class Team
    {
        public int Id { get; set; }
        public string Abbreviation { get; set; }
        public string City { get; set; }
        public string Conference { get; set; }
        public string Division { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }

        public Team(int id, string abbreviation, string city, string conference, string division, string full_name, string name)
        {
            this.Id = id;
            this.Abbreviation = abbreviation;
            this.City = city;
            this.Conference = conference;
            this.Division = division;
            this.FullName = full_name;
            this.Name = name;
        }
    }
}
