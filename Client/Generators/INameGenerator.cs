﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Generators
{
    interface INameGenerator
    {
        string Name {get;}
        string Generate();
    }
}
