// File: LocalData.cs
// Author: Kingamattack
// Date: 18/7/2018
using System;

using System.Collections.Generic;
using System.Linq;
using RicardoDealCommunity.Models;

namespace RicardoDealCommunity.Services
{
    public static class LocalData
    {
        public static List<Deal> Deals()
        {
            return new List<Deal> 
            {
                new Deal 
                { 
                    Name = "Deal 1", Grade = 10,
                    City = "Bucharest", Price = 100.0, Owner = "Kingamattack"
                }, 
                new Deal 
                { 
                    Name = "Deal 2", Grade = 55,
                    City = "Paris", Price = 20.0, Owner = "Lolo"
                }, 
                new Deal 
                { 
                    Name = "Deal 3", Grade = 890,
                    City = "Limoges", Price = 340.0, Owner = "Kingamattack"
                },
                new Deal 
                { 
                    Name = "Deal ", Grade = 12,
                    City = "Bucharest", Price = 66.0, Owner = "Tamedia"
                }, 
                new Deal 
                { 
                    Name = "Deal 5", Grade = 345,
                    City = "Paris", Price = 20.0, Owner = "Lolo"
                }, 
                new Deal 
                { 
                    Name = "Deal 6", Grade = 2456,
                    City = "Limoges", Price = 17.0, Owner = "Kingamattack"
                },
                new Deal 
                { 
                    Name = "Deal 7", Grade = 876,
                    City = "Bucharest", Price = 12.0, Owner = "Kingamattack"
                }, 
                new Deal 
                { 
                    Name = "Deal 8", Grade = 23,
                    City = "Paris", Price = 5.0, Owner = "Lolo"
                }, 
                new Deal 
                { 
                    Name = "Deal 9", Grade = 987,
                    City = "Limoges", Price = 347.0, Owner = "Tamedia"
                },
                new Deal 
                { 
                    Name = "Deal 10", Grade = 6667,
                    City = "Limoges", Price = 1000.0, Owner = "Tamedia"
                }
            };
        }

        public static List<Deal> GetMyDeals ()
        {
            var deals = Deals();
            var myDeals = deals.Where(deal => deal.Owner == "Kingamattack").ToList();

            return myDeals;
        }

        public static List<Deal> GetFavorites()
        {
            var deals = Deals();
            var favoritesDeals = deals.Where(deal => deal.IsFavorite == true).ToList();

            return favoritesDeals;
        }
    }
}