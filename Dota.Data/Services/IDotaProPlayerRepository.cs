using Dota.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dota.Data.Services
{
    public interface IDotaProPlayerRepository   
    {
        Task<List<DotaProPlayer>> AllProPlayers(string playerUri);
    }
}