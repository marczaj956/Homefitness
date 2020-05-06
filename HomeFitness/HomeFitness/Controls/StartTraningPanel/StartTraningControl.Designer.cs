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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrainings
            // 
            this.dgvTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainings.Location = new System.Drawing.Point(54, 21);
            this.dgvTrainings.Name = "dgvTrainings";
            this.dgvTrainings.Size = new System.Drawing.Size(690, 360);
            this.dgvTrainings.TabIndex = 1;
            // 
            // bazaDataSet1
            // 
            this.bazaDataSet1.DataSetName = "bazaDataSet";
            this.bazaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StartTraningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTrainings);
            this.Name = "StartTraningControl";
            this.Size = new System.Drawing.Size(798, 559);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTrainings;
        private bazaDataSet bazaDataSet1;
    }
}
