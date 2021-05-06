using Dota.Core.Models;
using Dota.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDotaLeagueRepository _DotaLeagueRepository;
        private readonly IDotaMatchInfoRepository _IDotaMatchInfoRepository;
        private readonly IHeroRepository _IHeroRepository;


        public DotaLeague[] Leagues { get; set; }
        public List<DotaHero> DotaHeroes { get; set; }
        public Players[] Players { get; set; }
        public DotaHero PlayerHero { get; set; }
        public IndexModel
            (
            ILogger<IndexModel> logger,
            IDotaLeagueRepository dotaLeagueRepository,
            IDotaMatchInfoRepository iDotaMatchInfoRepository,
            IHeroRepository iHeroRepository
            )
        {
            _logger = logger;
            _DotaLeagueRepository = dotaLeagueRepository;
            _IDotaMatchInfoRepository = iDotaMatchInfoRepository;
            _IHeroRepository = iHeroRepository;
        }

        public async Task OnGetAsync()
        {
            var allHeroes = await _IHeroRepository.GetDotaHeroesAsync();
            var matchInfo = await _IDotaMatchInfoRepository.GetAllMatchInfo();
            var players = matchInfo.Players;
            var pickedHeroes = _IDotaMatchInfoRepository.GetHeroesInMatch(allHeroes, matchInfo);

            Leagues = await _DotaLeagueRepository.GetAllLeaguesAsync();
            DotaHeroes = _IDotaMatchInfoRepository.GetHeroesInMatch(allHeroes, matchInfo);
            foreach (var playerId in players)
            {

                PlayerHero = _IDotaMatchInfoRepository.PlayerHero(playerId.HeroId, pickedHeroes);
            }

        }
    }
}
