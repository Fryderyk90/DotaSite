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

        List<DotaHero> IDotaMatchInfoRepository.HeroesByTeam(List<DotaHero> heroesInMatch, Players[] players)
        {
            

            return null;
        }

    }
    
}
