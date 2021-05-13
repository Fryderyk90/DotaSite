using Dota.Core.Models;
using Dota.Data.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotaSite.Pages.Teams
{
    public class AllTeams : PageModel
    {
        private readonly IDotaProPlayerRepository _proPlayers;
        private readonly IDotaTeamRepository _teamRepository;
        private readonly IConfiguration _configuration;

        public List<DotaTeam> DotaTeams { get; set; }
        public List<DotaTeamRoster> Roster { get; set; }


        public AllTeams(IDotaTeamRepository teamRepository, IConfiguration configuration, IDotaProPlayerRepository proPlayers)
        {
            _teamRepository = teamRepository;
            _configuration = configuration;
            _proPlayers = proPlayers;
        }

        public async Task OnGetAsync()
        {

            var teamUri = _configuration.GetValue<string>("DotaSettings:DotaTeams");
            var proPlayerUri = _configuration.GetValue<string>("DotaSettings:DotaProPlayers");
            DotaTeams = await _teamRepository.AllTeamsAsync(teamUri);
            var players = await _proPlayers.AllProPlayers(proPlayerUri);
            Roster =  _teamRepository.TeamRoster(DotaTeams, players);
        }
    }
}