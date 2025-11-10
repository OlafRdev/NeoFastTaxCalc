using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoFastTaxCalc
{
    public static class Globals
    {
        public static decimal income { get; set; }
        public static string selectedOption { get; set; }
        public static string option { get; set; }
        public static decimal tax { get; set; }
        public static decimal? nfz { get; set; }
        public static decimal? soltax { get; set; }
        public static string desc { get; set; }
        public static string res { get; set; }

    }
}
