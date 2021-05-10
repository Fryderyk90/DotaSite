using Dota.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dota.Data.Services
{
    public interface IDotaTeamRepository
    {
        Task<List<DotaTeam>> AllTeamsAsync(string teamUri);
        Task<List<DotaProPlayer>> PlayersInTeam(long teamId, List<DotaProPlayer> proPlayers);
    }

}