using System;
namespace Dota.Core.Models
{
    public class DotaMatchDraft
    {
        public DotaHero Hero { get; set; }
        public PicksBan Draft { get; set; }
        public Team Team { get; set; }
    }
}
