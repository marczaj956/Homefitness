namespace HomeFitness
{
    partial class StartTraningControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTrainings = new System.Windows.Forms.DataGridView();
            this.bazaDataSet1 = new HomeFitness.bazaDataSet();
            this.btnSTART = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrainings
            // 
            this.dgvTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainings.Location = new System.Drawing.Point(133, 77);
            this.dgvTrainings.Name = "dgvTrainings";
            this.dgvTrainings.Size = new System.Drawing.Size(444, 46);
            this.dgvTrainings.TabIndex = 1;
            this.dgvTrainings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainings_CellContentClick);
            // 
            // bazaDataSet1
            // 
            this.bazaDataSet1.DataSetName = "bazaDataSet";
            this.bazaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSTART
            // 
            this.btnSTART.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSTART.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSTART.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSTART.Location = new System.Drawing.Point(592, 444);
            this.btnSTART.Margin = new System.Windows.Forms.Padding(2);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(138, 65);
            this.btnSTART.TabIndex = 13;
            this.btnSTART.Text = "START";
            this.btnSTART.UseVisualStyleBackColor = true;
            this.btnSTART.Click += new System.EventHandler(this.btnRozpocznijTrening_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Twój najbliższy trening:";
            // 
            // StartTraningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSTART);
            this.Controls.Add(this.dgvTrainings);
            this.Name = "StartTraningControl";
            this.Size = new System.Drawing.Size(798, 559);
            this.Load += new System.EventHandler(this.StartTraningControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTrainings;
        private bazaDataSet bazaDataSet1;
        private System.Windows.Forms.Button btnSTART;
        private System.Windows.Forms.Label label1;
    }
}
