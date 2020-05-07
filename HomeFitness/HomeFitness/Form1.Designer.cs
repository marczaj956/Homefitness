namespace HomeFitness
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaĆwiczeńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podglądToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajĆwiczenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podglądToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTreningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrolaWagiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrolujWageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocTechnicznaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnRozpocznijTrening = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.bazaDataSet = new HomeFitness.bazaDataSet();
            this.cwiczeniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cwiczeniaTableAdapter = new HomeFitness.bazaDataSetTableAdapters.CwiczeniaTableAdapter();
            this.tableAdapterManager = new HomeFitness.bazaDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwiczeniaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(1100, 641);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 87);
            this.button2.TabIndex = 4;
            this.button2.Text = "Baza ćwiczeń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.bazaĆwiczeńToolStripMenuItem,
            this.treningToolStripMenuItem,
            this.kontrolaWagiToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1324, 26);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyjścieToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // bazaĆwiczeńToolStripMenuItem
            // 
            this.bazaĆwiczeńToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podglądToolStripMenuItem,
            this.dodajĆwiczenieToolStripMenuItem});
            this.bazaĆwiczeńToolStripMenuItem.Name = "bazaĆwiczeńToolStripMenuItem";
            this.bazaĆwiczeńToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.bazaĆwiczeńToolStripMenuItem.Text = "Baza ćwiczeń";
            // 
            // podglądToolStripMenuItem
            // 
            this.podglądToolStripMenuItem.Name = "podglądToolStripMenuItem";
            this.podglądToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.podglądToolStripMenuItem.Text = "Podgląd";
            // 
            // dodajĆwiczenieToolStripMenuItem
            // 
            this.dodajĆwiczenieToolStripMenuItem.Name = "dodajĆwiczenieToolStripMenuItem";
            this.dodajĆwiczenieToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.dodajĆwiczenieToolStripMenuItem.Text = "Dodaj ćwiczenie";
            this.dodajĆwiczenieToolStripMenuItem.Click += new System.EventHandler(this.dodajĆwiczenieToolStripMenuItem_Click);
            // 
            // treningToolStripMenuItem
            // 
            this.treningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podglądToolStripMenuItem1,
            this.dodajTreningToolStripMenuItem});
            this.treningToolStripMenuItem.Name = "treningToolStripMenuItem";
            this.treningToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.treningToolStripMenuItem.Text = "Trening";
            // 
            // podglądToolStripMenuItem1
            // 
            this.podglądToolStripMenuItem1.Name = "podglądToolStripMenuItem1";
            this.podglądToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.podglądToolStripMenuItem1.Text = "Podgląd";
            // 
            // dodajTreningToolStripMenuItem
            // 
            this.dodajTreningToolStripMenuItem.Name = "dodajTreningToolStripMenuItem";
            this.dodajTreningToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.dodajTreningToolStripMenuItem.Text = "Dodaj trening";
            // 
            // kontrolaWagiToolStripMenuItem
            // 
            this.kontrolaWagiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontrolujWageToolStripMenuItem});
            this.kontrolaWagiToolStripMenuItem.Name = "kontrolaWagiToolStripMenuItem";
            this.kontrolaWagiToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.kontrolaWagiToolStripMenuItem.Text = "Postęp i waga";
            // 
            // kontrolujWageToolStripMenuItem
            // 
            this.kontrolujWageToolStripMenuItem.Name = "kontrolujWageToolStripMenuItem";
            this.kontrolujWageToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.kontrolujWageToolStripMenuItem.Text = "Podlgąd";
            this.kontrolujWageToolStripMenuItem.Click += new System.EventHandler(this.kontrolujWageToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocTechnicznaToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // pomocTechnicznaToolStripMenuItem
            // 
            this.pomocTechnicznaToolStripMenuItem.Name = "pomocTechnicznaToolStripMenuItem";
            this.pomocTechnicznaToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.pomocTechnicznaToolStripMenuItem.Text = "Pomoc techniczna";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(1100, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 87);
            this.button1.TabIndex = 7;
            this.button1.Text = "Trening";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(1100, 383);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 87);
            this.button3.TabIndex = 8;
            this.button3.Text = "Seria ćwiczeń";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button5.Location = new System.Drawing.Point(1100, 258);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 87);
            this.button5.TabIndex = 10;
            this.button5.Text = "Postęp i waga";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button6.Location = new System.Drawing.Point(1100, 514);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 87);
            this.button6.TabIndex = 11;
            this.button6.Text = "Plan treningowy";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnRozpocznijTrening
            // 
            this.btnRozpocznijTrening.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRozpocznijTrening.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRozpocznijTrening.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRozpocznijTrening.Location = new System.Drawing.Point(1100, 32);
            this.btnRozpocznijTrening.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRozpocznijTrening.Name = "btnRozpocznijTrening";
            this.btnRozpocznijTrening.Size = new System.Drawing.Size(184, 80);
            this.btnRozpocznijTrening.TabIndex = 12;
            this.btnRozpocznijTrening.Text = "Rozpocznij trening";
            this.btnRozpocznijTrening.UseVisualStyleBackColor = true;
            this.btnRozpocznijTrening.Click += new System.EventHandler(this.btnRozpocznijTrening_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Location = new System.Drawing.Point(16, 41);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1063, 688);
            this.MainPanel.TabIndex = 22;
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "bazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cwiczeniaBindingSource
            // 
            this.cwiczeniaBindingSource.DataMember = "Cwiczenia";
            this.cwiczeniaBindingSource.DataSource = this.bazaDataSet;
            // 
            // cwiczeniaTableAdapter
            // 
            this.cwiczeniaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CwiczeniaTableAdapter = this.cwiczeniaTableAdapter;
            this.tableAdapterManager.CwSCTableAdapter = null;
            this.tableAdapterManager.Plan_treninguTableAdapter = null;
            this.tableAdapterManager.SCTTableAdapter = null;
            this.tableAdapterManager.Seria_cwiczenTableAdapter = null;
            this.tableAdapterManager.TreningiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HomeFitness.bazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1324, 747);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRozpocznijTrening);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwiczeniaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private bazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource cwiczeniaBindingSource;
        private bazaDataSetTableAdapters.CwiczeniaTableAdapter cwiczeniaTableAdapter;
        private bazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaĆwiczeńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podglądToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajĆwiczenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podglądToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajTreningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocTechnicznaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem kontrolaWagiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrolujWageToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnRozpocznijTrening;
        private System.Windows.Forms.Panel MainPanel;
    }
}

