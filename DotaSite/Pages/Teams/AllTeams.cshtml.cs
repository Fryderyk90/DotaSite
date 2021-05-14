using System.Collections.Generic;
using System.Threading.Tasks;
using Dota.Core.Models;
using Dota.Data.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace DotaSite.Pages.Teams
{
    public class AllTeams : PageModel
    {
        
        private readonly IConfiguration _configuration;
        private readonly IDotaTeamRepository _dotaTeams;
        private readonly IDotaHeroRepository _dotaHeros;
        private readonly IDotaProPlayerRepository _dotaPlayers;


        public List<DotaTeamRoster> DotaTeams { get; set; }
        public AllTeams
        (
            IConfiguration configuration, 
            IDotaTeamRepository dotaTeams, 
            IDotaHeroRepository dotaHeros, 
            IDotaProPlayerRepository dotaPlayers
            )
        {
            _configuration = configuration;
            _dotaTeams = dotaTeams;
            _dotaHeros = dotaHeros;
            _dotaPlayers = dotaPlayers;
        }

        public async Task OnGetAsync()
        {
            var playerUri = _configuration.GetValue<string>("Dotasettings:DotaProPlayers");
            var teamUri = _configuration.GetValue<string>("DotaSettings:DotaTeams");

            var teams = await _dotaTeams.AllTeamsAsync(teamUri);
            var players =await _dotaPlayers.AllProPlayers(playerUri);
            DotaTeams = _dotaTeams.TeamRoster(teams, players);
        }
    }
}