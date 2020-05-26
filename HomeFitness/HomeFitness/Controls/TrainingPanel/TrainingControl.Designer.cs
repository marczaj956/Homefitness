namespace HomeFitness.Controls.TrainingPanel
{
    partial class TrainingControl
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
            this.btnSTOP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSTOP
            // 
            this.btnSTOP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSTOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSTOP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSTOP.Location = new System.Drawing.Point(574, 419);
            this.btnSTOP.Margin = new System.Windows.Forms.Padding(2);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.Size = new System.Drawing.Size(138, 65);
            this.btnSTOP.TabIndex = 14;
            this.btnSTOP.Text = "STOP";
            this.btnSTOP.UseVisualStyleBackColor = true;
            this.btnSTOP.Click += new System.EventHandler(this.btnSTOP_Click);
            // 
            // TrainingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSTOP);
            this.Name = "TrainingControl";
            this.Size = new System.Drawing.Size(798, 559);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSTOP;
    }
}
