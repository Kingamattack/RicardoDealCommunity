// File: LocalData.cs
// Author: Kingamattack
// Date: 18/7/2018
using System;

using System.Collections.Generic;

using RicardoDealCommunity.Models;

namespace RicardoDealCommunity.Services
{
    public static class LocalData
    {
        public static List<Deal> GetDeals ()
        {
            return new List<Deal> 
            { 
                new Deal 
                { 
                    Name = "Deal 1", City = "Bucharest", Price = 100.0, Owner = "Kingamattack"
                }, 
                new Deal 
                { 
                    Name = "Deal 2", City = "Paris", Price = 20.0, Owner = "Lolo"
                }, 
                new Deal 
                { 
                    Name = "Deal 3", City = "Limoges", Price = 340.0, Owner = "Kingamattack"
                } 
            };
        }

        public static List<Deal> GetFavorites()
        {
            return new List<Deal>
            {
                new Deal
                {
                    Name = "Deal 1", City = "Bucharest", Price = 100.0
                },
                new Deal
                {
                    Name = "Deal 3", City = "Limoges", Price = 340.0
                }
            };
        }
    }
}