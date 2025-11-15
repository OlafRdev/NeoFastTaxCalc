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
            try
            {
                if (Globals.res == null || Globals.res.Trim().Length == 0)
                {
                    MessageBox.Show("Brak danych do eksportu. Najpierw oblicz podatek.", "Błąd",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string fileName = "Podatek " + DateTime.Now.ToString("dd-MM-yyyy HH-mm") + ".txt";
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Pliki tekstowe (*.txt)|*.txt";
                    sfd.Title = "Zapisz wynik do pliku";
                    sfd.FileName = fileName;

                    if (sfd.ShowDialog() != DialogResult.OK) return;

                    string currentScale = Globals.selectedOption;
                    string exportTax = "Skala podatkowa: " + currentScale + "\n" + Globals.res;

                    System.IO.File.WriteAllText(sfd.FileName, exportTax);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
