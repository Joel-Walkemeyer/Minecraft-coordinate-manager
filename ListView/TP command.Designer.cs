namespace CoordinateManager
{
    partial class TP_command
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
            this.TXT_com = new System.Windows.Forms.TextBox();
            this.BTN_close = new System.Windows.Forms.Button();
            this.BTN_copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_com
            // 
            this.TXT_com.Location = new System.Drawing.Point(12, 12);
            this.TXT_com.Name = "TXT_com";
            this.TXT_com.Size = new System.Drawing.Size(294, 22);
            this.TXT_com.TabIndex = 0;
            // 
            // BTN_close
            // 
            this.BTN_close.Location = new System.Drawing.Point(162, 40);
            this.BTN_close.Name = "BTN_close";
            this.BTN_close.Size = new System.Drawing.Size(144, 32);
            this.BTN_close.TabIndex = 1;
            this.BTN_close.Text = "Close";
            this.BTN_close.UseVisualStyleBackColor = true;
            this.BTN_close.Click += new System.EventHandler(this.BTN_close_Click);
            // 
            // BTN_copy
            // 
            this.BTN_copy.Location = new System.Drawing.Point(12, 40);
            this.BTN_copy.Name = "BTN_copy";
            this.BTN_copy.Size = new System.Drawing.Size(144, 32);
            this.BTN_copy.TabIndex = 2;
            this.BTN_copy.Text = "Copy";
            this.BTN_copy.UseVisualStyleBackColor = true;
            this.BTN_copy.Click += new System.EventHandler(this.BTN_copy_Click);
            // 
            // TP_command
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 84);
            this.Controls.Add(this.BTN_copy);
            this.Controls.Add(this.BTN_close);
            this.Controls.Add(this.TXT_com);
            this.Name = "TP_command";
            this.Text = "TP command";
            this.Load += new System.EventHandler(this.TP_command_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_com;
        private System.Windows.Forms.Button BTN_close;
        private System.Windows.Forms.Button BTN_copy;
    }
}