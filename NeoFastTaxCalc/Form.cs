using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeoFastTaxCalc
{

    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taxSelector.SelectedItem != null)
            {
                Globals.selectedOption = taxSelector.SelectedItem.ToString();
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Option opt = new Option();
            opt.Opt();
            Info info = new Info();
            info.info();
            MessageBox.Show(this, Globals.desc, "Informacje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            Globals.income = incomeInput.Value;
            Option opt = new Option();
            opt.Opt();
            Calculate calc = new Calculate();
            calc.CalcTax();
            calc.calcNfz();
            calc.calcSolTax();

            string result = $"Podatek roczny: " + Globals.tax.ToString("N2") + " zł\n";
            if (Globals.nfz.HasValue)
            {
                result += $"Składka zdrowotna (NFZ): {Globals.nfz.Value:N2} zł\n";
            }
            if (Globals.soltax.HasValue)
            {
                result += $"Danina solidarnościowa: {Globals.soltax.Value:N2} zł\n";
            }
            decimal total = Globals.tax + Globals.nfz.GetValueOrDefault() + Globals.soltax.GetValueOrDefault();
            if (total > 0)
            {
                result += $"Łącznie: {total:N2} zł";
            }

            taxLabel.Text = result;
            Globals.res = result;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.export();
        }

        private void fileClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editCut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(incomeInput.Value.ToString());
            incomeInput.Value = 0;
        }

        private void editCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(incomeInput.Value.ToString());
        }

        private void editPaste_Click(object sender, EventArgs e)
        {
            string clip = Clipboard.GetText();

            if (decimal.TryParse(clip, out decimal clipValue))
            {
                incomeInput.Value = clipValue;
            }
        }

        private void helpAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

    }
}
