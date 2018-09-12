namespace CoordinateManager
{
    partial class Saving
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
            this.CLB_worlds = new System.Windows.Forms.CheckedListBox();
            this.LBL_msg = new System.Windows.Forms.Label();
            this.BTN_inv = new System.Windows.Forms.Button();
            this.BTN_none = new System.Windows.Forms.Button();
            this.BTN_all = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Can = new System.Windows.Forms.Button();
            this.PNL_worlds = new System.Windows.Forms.Panel();
            this.PNL_btn = new System.Windows.Forms.Panel();
            this.PNL_sav = new System.Windows.Forms.Panel();
            this.PNL_worlds.SuspendLayout();
            this.PNL_btn.SuspendLayout();
            this.PNL_sav.SuspendLayout();
            this.SuspendLayout();
            // 
            // CLB_worlds
            // 
            this.CLB_worlds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CLB_worlds.FormattingEnabled = true;
            this.CLB_worlds.Location = new System.Drawing.Point(0, 23);
            this.CLB_worlds.Margin = new System.Windows.Forms.Padding(2);
            this.CLB_worlds.Name = "CLB_worlds";
            this.CLB_worlds.Size = new System.Drawing.Size(238, 302);
            this.CLB_worlds.TabIndex = 0;
            // 
            // LBL_msg
            // 
            this.LBL_msg.AutoSize = true;
            this.LBL_msg.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_msg.Location = new System.Drawing.Point(0, 0);
            this.LBL_msg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_msg.Name = "LBL_msg";
            this.LBL_msg.Size = new System.Drawing.Size(26, 13);
            this.LBL_msg.TabIndex = 1;
            this.LBL_msg.Text = "msg";
            // 
            // BTN_inv
            // 
            this.BTN_inv.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTN_inv.Location = new System.Drawing.Point(0, 0);
            this.BTN_inv.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_inv.Name = "BTN_inv";
            this.BTN_inv.Size = new System.Drawing.Size(74, 23);
            this.BTN_inv.TabIndex = 2;
            this.BTN_inv.Text = "inv";
            this.BTN_inv.UseVisualStyleBackColor = true;
            // 
            // BTN_none
            // 
            this.BTN_none.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_none.Location = new System.Drawing.Point(74, 0);
            this.BTN_none.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_none.Name = "BTN_none";
            this.BTN_none.Size = new System.Drawing.Size(88, 23);
            this.BTN_none.TabIndex = 3;
            this.BTN_none.Text = "none";
            this.BTN_none.UseVisualStyleBackColor = true;
            // 
            // BTN_all
            // 
            this.BTN_all.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_all.Location = new System.Drawing.Point(162, 0);
            this.BTN_all.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_all.Name = "BTN_all";
            this.BTN_all.Size = new System.Drawing.Size(76, 23);
            this.BTN_all.TabIndex = 4;
            this.BTN_all.Text = "all";
            this.BTN_all.UseVisualStyleBackColor = true;
            // 
            // BTN_Save
            // 
            this.BTN_Save.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTN_Save.Location = new System.Drawing.Point(56, 0);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(56, 21);
            this.BTN_Save.TabIndex = 5;
            this.BTN_Save.Text = "save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Can
            // 
            this.BTN_Can.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTN_Can.Location = new System.Drawing.Point(0, 0);
            this.BTN_Can.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Can.Name = "BTN_Can";
            this.BTN_Can.Size = new System.Drawing.Size(56, 21);
            this.BTN_Can.TabIndex = 6;
            this.BTN_Can.Text = "can";
            this.BTN_Can.UseVisualStyleBackColor = true;
            // 
            // PNL_worlds
            // 
            this.PNL_worlds.Controls.Add(this.CLB_worlds);
            this.PNL_worlds.Controls.Add(this.PNL_btn);
            this.PNL_worlds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_worlds.Location = new System.Drawing.Point(0, 13);
            this.PNL_worlds.Margin = new System.Windows.Forms.Padding(2);
            this.PNL_worlds.Name = "PNL_worlds";
            this.PNL_worlds.Size = new System.Drawing.Size(238, 325);
            this.PNL_worlds.TabIndex = 7;
            // 
            // PNL_btn
            // 
            this.PNL_btn.Controls.Add(this.BTN_none);
            this.PNL_btn.Controls.Add(this.BTN_all);
            this.PNL_btn.Controls.Add(this.BTN_inv);
            this.PNL_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_btn.Location = new System.Drawing.Point(0, 0);
            this.PNL_btn.Margin = new System.Windows.Forms.Padding(2);
            this.PNL_btn.Name = "PNL_btn";
            this.PNL_btn.Size = new System.Drawing.Size(238, 23);
            this.PNL_btn.TabIndex = 5;
            // 
            // PNL_sav
            // 
            this.PNL_sav.Controls.Add(this.BTN_Save);
            this.PNL_sav.Controls.Add(this.BTN_Can);
            this.PNL_sav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_sav.Location = new System.Drawing.Point(0, 317);
            this.PNL_sav.Margin = new System.Windows.Forms.Padding(2);
            this.PNL_sav.Name = "PNL_sav";
            this.PNL_sav.Size = new System.Drawing.Size(238, 21);
            this.PNL_sav.TabIndex = 8;
            // 
            // Saving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 338);
            this.Controls.Add(this.PNL_sav);
            this.Controls.Add(this.PNL_worlds);
            this.Controls.Add(this.LBL_msg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Saving";
            this.Text = "Saving";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Saving_FormClosing);
            this.Load += new System.EventHandler(this.Saving_Load);
            this.PNL_worlds.ResumeLayout(false);
            this.PNL_btn.ResumeLayout(false);
            this.PNL_sav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CLB_worlds;
        private System.Windows.Forms.Label LBL_msg;
        private System.Windows.Forms.Button BTN_inv;
        private System.Windows.Forms.Button BTN_none;
        private System.Windows.Forms.Button BTN_all;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Can;
        private System.Windows.Forms.Panel PNL_worlds;
        private System.Windows.Forms.Panel PNL_btn;
        private System.Windows.Forms.Panel PNL_sav;
    }
}