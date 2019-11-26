// File: DealService.cs
// Author: Kingamattack
// Date: 12/7/2018

using RicardoDealCommunity.Models;

using System.Linq;
using System.Collections.Generic;
using System;

namespace RicardoDealCommunity.Services
{
    public class DealService
    {
        public string username = "Kingamattack";

        private readonly List<Deal> deals;           

        public DealService()
        {
            deals = new List<Deal>
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
                    Name = "Console XBOX",
                    Grade = 309,
                    City = "London",
                    Price = 180.0,
                    Owner = "Lolo",
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
        }

        public List<Deal> GetMyDeals()
        {
            return deals.Where(deal => deal.Owner == username).ToList();
        }

        public List<Deal> GetFavorites()
        {
            return deals.Where(deal => deal.IsFavorite == true).ToList();
        }

        public List<Deal> AllDeals()
        {
            return deals;
        }

        public string[] Cities()
        {
            return new string[] { "Limoges", "Paris", "Bucharest", "Zoug", "Geneve", "Zurich" };
        }

        public Deal GetDeal()
        {
            int index = new Random().Next(0, deals.Count);

            return deals.ElementAt(index);
        }

        public void AddDeal(Deal deal)
        {
            deals.Add(deal);
        }
    }
}