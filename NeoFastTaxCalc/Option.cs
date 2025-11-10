using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoFastTaxCalc
{
    internal class Option
    {
        public void Opt() {
            switch (Globals.selectedOption)
            {
                case "Skala podatkowa 2022-2025":
                    Globals.option = "pit2022";
                    break;
                case "Podatek liniowy od 2022":
                    Globals.option = "flat2022";
                    break;
                case "Podatek liniowy":
                    Globals.option = "flat";
                    break;
                case "Podatek CIT":
                    Globals.option = "cit";
                    break;
                case "CIT 9%":
                    Globals.option = "cit9";
                    break;
                case "CIT 15%":
                    Globals.option = "cit15";
                    break;
                case "Skala podatkowa 2020-2021":
                    Globals.option = "pit2020";
                    break;
                case "Skala podatkowa 2019":
                    Globals.option = "pit2019";
                    break;
                case "Skala podatkowa 2018":
                    Globals.option = "pit2018";
                    break;
                case "Skala podatkowa 2017":
                    Globals.option = "pit2017";
                    break;
                case "Skala podatkowa 2009-2016":
                    Globals.option = "pit2009";
                    break;
                case "Skala podatkowa 2008":
                    Globals.option = "pit2008";
                    break;
                case "Skala podatkowa 2007":
                    Globals.option = "pit2007";
                    break;
                case "Skala podatkowa 2003-2006":
                    Globals.option = "pit2003";
                    break;
                case "CIT 2003":
                    Globals.option = "cit2003";
                    break;
                case "Skala podatkowa 2002":
                    Globals.option = "pit2002";
                    break;
                case "CIT 2002":
                    Globals.option = "cit2002";
                    break;
                case "Skala podatkowa 2001":
                    Globals.option = "pit2001";
                    break;
                case "CIT 2001":
                    Globals.option = "cit2001";
                    break;
                case "Skala podatkowa 2000":
                    Globals.option = "pit2000";
                    break;
                case "CIT 2000":
                    Globals.option = "cit2000";
                    break;
                case "Skala podatkowa 1999":
                    Globals.option = "pit1999";
                    break;
                case "Skala podatkowa 1998":
                    Globals.option = "pit1998";
                    break;
                case "Skala podatkowa 1997":
                    Globals.option = "pit1997";
                    break;
                case "Skala podatkowa 1996":
                    Globals.option = "pit1996";
                    break;
                case "Skala podatkowa 1995":
                    Globals.option = "pit1995";
                    break;
                case "Skala podatkowa 1994":
                    Globals.option = "pit1994";
                    break;
                case "Skala podatkowa 1993":
                    Globals.option = "pit1993";
                    break;
                case "Skala podatkowa 1992":
                    Globals.option = "pit1992";
                    break;
            }
        }
        
    }
}
