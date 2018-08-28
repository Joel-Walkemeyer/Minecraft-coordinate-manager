namespace CoordinateManager
{
    partial class FRM_Loading
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
            this.PGB_Load = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // PGB_Load
            // 
            this.PGB_Load.Location = new System.Drawing.Point(12, 12);
            this.PGB_Load.Name = "PGB_Load";
            this.PGB_Load.Size = new System.Drawing.Size(432, 23);
            this.PGB_Load.TabIndex = 3;
            // 
            // FRM_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 47);
            this.Controls.Add(this.PGB_Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Loading";
            this.Text = "LoadingFRM";
            this.Load += new System.EventHandler(this.LoadingFRM_Load);
            this.Shown += new System.EventHandler(this.FRM_Loading_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar PGB_Load;
    }
}