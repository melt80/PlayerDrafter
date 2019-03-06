using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDrafter.Models
{
    public static class PlayerCreateExtensions
    {
        public static IEnumerable<PlayerCreate> ToPlayerCreate(this IEnumerable<string> source)
        {
            foreach (var line in source)
            {
                var columns = line.Split(',');

                yield return new PlayerCreate
                {
                    Rank = int.Parse(columns[0]),
                    FirstName = columns[1],
                    LastName = columns[2],
                    Team = columns[3],
                    Position = columns[4],
                    Price = int.Parse(columns[5]),
                    Drafted = false
                };
            }
        }
    }
}
