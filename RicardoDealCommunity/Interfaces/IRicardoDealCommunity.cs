// File: IRicardoDealCommunity.cs
// Author: Kingamattack
// Date: 13/7/2018

using System.Collections.Generic;
using System.Threading.Tasks;

using RicardoDealCommunity.Models;

namespace RicardoDealCommunity.Interfaces
{
    public interface IRicardoDealCommunity
    {
        Task<List<Deal>> GetHotDeals();
        Task<List<Deal>> GetNewDeals();
        Task<Deal> GetDeal();
        Task<bool> AddDeal(Deal deal);
        Task<bool> SaveToFavorites(Deal deal);
        Task<List<Deal>> GetFavoriteDeals(int user);
    }
}