using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoFastTaxCalc
{
    internal class Calculate
    {
        public void CalcTax()
        {
            switch (Globals.option)
            {
                case "pit2022":
                    if (Globals.income <= 30000)
                        Globals.tax = 0;
                    else if (Globals.income <= 120000)
                        Globals.tax = (Globals.income * 0.12m) - 3600m;
                    else
                        Globals.tax = 10860m + (0.32m * (Globals.income - 120000m));
                    break;
                case "pit2020":
                    if (Globals.income <= 8000)
                        Globals.tax = 0;
                    else if (Globals.income <= 13000)
                        Globals.tax = (Globals.income * 0.17m) - (1360m - (834.88m * ((Globals.income - 8000m) / 5000m)));
                    else if (Globals.income <= 85528)
                        Globals.tax = (Globals.income * 0.17m) - 525.12m;
                    else if (Globals.income <= 127000)
                        Globals.tax = (14539.76m + (0.32m * (Globals.income - 85528m))) -
                                       (525.12m - ((525.12m * (Globals.income - 85528m)) / 41472m));
                    else
                        Globals.tax = 14539.76m + (0.32m * (Globals.income - 85528m));
                    break;
                case "pit2019":
                    if (Globals.income <= 8000)
                        Globals.tax = 0;
                    else if (Globals.income <= 13000)
                        Globals.tax = (Globals.income * 0.1775m) - (1420m - (871.70m * ((Globals.income - 8000m) / 5000m)));
                    else if (Globals.income <= 85528)
                        Globals.tax = (Globals.income * 0.1775m) - 548.30m;
                    else if (Globals.income <= 127000)
                        Globals.tax = (15181.22m + (0.32m * (Globals.income - 85528m))) -
                                       (548.30m - ((548.30m * (Globals.income - 85528m)) / 41472m));
                    else
                        Globals.tax = 15181.22m + (0.32m * (Globals.income - 85528m));
                    break;

                case "pit2018":
                    if (Globals.income <= 8000)
                        Globals.tax = 0;
                    else if (Globals.income <= 13000)
                        Globals.tax = (Globals.income * 0.18m) - (1440m - (883.98m * ((Globals.income - 8000m) / 5000m)));
                    else if (Globals.income <= 85528)
                        Globals.tax = (Globals.income * 0.18m) - 556.02m;
                    else if (Globals.income <= 127000)
                        Globals.tax = (15395.04m + (0.32m * (Globals.income - 85528m))) -
                                       (556.02m - ((556.02m * (Globals.income - 85528m)) / 41472m));
                    else
                        Globals.tax = 15395.04m + (0.32m * (Globals.income - 85528m));
                    break;

                case "pit2017":
                    if (Globals.income <= 6600)
                        Globals.tax = 0;
                    else if (Globals.income <= 11000)
                        Globals.tax = (Globals.income * 0.18m) - (1118m - (639.98m * ((Globals.income - 6600m) / 4400m)));
                    else if (Globals.income <= 85528)
                        Globals.tax = (Globals.income * 0.18m) - 556.02m;
                    else if (Globals.income <= 127000)
                        Globals.tax = (15395.04m + (0.32m * (Globals.income - 85528m))) -
                                       (556.02m - ((556.02m * (Globals.income - 85528m)) / 41472m));
                    else
                        Globals.tax = 15395.04m + (0.32m * (Globals.income - 85528m));
                    break;

                case "pit2009":
                    if (Globals.income <= 3091)
                        Globals.tax = 0;
                    else if (Globals.income <= 85528)
                        Globals.tax = (Globals.income * 0.18m) - 556.02m;
                    else
                        Globals.tax = 14839.02m + (0.32m * (Globals.income - 85528m));
                    break;

                case "pit2008":
                    if (Globals.income <= 3089)
                        Globals.tax = 0;
                    else if (Globals.income <= 44490)
                        Globals.tax = (Globals.income * 0.19m) - 586.85m;
                    else if (Globals.income <= 85528)
                        Globals.tax = 7866.25m + (0.30m * (Globals.income - 44490m));
                    else
                        Globals.tax = 20177.65m + (0.40m * (Globals.income - 85528m));
                    break;

                case "pit2007":
                    if (Globals.income <= 3015)
                        Globals.tax = 0;
                    else if (Globals.income <= 43405)
                        Globals.tax = (Globals.income * 0.19m) - 572.54m;
                    else if (Globals.income <= 85528)
                        Globals.tax = 7674.41m + (0.30m * (Globals.income - 43405m));
                    else
                        Globals.tax = 20311.31m + (0.40m * (Globals.income - 85528m));
                    break;

                case "pit2003":
                    if (Globals.income <= 2790)
                        Globals.tax = 0;
                    else if (Globals.income <= 37024)
                        Globals.tax = (Globals.income * 0.19m) - 530.08m;
                    else if (Globals.income <= 74048)
                        Globals.tax = 6504.48m + (0.30m * (Globals.income - 37024m));
                    else
                        Globals.tax = 17611.68m + (0.40m * (Globals.income - 74048m));
                    break;

                case "pit2002":
                    if (Globals.income <= 2727)
                        Globals.tax = 0;
                    else if (Globals.income <= 37024)
                        Globals.tax = (Globals.income * 0.19m) - 518.16m;
                    else if (Globals.income <= 74048)
                        Globals.tax = 6504.40m + (0.30m * (Globals.income - 37024m));
                    else
                        Globals.tax = 17623.60m + (0.40m * (Globals.income - 74048m));
                    break;

                case "pit2001":
                    if (Globals.income <= 2596)
                        Globals.tax = 0;
                    else if (Globals.income <= 37024)
                        Globals.tax = (Globals.income * 0.19m) - 493.32m;
                    else if (Globals.income <= 74048)
                        Globals.tax = 6541.24m + (0.30m * (Globals.income - 37024m));
                    else
                        Globals.tax = 17648.44m + (0.40m * (Globals.income - 74048m));
                    break;

                case "pit2000":
                    if (Globals.income <= 2295)
                        Globals.tax = 0;
                    else if (Globals.income <= 32736)
                        Globals.tax = (Globals.income * 0.19m) - 436.20m;
                    else if (Globals.income <= 65472)
                        Globals.tax = 5783.64m + (0.30m * (Globals.income - 32736m));
                    else
                        Globals.tax = 15604.44m + (0.40m * (Globals.income - 65472m));
                    break;

                case "pit1999":
                    if (Globals.income <= 2077)
                        Globals.tax = 0;
                    else if (Globals.income <= 29624)
                        Globals.tax = (Globals.income * 0.19m) - 394.80m;
                    else if (Globals.income <= 59248)
                        Globals.tax = 5233.76m + (0.30m * (Globals.income - 29624m));
                    else
                        Globals.tax = 14120.96m + (0.40m * (Globals.income - 59248m));
                    break;

                case "pit1998":
                    if (Globals.income <= 1771)
                        Globals.tax = 0;
                    else if (Globals.income <= 25252)
                        Globals.tax = (Globals.income * 0.19m) - 336.60m;
                    else if (Globals.income <= 50504)
                        Globals.tax = 4461.28m + (0.30m * (Globals.income - 25252m));
                    else
                        Globals.tax = 12036.88m + (0.40m * (Globals.income - 50504m));
                    break;

                case "pit1997":
                    if (Globals.income <= 1391)
                        Globals.tax = 0;
                    else if (Globals.income <= 20868)
                        Globals.tax = (Globals.income * 0.20m) - 278.20m;
                    else if (Globals.income <= 41736)
                        Globals.tax = 3895.40m + (0.32m * (Globals.income - 20868m));
                    else
                        Globals.tax = 10573.16m + (0.44m * (Globals.income - 41736m));
                    break;

                case "pit1996":
                    if (Globals.income <= 1040)
                        Globals.tax = 0;
                    else if (Globals.income <= 16380)
                        Globals.tax = (Globals.income * 0.21m) - 218.40m;
                    else if (Globals.income <= 41736)
                        Globals.tax = 3221.40m + (0.33m * (Globals.income - 16380m));
                    else
                        Globals.tax = 8626.80m + (0.45m * (Globals.income - 32760m));
                    break;

                case "pit1995":
                    if (Globals.income <= 788)
                        Globals.tax = 0;
                    else if (Globals.income <= 12400)
                        Globals.tax = (Globals.income * 0.21m) - 165.60m;
                    else if (Globals.income <= 24800)
                        Globals.tax = 2438.40m + (0.33m * (Globals.income - 12400m));
                    else
                        Globals.tax = 6530.40m + (0.45m * (Globals.income - 24800m));
                    break;

                case "pit1994":
                    if (Globals.income <= 5771428)
                        Globals.tax = 0;
                    else if (Globals.income <= 90800000)
                        Globals.tax = (Globals.income * 0.21m) - 1212000m;
                    else if (Globals.income <= 181600000)
                        Globals.tax = 17586000m + (0.33m * (Globals.income - 90800000m));
                    else
                        Globals.tax = 47820000m + (0.45m * (Globals.income - 181600000m));
                    break;

                case "pit1993":
                    if (Globals.income <= 4320000)
                        Globals.tax = 0;
                    else if (Globals.income <= 64800000)
                        Globals.tax = (Globals.income * 0.20m) - 864000m;
                    else if (Globals.income <= 129600000)
                        Globals.tax = 12096000m + (0.30m * (Globals.income - 64800000m));
                    else
                        Globals.tax = 31536000m + (0.40m * (Globals.income - 129600000m));
                    break;

                case "pit1992":
                    if (Globals.income <= 4320000)
                        Globals.tax = 0;
                    else if (Globals.income <= 64800000)
                        Globals.tax = (Globals.income * 0.20m) - 864000m;
                    else if (Globals.income <= 129600000)
                        Globals.tax = 12096000m + (0.30m * (Globals.income - 64800000m));
                    else
                        Globals.tax = 31536000m + (0.40m * (Globals.income - 129600000m));
                    break;

                case "flat2022":
                case "flat":
                case "cit":
                    Globals.tax = Globals.income * 0.19m;
                    break;

                case "cit9":
                    Globals.tax = Globals.income * 0.09m;
                    break;

                case "cit15":
                    Globals.tax = Globals.income * 0.15m;
                    break;

                case "cit2003":
                    Globals.tax = Globals.income * 0.27m;
                    break;

                case "cit2002":
                    Globals.tax = Globals.income * 0.28m;
                    break;

                case "cit2001":
                    Globals.tax = Globals.income * 0.28m;
                    break;

                case "cit2000":
                    Globals.tax = Globals.income * 0.3m;
                    break;
            }
                
        }
        public void calcNfz()
        {
            switch (Globals.option)
            {
                case "pit2022":
                    Globals.nfz = 0.09m * Globals.income;
                    break;

                case "flat2022":
                    Globals.nfz = 0.049m * Globals.income;
                    break;
                default:
                    Globals.nfz = null;
                    break;
            }
            if (Globals.nfz <= 0)
                Globals.nfz = 0;
        }

        public void calcSolTax()
        {
            if(Globals.option == "pit2022" || Globals.option == "flat2022" || Globals.option == "pit2020" || Globals.option == "pit2019")
            {
                Globals.soltax = 0.04m * (Globals.income - 1000000m);
            }
            else
            {
                Globals.soltax = null;
            }
            if (Globals.soltax <= 0) Globals.soltax = 0;
        }
    }
    }
