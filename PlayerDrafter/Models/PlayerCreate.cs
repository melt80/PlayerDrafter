using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDrafter.Models
{
    public class PlayerCreate
    {
        public int Rank { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public int Price { get; set; }
        public bool Drafted { get; set; }
    }
}
