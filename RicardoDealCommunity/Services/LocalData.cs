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
        public static string username = "Kingamattack";

        static List<Deal> deals = new List<Deal> 
        {
            new Deal 
            { 
                Name = "Console PS4", 
                Grade = 10,
                City = "Bucharest", 
                Price = 100.0, 
                Owner = "Kingamattack",
                Description = "Awesome deal description"
            }, 
            new Deal 
            { 
                Name = "Television", 
                Grade = 55,
                City = "Paris", 
                Price = 20.0, 
                Owner = "Lolo",
                Description = "Awesome deal description"
            }, 
            new Deal 
            { 
                Name = "Snickers", 
                Grade = 890,
                City = "Limoges", 
                Price = 340.0, 
                Owner = "Tamedia",
                Description = "Awesome deal description"
            },
            new Deal 
            { 
                Name = "MacBook Pro", 
                Grade = 12,
                City = "Bucharest",
                IsFavorite = true,
                Price = 66.0, 
                Owner = "Bill",
                Description = "Awesome deal description"
            }, 
            new Deal 
            { 
                Name = "Shirt green", 
                Grade = 345,
                City = "Paris", 
                Price = 20.0, 
                Owner = "Tamedia",
                Description = "Awesome deal description"
            }, 
            new Deal 
            { 
                Name = "Basket ball", 
                Grade = 2456,
                City = "Limoges", 
                Price = 17.0, 
                Owner = "Lolo",
                Description = "Awesome deal description"
            },
            new Deal 
            { 
                Name = "iPhone X", 
                Grade = 876,
                City = "Bucharest", 
                Price = 980.0, 
                Owner = "Kingamattack",
                Description = "Awesome deal description"
            }, 
            new Deal 
            { 
                Name = "Sac Eastpak", 
                Grade = 23,
                City = "Paris",
                IsFavorite = true,
                Price = 50.0, 
                Owner = "Tamedia",
                Description = "Awesome deal description"
            }, 
            new Deal 
            { 
                Name = "Cheese", 
                Grade = 987,
                City = "Limoges",
                IsFavorite = true,
                Price = 43.0, 
                Owner = "Lolo",
                Description = "Awesome deal description"
            },
            new Deal 
            { 
                Name = "Rayban Glasses", 
                Grade = 6667,
                City = "Limoges", 
                Price = 100.0, 
                Owner = "Kingamattack",
                Description = "Awesome deal description"
            }
        };

        public static List<Deal> GetMyDeals ()
        {
            var myDeals = deals.Where(deal => deal.Owner == "Kingamattack").ToList();
            return myDeals;
        }

        public static List<Deal> GetFavorites()
        {
            var favoritesDeals = deals.Where(deal => deal.IsFavorite == true).ToList();
            return favoritesDeals;
        }

        public static List<Deal> AllDeals()
        {
            return deals;
        }

        public static string[] Cities()
        {
            return new string[]{ "Limoges", "Paris", "Bucharest", "Zoug", "Geneve", "Zurich" };
        }

        public static Deal GetDeal()
        {
            int index = new Random().Next(0, deals.Count);

            return deals.ElementAt(index);
        }

        public static void AddDeal(Deal deal)
        {
            deals.Add(deal);
        }
    }
}