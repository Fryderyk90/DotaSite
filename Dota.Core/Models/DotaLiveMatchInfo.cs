using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota.Core.Models
{
    public class DotaLiveMatchInfo
    {
        public List<DotaHero> Hero { get; set; }
        public DotaLiveMatch Matches { get; set; }
    }
}
