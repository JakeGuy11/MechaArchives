using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechaArchives
{
    public class Team
    {
        //This will be used primarily for the json so we just need variables
        public int number;
        public int height;
        public int weight;
        public int language;
        public int rankpoints;
        public int matches;
        public string comments;
        public int auto;
        public bool cellLevel1;
        public bool cellLevel2;
        public bool cellLevel3;
        public bool spin;
        public bool colour;
        public bool under;
        public bool climb;
        public bool balance;
        public bool lift;
        public bool enabled;

        public double avgRankpoints()
        {
            try
            {
                return rankpoints / matches;
            }
            catch
            {
                return -1.0;
            }
        }
    }
}
