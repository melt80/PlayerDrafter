using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDrafter.Data
{
    public class Player
    {
        public int PlayerId { get; set; }
        public int Rank { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public int Price { get; set; }
        public bool Drafted { get; set; }
    }

    public class PlayerContext
    {
        public DbSet<Player> Players { get; set; }
    }
}
