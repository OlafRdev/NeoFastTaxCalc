using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeoFastTaxCalc
{
    internal class Export
    {
        public void export()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Pliki tekstowe (*.txt)|*.txt";
                sfd.Title = "Zapisz wynik do pliku";
                sfd.FileName = "Podatek.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, Globals.res);
                }
            }
        }
    }
}
