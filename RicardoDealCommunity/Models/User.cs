// File: User.cs
// Author: Kingamattack
// Date: 12/7/2018

namespace RicardoDealCommunity.Models
{
    public class User
    {
        public string Username { get; set; }

        public int Id { get; set; } = 10;

        public User()
        {
            Username = "Kingamattack";
        }
    }
}