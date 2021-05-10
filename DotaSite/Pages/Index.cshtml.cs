using Dota.Core.Models;
using Dota.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DotaSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<IndexModel> _logger;



        //interfaces 
        private readonly IDotaLeagueRepository _idotaLeagueRepository;
        private readonly IDotaMatchInfoRepository _idotaMatchInfoRepository;
        private readonly IDotaHeroRepository _idotaHeroRepository;
        private readonly IDotaTeamRepository _idotaTeamRepository;
        private readonly IDotaProPlayerRepository _idotaProPlayerRepository;
        
        

        private DotaLeague[] Leagues { get; set; }
        private List<DotaHero> DotaHeroes { get; set; }
        private Players[] Players { get; set; }
        private DotaHero PlayerHero { get; set; }
        public List<HeroAndPlayer> PlayerHeros { get; set; }
        public List<DotaTeam> DotaTeams { get; set; }
        public List<DotaTeamRoster> Roster { get; set; }
        public  IEnumerable<DotaLiveMatchInfo> HeroesInLive { get; set; }

        public IEnumerable<DotaLiveMatch> LiveMatches { get; set; } 
        public IndexModel
            (
            ILogger<IndexModel> logger,
            IDotaLeagueRepository idotaLeagueRepository,
            IDotaMatchInfoRepository idotaMatchInfoRepository,
            IDotaHeroRepository idotaHeroRepository, IConfiguration configuration,
            IDotaTeamRepository idotaTeamRepository,           
            IDotaProPlayerRepository idotaProPlayerRepository
            )
        {
            _logger = logger;
            _idotaLeagueRepository = idotaLeagueRepository;
            _idotaMatchInfoRepository = idotaMatchInfoRepository;
            _idotaHeroRepository = idotaHeroRepository;
            _configuration = configuration;
            _idotaTeamRepository = idotaTeamRepository;
            _idotaProPlayerRepository = idotaProPlayerRepository;
        }

        public async Task OnGetAsync()
        {
            //Uris
            var heroUri = _configuration.GetValue<string>("DotaSettings:DotaHeroes");
            var leagueUri = _configuration.GetValue<string>("DotaSettings:DotaLeagues");
            var matchUri = _configuration.GetValue<string>("DotaSettings:DotaMatches");
            var teamUri = _configuration.GetValue<string>("DotaSettings:DotaTeams");
            var proPlayerUri = _configuration.GetValue<string>("DotaSettings:DotaProPlayers");
            var liveUri = _configuration.GetValue<string>("DotaSettings:DotaLiveMatch");

            var allHeroes = await _idotaHeroRepository.GetDotaHeroesAsync(heroUri);
            //var matchInfo = await _idotaMatchInfoRepository.GetAllMatchInfo(matchUri);
            //var players = matchInfo.Players;
            //var pickedHeroes = _idotaMatchInfoRepository.GetHeroesInMatch(allHeroes, matchInfo);
            //var allProPlayers =
            //PlayerHeros = _idotaMatchInfoRepository.HeroesPlayedByPlayer(pickedHeroes,players);
            //Leagues = await _idotaLeagueRepository.GetAllLeaguesAsync(leagueUri);
            //DotaHeroes = _idotaMatchInfoRepository.GetHeroesInMatch(allHeroes, matchInfo);
            // DotaTeams = await _idotaTeamRepository.AllTeamsAsync(teamUri);
            //var proPlayers = await _idotaProPlayerRepository.AllProPlayers(proPlayerUri);
            //Roster = _idotaTeamRepository.TeamRoster(DotaTeams, proPlayers);
            LiveMatches = await _idotaMatchInfoRepository.GetLiveMatches(liveUri);
          
            HeroesInLive = _idotaMatchInfoRepository.HeroesInLiveMatches(allHeroes.ToList(), LiveMatches.ToList());
        }
    }
}
