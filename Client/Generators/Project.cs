using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Generators
{
    public class Project : INameGenerator
    {
        
        public string Name
        {
            get
            {
                return "Project";
            }
        }

        public string Generate()
        {
            var prefix = WordsCatalogue.color.Union(WordsCatalogue.adjective).ToArray<string>();
            var suffix = WordsCatalogue.science;
            var rand = new Random();


            var n1 = (int)(rand.NextDouble() * prefix.Length);
            var n1ex = (int)(rand.NextDouble() * prefix.Length);
            if (n1ex == n1)
            {
                n1ex = n1 + 1;
            }

            var n2 = (int)(rand.NextDouble() * suffix.Length);
            var prename = Utilities.UppercaseFirst(prefix[n1]);
            var prenameex = Utilities.UppercaseFirst(prefix[n1ex]);
            var sufname = Utilities.UppercaseFirst(suffix[n2]);
            var n3 = (int)(rand.NextDouble() * 100);

            var name = string.Empty;
            if (n3 <= 15)
            {
                name = prenameex + " " + prename + " " + sufname;
            }
            else if (n3 > 15 && n3 <= 30)
            {
                name = sufname + " " + prename;
            }
            else
            {
                name = prename + " " + sufname;
            }
            return name;
        }
    }
}
