using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Dota.Core.Models;

namespace Dota.Data.Services
{
    public class DotaMatchInfoRepository : IDotaMatchInfoRepository
    {
        List<DotaHero> IDotaMatchInfoRepository.GetHeroesInMatch(DotaHero[] allHeroes, DotaMatchInfo matchInfo)
        {
            var heroesInMatch = new List<DotaHero>();
            foreach (var player in matchInfo.Players)
            {
                var heroInMatch = allHeroes.ToList().Find(hero => hero.Id == player.HeroId);
                heroesInMatch.Add(heroInMatch);
            }
            return heroesInMatch;
        }
        //TODO GetAllMatchInfo should take in a matchID 
        async Task<DotaMatchInfo> IDotaMatchInfoRepository.GetAllMatchInfo(string matchUri)
        {
            var client = new HttpClient();
            Task<string> getDotaStringTask = client.GetStringAsync(matchUri);
            string dotaMatchJson = await getDotaStringTask;
            var matchInfo = DotaMatchInfo.FromJson(dotaMatchJson);

            return matchInfo;
        }
        async Task<IEnumerable<DotaLiveMatch>> IDotaMatchInfoRepository.GetLiveMatches(string LiveUri)
        {
            var client = new HttpClient();
            Task<string> getDotaStringTask = client.GetStringAsync(LiveUri);
            string dotaLiveMatchJson = await getDotaStringTask;
            List<DotaLiveMatch> liveMatches = DotaLiveMatch.FromJson(dotaLiveMatchJson).ToList();

            return liveMatches.OrderByDescending(m => m.AverageMmr);
        }

        DotaHero IDotaMatchInfoRepository.PlayerHero(long playerHeroId, List<DotaHero> dotaHeroes)
        {
            foreach (var hero in dotaHeroes)
            {
                if (playerHeroId == hero.Id)
                {
                    return hero;
                }
            }
            return null;
        }

        List<HeroAndPlayer> IDotaMatchInfoRepository.HeroesPlayedByPlayer(List<DotaHero> dotaHeroes, Players[] players)
        {
            List<HeroAndPlayer> playerPlayedHero = new List<HeroAndPlayer>();
            foreach (var player in players)
            {
                var hero = dotaHeroes.Find(h => h.Id == player.HeroId);
                var playerHero = new HeroAndPlayer()
                {
                    Player = player,
                    Hero = hero
                };
                playerPlayedHero.Add(playerHero);

            }


            return playerPlayedHero;
        }


        public IEnumerable<DotaLiveMatchInfo> HeroesInLiveMatches(List<DotaHero> dotaheroes, List<DotaLiveMatch> dotaLiveMatches)
        {
            List<DotaLiveMatchInfo> playerPlayedHero = new List<DotaLiveMatchInfo>();
            List<DotaHero> heroes = new List<DotaHero>();
            foreach (var match in dotaLiveMatches)
            {
                foreach (var player in match.Players.ToList())
                {



                    var hero = dotaheroes.Find(h => h.Id == player.HeroId);
                    if(string.IsNullOrEmpty(player.Name))
                    {
                        player.Name = "Name Not Found";
                    }
                    heroes.Add(hero);
                }
                var playerHero = new DotaLiveMatchInfo()
                {
                    Hero = heroes,
                    
                    Matches = match
                };
                playerPlayedHero.Add(playerHero);

            }

            IEnumerable<DotaLiveMatchInfo> matchinfowithheroes = playerPlayedHero;
            return matchinfowithheroes;
        }



        //List<DotaMatchDraft> DraftOfMatch(PicksBan[] draftTiming, List<DotaHero> dotaHeroes)
        //{
        //    foreach (var pick in draftTiming)
        //    {
        //        pick

        //        var draftData = new DotaMatchDraft
        //        {
        //            Draft =
        //            Hero =
        //        }

        //    }


        //return null;
        //}



    }

}
