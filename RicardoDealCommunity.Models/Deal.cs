﻿// File: Deal.cs
// Author: Kingamattack
// Date: 12/7/2018

using System;

namespace RicardoDealCommunity.Models
{
    public class Deal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public double Price { get; set; }
        public string Owner { get; set; }
        public int Grade { get; set; }
        public string Picture { get; set; }
        public bool IsFavorite { get; set; }
    }
}