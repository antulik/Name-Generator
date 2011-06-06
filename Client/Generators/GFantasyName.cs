using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Generators
{
    public class GFantasyName : INameGenerator
    {
        
        public string Name
        {
            get
            {
                return "Fantasy Name";
            }
        }

        public string Generate()
        {
            var name = string.Empty;
            var rand = new Random();


            var prefix_male = WordsCatalogue.fantasy_male;
            var prefix_female = WordsCatalogue.fantasy_female;
            var suffix = WordsCatalogue.fantasy_surname;
            var n1m = (int)(rand.NextDouble() * prefix_male.Length);
            var n1f = (int)(rand.NextDouble() * prefix_female.Length);
            var n2 = (int)(rand.NextDouble() * suffix.Length);
            var n2ekstra = (int)(rand.NextDouble() * suffix.Length);
            var prename_male = Utilities.UppercaseFirst(prefix_male[n1m]);
            var prename_female = Utilities.UppercaseFirst(prefix_female[n1f]);
            var sufname = Utilities.UppercaseFirst(suffix[n2]);
            var extraname = Utilities.UppercaseFirst(suffix[n2ekstra]);
            var n3 = (int)(rand.NextDouble() * 100);
            if (n3 <= 12) {
                name = prename_male;
            } else if (n3 > 12 && n3 <= 20) {
                name = prename_female;
            } else if (n3 > 20 && n3 <= 50) {
                name = prename_male + " " + sufname;
            } else if (n3 > 50 && n3 <= 70) {
                name = prename_female + " " + sufname;
            } else if (n3 > 70 && n3 <= 85) {
                name = prename_male + " " + extraname + " " + sufname;
            } else if (n3 > 85) {
                name = prename_female + " " + extraname + " " + sufname;
            }

            return name;
        }
    }
}
