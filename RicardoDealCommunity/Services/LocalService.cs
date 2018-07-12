// File: LocalService.cs
// Author: Kingamattack
// Date: 13/7/2018

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using RicardoDealCommunity.Interfaces;
using RicardoDealCommunity.Models;

namespace RicardoDealCommunity.Services
{
    public class LocalService : IRicardoDealCommunity
    {
        public Task<bool> AddDeal(Deal deal)
        {
            throw new NotImplementedException();
        }

        public Task<Deal> GetDeal()
        {
            throw new NotImplementedException();
        }

        public Task<List<Deal>> GetFavoriteDeals(int user)
        {
            throw new NotImplementedException();
        }

        public Task<List<Deal>> GetHotDeals()
        {
            throw new NotImplementedException();
        }

        public Task<List<Deal>> GetNewDeals()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveToFavorites(Deal deal)
        {
            throw new NotImplementedException();
        }
    }
}