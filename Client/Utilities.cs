﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    public static class Utilities
    {
        public static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}
