using System;
using System.Collections.Generic;

namespace PuppetGame.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public string HatChoice { get; set; }
        public string EyeChoice { get; set; }
        public string ArmChoice { get; set; }
        public string LegChoice { get; set; }
        public int? Turns { get; set; }
        public int? Pot { get; set; }
        public int? PerTurn { get; set; }

        public int? Total {get; set;}

    }
}
