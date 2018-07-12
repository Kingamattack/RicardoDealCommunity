// File: Deal.cs
// Author: Kingamattack
// Date: 12/7/2018

using System;

namespace RicardoDealCommunity.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public double Price { get; set; }
        public int Owner { get; set; }
        public string Picture { get; set; }
        public string[] Comments { get; set; }

        public Deal()
        {
            Id = default(int);
            Name = string.Empty;
            Description = string.Empty;
            Date = DateTime.Now;
            City = string.Empty;
            Price = default(double);
            Owner = 1;
            Picture = string.Empty;
        }
    }
}