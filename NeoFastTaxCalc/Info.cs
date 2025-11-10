using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoFastTaxCalc
{
    internal class Info
    {
        public void info()
        {
            switch (Globals.option)
            {
                case "pit2022":
                    Globals.desc = "Stawki PIT 12% i 32%, kwota wolna 30000%, zaś składka zdrowotna liniowa 9%. Wynik Polskiego Ładu.";
                    break;
                case "pit2020":
                    Globals.desc = "Stawki 17% i 32%, kwota wolna degresywna.";
                    break;
                case "pit2019":
                    Globals.desc = "Stawki 17,75% i 32%, kwota wolna degresywna. UWAGA: zaliczki na podatek liczy się według skali z 2009!";
                    break;
                case "pit2018":
                    Globals.desc = "Stawki 18% i 32%, kwota wolna degresywna. UWAGA: zaliczki na podatek liczy się według skali z 2009!";
                    break;
                case "pit2017":
                    Globals.desc = "Stawki 18% i 32%, kwota wolna degresywna. Skomplikowane prawo wprowadzone przez PiS. UWAGA: zaliczki na podatek liczy się według skali z 2009!";
                    break;
                case "pit2009":
                    Globals.desc = "Stawki 18% i 32%, kwota wolna 3091 zł dla wszystkich, obniżka przyjęta przez Sejm RP 27 października 2006. Obowiązująca do 2016.";
                    break;
                case "pit2008":
                    Globals.desc = "Trzy stawki 19%, 30%, 40%. Kwota wolna 3089 zł.";
                    break;
                case "pit2007":
                    Globals.desc = "Trzy stawki 19%, 30%, 40%. Kwota wolna 3015 zł.";
                    break;
                case "pit2003":
                    Globals.desc = "Trzy stawki 19%, 30%, 40%. Kwota wolna 2790 zł. Obowiązujące do 2006.";
                    break;
                case "pit2002":
                    Globals.desc = "Trzy stawki 19%, 30%, 40%. Kwota wolna 2727 zł.";
                    break;
                case "pit2001":
                    Globals.desc = "Trzy stawki 19%, 30%, 40%. Kwota wolna 2596 zł.";
                    break;
                case "pit2000":
                    Globals.desc = "Trzy stawki 19%, 30%, 40%. Kwota wolna 2295 zł.";
                    break;

                case "pit1999":
                    Globals.desc = "Trzy stawki 19%, 30%, 40%. Kwota wolna 2077 zł.";
                    break;
                case "pit1998":
                    Globals.desc = "Trzy stawki 19%, 30%, 40%. Kwota wolna 1771 zł.";
                    break;
                case "pit1997":
                    Globals.desc = "Trzy stawki 20%, 32%, 44%. Kwota wolna 1391 zł.";
                    break;
                case "pit1996":
                    Globals.desc = "Trzy stawki 21%, 33%, 45%. Kwota wolna 1040 zł.";
                    break;
                case "pit1995":
                    Globals.desc = "Trzy stawki 21%, 33%, 45%. Kwota wolna 788 zł.";
                    break;
                case "pit1994":
                    Globals.desc = "Trzy stawki 21%, 33%, 45%. Kwota wolna 5 771 428 zł. PRZED DENOMINACJĄ";
                    break;
                case "pit1993":
                    Globals.desc = "Trzy stawki 20%, 30%, 40%. Kwota wolna 4 320 000 zł. PRZED DENOMINACJĄ";
                    break;
                case "pit1992":
                    Globals.desc = "Trzy stawki 20%, 30%, 40%. Kwota wolna 4 320 000 zł. PRZED DENOMINACJĄ";
                    break;

                case "flat2022":
                    Globals.desc = "Podatek Liniowy od 2022, liniowy tylko z nazwy, obowiązuje składka NFZ 4,9% i danina solidarnościowa dla zarobków powyżej miliona.";
                    break;
                case "flat":
                    Globals.desc = "Opcja liniowego rozliczenia PIT wprowadzona w 2004 roku. 19% bez żadnych odliczeń.";
                    break;
                case "cit":
                    Globals.desc = "Podatek od osób prawnych. Stawka obowiązująca od 2004. \n UWAGA! Opodatkowaniu ulega podstawa opodatkowania, nie przychód!";
                    break;
                case "cit9":
                    Globals.desc = "Niższa stawka dla małych, zaczynających działalność przedsiębiorstw od 2019. \n UWAGA! Opodatkowaniu ulega podstawa opodatkowania, nie przychód!";
                    break;

                case "cit15":
                    Globals.desc = "Niższa stawka dla małych, zaczynających działalność przedsiębiorstw w latach 2017-2018. \n UWAGA! Opodatkowaniu ulega podstawa opodatkowania, nie przychód!";
                    break;

                case "cit2003":
                    Globals.desc = "Stawka 27%. \n UWAGA! Opodatkowaniu ulega podstawa opodatkowania, nie przychód!";
                    break;

                case "cit2002":
                    Globals.desc = "Stawka 28%. \n UWAGA! Opodatkowaniu ulega podstawa opodatkowania, nie przychód!";
                    break;

                case "cit2001":
                    Globals.desc = "Stawka 28%. \n UWAGA! Opodatkowaniu ulega podstawa opodatkowania, nie przychód!";
                    break;

                case "cit2000":
                    Globals.desc = "Stawka 30%. \n UWAGA! Opodatkowaniu ulega podstawa opodatkowania, nie przychód!";
                    break;
                default:
                    Globals.desc = "Wybierz rok lub opcję podatku";
                    break;
            }
        }
    }
}
