﻿namespace HomeFitness.Controls.AchPanel
{
    partial class Ach
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NowaWaga = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textnw = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Pwaga = new System.Windows.Forms.GroupBox();
            this.textpw = new System.Windows.Forms.TextBox();
            this.Cel = new System.Windows.Forms.GroupBox();
            this.textdw = new System.Windows.Forms.TextBox();
            this.Calkowityczas = new System.Windows.Forms.GroupBox();
            this.textczas = new System.Windows.Forms.TextBox();
            this.lvl = new System.Windows.Forms.Label();
            this.textlvl = new System.Windows.Forms.TextBox();
            this.Kalorie = new System.Windows.Forms.GroupBox();
            this.textkalorie = new System.Windows.Forms.TextBox();
            this.waga = new System.Windows.Forms.Label();
            this.achiv = new System.Windows.Forms.Label();
            this.Nzapisz = new System.Windows.Forms.Button();
            this.CZapisz = new System.Windows.Forms.Button();
            this.NowaWaga.SuspendLayout();
            this.Pwaga.SuspendLayout();
            this.Cel.SuspendLayout();
            this.Calkowityczas.SuspendLayout();
            this.Kalorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // NowaWaga
            // 
            this.NowaWaga.Controls.Add(this.textnw);
            this.NowaWaga.Location = new System.Drawing.Point(238, 64);
            this.NowaWaga.Name = "NowaWaga";
            this.NowaWaga.Size = new System.Drawing.Size(116, 56);
            this.NowaWaga.TabIndex = 1;
            this.NowaWaga.TabStop = false;
            this.NowaWaga.Text = "Nowa Waga";
            this.NowaWaga.Enter += new System.EventHandler(this.NowaWaga_Enter);
            // 
            // textnw
            // 
            this.textnw.Location = new System.Drawing.Point(7, 20);
            this.textnw.Name = "textnw";
            this.textnw.Size = new System.Drawing.Size(100, 20);
            this.textnw.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Pwaga
            // 
            this.Pwaga.Controls.Add(this.textpw);
            this.Pwaga.Location = new System.Drawing.Point(409, 64);
            this.Pwaga.Name = "Pwaga";
            this.Pwaga.Size = new System.Drawing.Size(116, 56);
            this.Pwaga.TabIndex = 2;
            this.Pwaga.TabStop = false;
            this.Pwaga.Text = "Poprzednia Waga";
            // 
            // textpw
            // 
            this.textpw.Location = new System.Drawing.Point(7, 20);
            this.textpw.Name = "textpw";
            this.textpw.ReadOnly = true;
            this.textpw.Size = new System.Drawing.Size(100, 20);
            this.textpw.TabIndex = 0;
            this.textpw.TextChanged += new System.EventHandler(this.textpw_TextChanged);
            // 
            // Cel
            // 
            this.Cel.Controls.Add(this.textdw);
            this.Cel.Location = new System.Drawing.Point(580, 64);
            this.Cel.Name = "Cel";
            this.Cel.Size = new System.Drawing.Size(116, 56);
            this.Cel.TabIndex = 3;
            this.Cel.TabStop = false;
            this.Cel.Text = "Docelowa Waga";
            // 
            // textdw
            // 
            this.textdw.Location = new System.Drawing.Point(7, 20);
            this.textdw.Name = "textdw";
            this.textdw.Size = new System.Drawing.Size(100, 20);
            this.textdw.TabIndex = 0;
            this.textdw.TextChanged += new System.EventHandler(this.textdw_TextChanged);
            // 
            // Calkowityczas
            // 
            this.Calkowityczas.Controls.Add(this.textczas);
            this.Calkowityczas.Location = new System.Drawing.Point(42, 339);
            this.Calkowityczas.Name = "Calkowityczas";
            this.Calkowityczas.Size = new System.Drawing.Size(155, 56);
            this.Calkowityczas.TabIndex = 3;
            this.Calkowityczas.TabStop = false;
            this.Calkowityczas.Text = "Całkowity czas treningu";
            // 
            // textczas
            // 
            this.textczas.Location = new System.Drawing.Point(7, 20);
            this.textczas.Name = "textczas";
            this.textczas.Size = new System.Drawing.Size(100, 20);
            this.textczas.TabIndex = 0;
            this.textczas.TextChanged += new System.EventHandler(this.textczas_TextChanged);
            // 
            // lvl
            // 
            this.lvl.AutoSize = true;
            this.lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lvl.Location = new System.Drawing.Point(531, 210);
            this.lvl.Name = "lvl";
            this.lvl.Size = new System.Drawing.Size(246, 73);
            this.lvl.TabIndex = 5;
            this.lvl.Text = "Poziom";
            this.lvl.Click += new System.EventHandler(this.label1_Click);
            // 
            // textlvl
            // 
            this.textlvl.Location = new System.Drawing.Point(544, 359);
            this.textlvl.Name = "textlvl";
            this.textlvl.Size = new System.Drawing.Size(217, 20);
            this.textlvl.TabIndex = 6;
            this.textlvl.TextChanged += new System.EventHandler(this.textlvl_TextChanged);
            // 
            // Kalorie
            // 
            this.Kalorie.Controls.Add(this.textkalorie);
            this.Kalorie.Location = new System.Drawing.Point(231, 339);
            this.Kalorie.Name = "Kalorie";
            this.Kalorie.Size = new System.Drawing.Size(155, 56);
            this.Kalorie.TabIndex = 4;
            this.Kalorie.TabStop = false;
            this.Kalorie.Text = "Suma spalonych kalorii";
            // 
            // textkalorie
            // 
            this.textkalorie.Location = new System.Drawing.Point(7, 20);
            this.textkalorie.Name = "textkalorie";
            this.textkalorie.Size = new System.Drawing.Size(100, 20);
            this.textkalorie.TabIndex = 0;
            this.textkalorie.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // waga
            // 
            this.waga.AutoSize = true;
            this.waga.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.waga.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.waga.Location = new System.Drawing.Point(18, 47);
            this.waga.Name = "waga";
            this.waga.Size = new System.Drawing.Size(200, 73);
            this.waga.TabIndex = 7;
            this.waga.Text = "Waga";
            // 
            // achiv
            // 
            this.achiv.AutoSize = true;
            this.achiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.achiv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.achiv.Location = new System.Drawing.Point(18, 210);
            this.achiv.Name = "achiv";
            this.achiv.Size = new System.Drawing.Size(368, 73);
            this.achiv.TabIndex = 8;
            this.achiv.Text = "Osiągnięcia";
            // 
            // Nzapisz
            // 
            this.Nzapisz.Location = new System.Drawing.Point(245, 138);
            this.Nzapisz.Name = "Nzapisz";
            this.Nzapisz.Size = new System.Drawing.Size(100, 23);
            this.Nzapisz.TabIndex = 9;
            this.Nzapisz.Text = "Zapisz";
            this.Nzapisz.UseVisualStyleBackColor = true;
            this.Nzapisz.Click += new System.EventHandler(this.button1_Click);
            // 
            // CZapisz
            // 
            this.CZapisz.Location = new System.Drawing.Point(587, 138);
            this.CZapisz.Name = "CZapisz";
            this.CZapisz.Size = new System.Drawing.Size(100, 23);
            this.CZapisz.TabIndex = 10;
            this.CZapisz.Text = "Zapisz";
            this.CZapisz.UseVisualStyleBackColor = true;
            this.CZapisz.Click += new System.EventHandler(this.CZapisz_Click);
            // 
            // Ach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CZapisz);
            this.Controls.Add(this.Nzapisz);
            this.Controls.Add(this.achiv);
            this.Controls.Add(this.waga);
            this.Controls.Add(this.Kalorie);
            this.Controls.Add(this.textlvl);
            this.Controls.Add(this.lvl);
            this.Controls.Add(this.Calkowityczas);
            this.Controls.Add(this.Cel);
            this.Controls.Add(this.Pwaga);
            this.Controls.Add(this.NowaWaga);
            this.Name = "Ach";
            this.Size = new System.Drawing.Size(864, 517);
            this.NowaWaga.ResumeLayout(false);
            this.NowaWaga.PerformLayout();
            this.Pwaga.ResumeLayout(false);
            this.Pwaga.PerformLayout();
            this.Cel.ResumeLayout(false);
            this.Cel.PerformLayout();
            this.Calkowityczas.ResumeLayout(false);
            this.Calkowityczas.PerformLayout();
            this.Kalorie.ResumeLayout(false);
            this.Kalorie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox NowaWaga;
        private System.Windows.Forms.TextBox textnw;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox Pwaga;
        private System.Windows.Forms.TextBox textpw;
        private System.Windows.Forms.GroupBox Cel;
        private System.Windows.Forms.TextBox textdw;
        private System.Windows.Forms.GroupBox Calkowityczas;
        private System.Windows.Forms.TextBox textczas;
        private System.Windows.Forms.Label lvl;
        private System.Windows.Forms.TextBox textlvl;
        private System.Windows.Forms.GroupBox Kalorie;
        private System.Windows.Forms.TextBox textkalorie;
        private System.Windows.Forms.Label waga;
        private System.Windows.Forms.Label achiv;
        private System.Windows.Forms.Button Nzapisz;
        private System.Windows.Forms.Button CZapisz;
    }
}