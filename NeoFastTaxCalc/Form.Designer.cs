namespace NeoFastTaxCalc
{
    partial class Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.taxSelector = new System.Windows.Forms.ListBox();
            this.incomeInput = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.taxLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.calcButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.fileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.editCut = new System.Windows.Forms.ToolStripMenuItem();
            this.editCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.editPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.incomeInput)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // taxSelector
            // 
            this.taxSelector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.taxSelector.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taxSelector.FormattingEnabled = true;
            this.taxSelector.ItemHeight = 21;
            this.taxSelector.Items.AddRange(new object[] {
            "Skala podatkowa 2022-2025",
            "Podatek liniowy od 2022",
            "Podatek liniowy",
            "Podatek CIT",
            "CIT 9%",
            "CIT 15%",
            "Skala podatkowa 2020-2021",
            "Skala podatkowa 2019",
            "Skala podatkowa 2018",
            "Skala podatkowa 2017",
            "Skala podatkowa 2009-2016",
            "Skala podatkowa 2008",
            "Skala podatkowa 2007",
            "Skala podatkowa 2003-2006",
            "CIT 2003",
            "Skala podatkowa 2002",
            "CIT 2002",
            "Skala podatkowa 2001",
            "CIT 2001",
            "Skala podatkowa 2000",
            "CIT 2000",
            "Skala podatkowa 1999",
            "Skala podatkowa 1998",
            "Skala podatkowa 1997",
            "Skala podatkowa 1996",
            "Skala podatkowa 1995",
            "Skala podatkowa 1994",
            "Skala podatkowa 1993",
            "Skala podatkowa 1992"});
            this.taxSelector.Location = new System.Drawing.Point(145, 129);
            this.taxSelector.Name = "taxSelector";
            this.taxSelector.Size = new System.Drawing.Size(251, 193);
            this.taxSelector.TabIndex = 5;
            this.taxSelector.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // incomeInput
            // 
            this.incomeInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.incomeInput.Location = new System.Drawing.Point(200, 81);
            this.incomeInput.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.incomeInput.Name = "incomeInput";
            this.incomeInput.Size = new System.Drawing.Size(150, 20);
            this.incomeInput.TabIndex = 9;
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(163, 38);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(223, 28);
            this.label.TabIndex = 10;
            this.label.Text = "Podaj dochód roczny";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(549, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileClose});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(38, 20);
            this.menuFile.Text = "Plik";
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCut,
            this.editCopy,
            this.editPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(53, 20);
            this.menuEdit.Text = "Edycja";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(57, 20);
            this.menuHelp.Text = "Pomoc";
            // 
            // taxLabel
            // 
            this.taxLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taxLabel.Location = new System.Drawing.Point(122, 335);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(0, 21);
            this.taxLabel.TabIndex = 12;
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exportButton
            // 
            this.exportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exportButton.Image = global::NeoFastTaxCalc.Properties.Resources.exportIcon;
            this.exportButton.Location = new System.Drawing.Point(366, 438);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(108, 103);
            this.exportButton.TabIndex = 8;
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // calcButton
            // 
            this.calcButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calcButton.Image = global::NeoFastTaxCalc.Properties.Resources.calcIcon;
            this.calcButton.Location = new System.Drawing.Point(219, 438);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(108, 103);
            this.calcButton.TabIndex = 7;
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoButton.Image = global::NeoFastTaxCalc.Properties.Resources.infoIcon;
            this.infoButton.Location = new System.Drawing.Point(76, 438);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(108, 103);
            this.infoButton.TabIndex = 6;
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // fileClose
            // 
            this.fileClose.Image = global::NeoFastTaxCalc.Properties.Resources.closeIcon;
            this.fileClose.Name = "fileClose";
            this.fileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.fileClose.Size = new System.Drawing.Size(162, 22);
            this.fileClose.Text = "Zamknij";
            this.fileClose.Click += new System.EventHandler(this.fileClose_Click);
            // 
            // editCut
            // 
            this.editCut.Image = ((System.Drawing.Image)(resources.GetObject("editCut.Image")));
            this.editCut.Name = "editCut";
            this.editCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.editCut.Size = new System.Drawing.Size(150, 22);
            this.editCut.Text = "Wytnij";
            this.editCut.Click += new System.EventHandler(this.editCut_Click);
            // 
            // editCopy
            // 
            this.editCopy.Image = ((System.Drawing.Image)(resources.GetObject("editCopy.Image")));
            this.editCopy.Name = "editCopy";
            this.editCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.editCopy.Size = new System.Drawing.Size(150, 22);
            this.editCopy.Text = "Kopiuj";
            this.editCopy.Click += new System.EventHandler(this.editCopy_Click);
            // 
            // editPaste
            // 
            this.editPaste.Image = global::NeoFastTaxCalc.Properties.Resources.pasteIcon;
            this.editPaste.Name = "editPaste";
            this.editPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.editPaste.Size = new System.Drawing.Size(150, 22);
            this.editPaste.Text = "Wklej";
            this.editPaste.Click += new System.EventHandler(this.editPaste_Click);
            // 
            // helpAbout
            // 
            this.helpAbout.Image = global::NeoFastTaxCalc.Properties.Resources.infoIcon;
            this.helpAbout.Name = "helpAbout";
            this.helpAbout.Size = new System.Drawing.Size(141, 22);
            this.helpAbout.Text = "O programie";
            this.helpAbout.Click += new System.EventHandler(this.helpAbout_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(549, 573);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.incomeInput);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.taxSelector);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "Form";
            this.Text = "NeoFastTaxCalc";
            ((System.ComponentModel.ISupportInitialize)(this.incomeInput)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox taxSelector;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.NumericUpDown incomeInput;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem fileClose;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem editCut;
        private System.Windows.Forms.ToolStripMenuItem editCopy;
        private System.Windows.Forms.ToolStripMenuItem editPaste;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem helpAbout;
        private System.Windows.Forms.Label taxLabel;
    }
}

