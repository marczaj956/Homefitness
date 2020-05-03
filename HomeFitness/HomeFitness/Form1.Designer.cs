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
            this.bazaDataSet = new HomeFitness.bazaDataSet();
            this.cwiczeniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cwiczeniaTableAdapter = new HomeFitness.bazaDataSetTableAdapters.CwiczeniaTableAdapter();
            this.tableAdapterManager = new HomeFitness.bazaDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwiczeniaDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaĆwiczeńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podglądToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podglądToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajĆwiczenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTreningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocTechnicznaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.kontrolaWagiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrolujWageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wprowadźDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postępToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statystykiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwiczeniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwiczeniaDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Zalecana_ilosc";
            this.dataGridViewTextBoxColumn6.HeaderText = "Zalecana_ilosc";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Opis";
            this.dataGridViewTextBoxColumn5.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cwiczone_miesnie";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cwiczone_miesnie";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Spalone_kalorie";
            this.dataGridViewTextBoxColumn3.HeaderText = "Spalone_kalorie";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nazwa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nr_cwiczenia";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nr_cwiczenia";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // cwiczeniaDataGridView
            // 
            this.cwiczeniaDataGridView.AutoGenerateColumns = false;
            this.cwiczeniaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cwiczeniaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.cwiczeniaDataGridView.DataSource = this.cwiczeniaBindingSource;
            this.cwiczeniaDataGridView.Location = new System.Drawing.Point(12, 754);
            this.cwiczeniaDataGridView.Name = "cwiczeniaDataGridView";
            this.cwiczeniaDataGridView.RowHeadersWidth = 62;
            this.cwiczeniaDataGridView.RowTemplate.Height = 28;
            this.cwiczeniaDataGridView.Size = new System.Drawing.Size(962, 168);
            this.cwiczeniaDataGridView.TabIndex = 3;
            this.cwiczeniaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cwiczeniaDataGridView_CellContentClick_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(1115, 812);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 110);
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
            this.postępToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1548, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyjścieToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // bazaĆwiczeńToolStripMenuItem
            // 
            this.bazaĆwiczeńToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podglądToolStripMenuItem,
            this.dodajĆwiczenieToolStripMenuItem});
            this.bazaĆwiczeńToolStripMenuItem.Name = "bazaĆwiczeńToolStripMenuItem";
            this.bazaĆwiczeńToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.bazaĆwiczeńToolStripMenuItem.Text = "Baza ćwiczeń";
            // 
            // treningToolStripMenuItem
            // 
            this.treningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podglądToolStripMenuItem1,
            this.dodajTreningToolStripMenuItem});
            this.treningToolStripMenuItem.Name = "treningToolStripMenuItem";
            this.treningToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.treningToolStripMenuItem.Text = "Trening";
            // 
            // podglądToolStripMenuItem
            // 
            this.podglądToolStripMenuItem.Name = "podglądToolStripMenuItem";
            this.podglądToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.podglądToolStripMenuItem.Text = "Podgląd";
            // 
            // podglądToolStripMenuItem1
            // 
            this.podglądToolStripMenuItem1.Name = "podglądToolStripMenuItem1";
            this.podglądToolStripMenuItem1.Size = new System.Drawing.Size(210, 30);
            this.podglądToolStripMenuItem1.Text = "Podgląd";
            // 
            // dodajĆwiczenieToolStripMenuItem
            // 
            this.dodajĆwiczenieToolStripMenuItem.Name = "dodajĆwiczenieToolStripMenuItem";
            this.dodajĆwiczenieToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.dodajĆwiczenieToolStripMenuItem.Text = "Dodaj ćwiczenie";
            // 
            // dodajTreningToolStripMenuItem
            // 
            this.dodajTreningToolStripMenuItem.Name = "dodajTreningToolStripMenuItem";
            this.dodajTreningToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.dodajTreningToolStripMenuItem.Text = "Dodaj trening";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocTechnicznaToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // pomocTechnicznaToolStripMenuItem
            // 
            this.pomocTechnicznaToolStripMenuItem.Name = "pomocTechnicznaToolStripMenuItem";
            this.pomocTechnicznaToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.pomocTechnicznaToolStripMenuItem.Text = "Pomoc techniczna";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(1115, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 110);
            this.button1.TabIndex = 7;
            this.button1.Text = "Trening";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(1115, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 110);
            this.button3.TabIndex = 8;
            this.button3.Text = "Seria ćwiczeń";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(1115, 506);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 110);
            this.button4.TabIndex = 9;
            this.button4.Text = "Kontrola wagi";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // kontrolaWagiToolStripMenuItem
            // 
            this.kontrolaWagiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontrolujWageToolStripMenuItem,
            this.wprowadźDaneToolStripMenuItem});
            this.kontrolaWagiToolStripMenuItem.Name = "kontrolaWagiToolStripMenuItem";
            this.kontrolaWagiToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.kontrolaWagiToolStripMenuItem.Text = "Kontrola wagi";
            // 
            // kontrolujWageToolStripMenuItem
            // 
            this.kontrolujWageToolStripMenuItem.Name = "kontrolujWageToolStripMenuItem";
            this.kontrolujWageToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.kontrolujWageToolStripMenuItem.Text = "Podlgąd";
            // 
            // wprowadźDaneToolStripMenuItem
            // 
            this.wprowadźDaneToolStripMenuItem.Name = "wprowadźDaneToolStripMenuItem";
            this.wprowadźDaneToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.wprowadźDaneToolStripMenuItem.Text = "Wprowadź dane";
            // 
            // postępToolStripMenuItem
            // 
            this.postępToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statystykiToolStripMenuItem});
            this.postępToolStripMenuItem.Name = "postępToolStripMenuItem";
            this.postępToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.postępToolStripMenuItem.Text = "Postęp";
            // 
            // statystykiToolStripMenuItem
            // 
            this.statystykiToolStripMenuItem.Name = "statystykiToolStripMenuItem";
            this.statystykiToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.statystykiToolStripMenuItem.Text = "Statystyki";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button5.Location = new System.Drawing.Point(1115, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 110);
            this.button5.TabIndex = 10;
            this.button5.Text = "Postęp";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button6.Location = new System.Drawing.Point(1115, 654);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(207, 110);
            this.button6.TabIndex = 11;
            this.button6.Text = "Plan treningowy";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button7.Location = new System.Drawing.Point(26, 506);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(359, 110);
            this.button7.TabIndex = 12;
            this.button7.Text = "Rozpocznij trening";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(20, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Twój najbliższy trening:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(591, 82);
            this.label2.TabIndex = 14;
            this.label2.Text = "HOME-FITNESS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(369, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Wtorek, godzina 19:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(20, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Twój poziom:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(234, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Początkujący";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(20, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Twoja liczba punktów:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(369, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "0 pkt.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(479, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "20 kg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(20, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(442, 32);
            this.label9.TabIndex = 21;
            this.label9.Text = "Do wymarzonej wagi pozostało:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 934);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cwiczeniaDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwiczeniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwiczeniaDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private bazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource cwiczeniaBindingSource;
        private bazaDataSetTableAdapters.CwiczeniaTableAdapter cwiczeniaTableAdapter;
        private bazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView cwiczeniaDataGridView;
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
        private System.Windows.Forms.ToolStripMenuItem wprowadźDaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postępToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statystykiToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

