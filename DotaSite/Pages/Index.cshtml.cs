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
        
        private readonly ILogger<IndexModel> _logger;
        private readonly IDotaLeagueRepository _idotaLeagueRepository;
        private readonly IDotaMatchInfoRepository _idotaMatchInfoRepository;
        private readonly IDotaHeroRepository _idotaHeroRepository;
        private readonly IConfiguration _configuration;
        

        private DotaLeague[] Leagues { get; set; }
        private List<DotaHero> DotaHeroes { get; set; }
        private Players[] Players { get; set; }
        private DotaHero PlayerHero { get; set; }
        public List<HeroAndPlayer> PlayerHeros { get; set; }
        public IndexModel
            (
            ILogger<IndexModel> logger,
            IDotaLeagueRepository idotaLeagueRepository,
            IDotaMatchInfoRepository idotaMatchInfoRepository,
            IDotaHeroRepository idotaHeroRepository, IConfiguration configuration)
        {
            _logger = logger;
            _idotaLeagueRepository = idotaLeagueRepository;
            _idotaMatchInfoRepository = idotaMatchInfoRepository;
            _idotaHeroRepository = idotaHeroRepository;
            _configuration = configuration;
        }

        public async Task OnGetAsync()
        {
            var heroUri = _configuration.GetValue<string>("DotaSettings:DotaHeroes");
            var leagueUri = _configuration.GetValue<string>("DotaSettings:DotaLeagues");
            var matchUri = _configuration.GetValue<string>("DotaSettings:DotaMatches");

            var allHeroes = await _idotaHeroRepository.GetDotaHeroesAsync(heroUri);
            var matchInfo = await _idotaMatchInfoRepository.GetAllMatchInfo(matchUri);
            var players = matchInfo.Players;
            var pickedHeroes = _idotaMatchInfoRepository.GetHeroesInMatch(allHeroes, matchInfo);
            PlayerHeros = _idotaMatchInfoRepository.HeroesPlayedByPlayer(pickedHeroes,players);
            Leagues = await _idotaLeagueRepository.GetAllLeaguesAsync(leagueUri);
            DotaHeroes = _idotaMatchInfoRepository.GetHeroesInMatch(allHeroes, matchInfo);
            
          

        }
    }
}
