namespace CoordinateManager
{
    partial class Coordinate_Editor
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
            this.TXT_name = new System.Windows.Forms.TextBox();
            this.NUM_y = new System.Windows.Forms.NumericUpDown();
            this.NUM_z = new System.Windows.Forms.NumericUpDown();
            this.NUM_x = new System.Windows.Forms.NumericUpDown();
            this.BTN_can = new System.Windows.Forms.Button();
            this.BTN_del = new System.Windows.Forms.Button();
            this.BTN_save = new System.Windows.Forms.Button();
            this.CBX_DimSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_x)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_name
            // 
            this.TXT_name.Location = new System.Drawing.Point(16, 15);
            this.TXT_name.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_name.Name = "TXT_name";
            this.TXT_name.Size = new System.Drawing.Size(250, 22);
            this.TXT_name.TabIndex = 0;
            // 
            // NUM_y
            // 
            this.NUM_y.Location = new System.Drawing.Point(145, 47);
            this.NUM_y.Margin = new System.Windows.Forms.Padding(4);
            this.NUM_y.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUM_y.Name = "NUM_y";
            this.NUM_y.Size = new System.Drawing.Size(121, 22);
            this.NUM_y.TabIndex = 1;
            this.NUM_y.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // NUM_z
            // 
            this.NUM_z.Location = new System.Drawing.Point(275, 47);
            this.NUM_z.Margin = new System.Windows.Forms.Padding(4);
            this.NUM_z.Maximum = new decimal(new int[] {
            30000000,
            0,
            0,
            0});
            this.NUM_z.Minimum = new decimal(new int[] {
            30000000,
            0,
            0,
            -2147483648});
            this.NUM_z.Name = "NUM_z";
            this.NUM_z.Size = new System.Drawing.Size(121, 22);
            this.NUM_z.TabIndex = 2;
            // 
            // NUM_x
            // 
            this.NUM_x.Location = new System.Drawing.Point(16, 47);
            this.NUM_x.Margin = new System.Windows.Forms.Padding(4);
            this.NUM_x.Maximum = new decimal(new int[] {
            30000000,
            0,
            0,
            0});
            this.NUM_x.Minimum = new decimal(new int[] {
            30000000,
            0,
            0,
            -2147483648});
            this.NUM_x.Name = "NUM_x";
            this.NUM_x.Size = new System.Drawing.Size(121, 22);
            this.NUM_x.TabIndex = 3;
            // 
            // BTN_can
            // 
            this.BTN_can.Location = new System.Drawing.Point(145, 79);
            this.BTN_can.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_can.Name = "BTN_can";
            this.BTN_can.Size = new System.Drawing.Size(121, 28);
            this.BTN_can.TabIndex = 4;
            this.BTN_can.Text = "Cancel";
            this.BTN_can.UseVisualStyleBackColor = true;
            this.BTN_can.Click += new System.EventHandler(this.BTN_can_Click);
            // 
            // BTN_del
            // 
            this.BTN_del.Location = new System.Drawing.Point(275, 79);
            this.BTN_del.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_del.Name = "BTN_del";
            this.BTN_del.Size = new System.Drawing.Size(121, 28);
            this.BTN_del.TabIndex = 5;
            this.BTN_del.Text = "Delete";
            this.BTN_del.UseVisualStyleBackColor = true;
            this.BTN_del.Click += new System.EventHandler(this.BTN_del_Click);
            // 
            // BTN_save
            // 
            this.BTN_save.Location = new System.Drawing.Point(16, 79);
            this.BTN_save.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_save.Name = "BTN_save";
            this.BTN_save.Size = new System.Drawing.Size(121, 28);
            this.BTN_save.TabIndex = 6;
            this.BTN_save.Text = "Save";
            this.BTN_save.UseVisualStyleBackColor = true;
            this.BTN_save.Click += new System.EventHandler(this.BTN_save_Click);
            // 
            // CBX_DimSelect
            // 
            this.CBX_DimSelect.FormattingEnabled = true;
            this.CBX_DimSelect.Location = new System.Drawing.Point(273, 15);
            this.CBX_DimSelect.Name = "CBX_DimSelect";
            this.CBX_DimSelect.Size = new System.Drawing.Size(127, 24);
            this.CBX_DimSelect.TabIndex = 7;
            // 
            // Coordinate_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 121);
            this.Controls.Add(this.CBX_DimSelect);
            this.Controls.Add(this.BTN_save);
            this.Controls.Add(this.BTN_del);
            this.Controls.Add(this.BTN_can);
            this.Controls.Add(this.NUM_x);
            this.Controls.Add(this.NUM_z);
            this.Controls.Add(this.NUM_y);
            this.Controls.Add(this.TXT_name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Coordinate_Editor";
            this.Text = "Coordinate Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Coordinate_Editor_FormClosed);
            this.Load += new System.EventHandler(this.Coordinate_Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_x)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_name;
        private System.Windows.Forms.NumericUpDown NUM_y;
        private System.Windows.Forms.NumericUpDown NUM_z;
        private System.Windows.Forms.NumericUpDown NUM_x;
        private System.Windows.Forms.Button BTN_can;
        private System.Windows.Forms.Button BTN_del;
        private System.Windows.Forms.Button BTN_save;
        private System.Windows.Forms.ComboBox CBX_DimSelect;
    }
}