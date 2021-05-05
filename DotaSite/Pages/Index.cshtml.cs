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

        public DotaLeague[] Leagues { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IDotaLeagueRepository dotaLeagueRepository)
        {
            _logger = logger;
            _DotaLeagueRepository = dotaLeagueRepository;
        }

        public async Task OnGetAsync()
        {
             Leagues = await _DotaLeagueRepository.GetAllLeguesAsync();
        }
    }
}
