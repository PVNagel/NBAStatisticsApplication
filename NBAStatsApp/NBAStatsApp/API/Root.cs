using NBAStatsApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsApp.API
{
    public class Root
    {
        public List<Player> data { get; set; }
        public Meta meta { get; set; }
    }
}
