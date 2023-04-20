using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBAStatsApp.Model;

namespace NBAStatsApp.API.API
{
    public class Root
    {
        public List<Player> data { get; set; }
        public Meta meta { get; set; }
    }
}
