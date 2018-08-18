namespace CoordinateManager
{
    partial class Home
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
            this.BTN_new = new System.Windows.Forms.Button();
            this.BTN_edit = new System.Windows.Forms.Button();
            this.BTN_del = new System.Windows.Forms.Button();
            this.BTN_TP = new System.Windows.Forms.Button();
            this.LVW_List = new System.Windows.Forms.ListView();
            this.LVC_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVC_x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVC_y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVC_z = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVC_dim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CBX_WorldSelect = new System.Windows.Forms.ComboBox();
            this.BTN_options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_new
            // 
            this.BTN_new.Location = new System.Drawing.Point(9, 238);
            this.BTN_new.Name = "BTN_new";
            this.BTN_new.Size = new System.Drawing.Size(75, 23);
            this.BTN_new.TabIndex = 2;
            this.BTN_new.Text = "Add new";
            this.BTN_new.UseVisualStyleBackColor = true;
            this.BTN_new.Click += new System.EventHandler(this.BTN_new_Click);
            // 
            // BTN_edit
            // 
            this.BTN_edit.Location = new System.Drawing.Point(128, 238);
            this.BTN_edit.Name = "BTN_edit";
            this.BTN_edit.Size = new System.Drawing.Size(75, 23);
            this.BTN_edit.TabIndex = 3;
            this.BTN_edit.Text = "Edit";
            this.BTN_edit.UseVisualStyleBackColor = true;
            this.BTN_edit.Click += new System.EventHandler(this.BTN_edit_Click);
            // 
            // BTN_del
            // 
            this.BTN_del.Location = new System.Drawing.Point(209, 238);
            this.BTN_del.Name = "BTN_del";
            this.BTN_del.Size = new System.Drawing.Size(75, 23);
            this.BTN_del.TabIndex = 4;
            this.BTN_del.Text = "Delete";
            this.BTN_del.UseVisualStyleBackColor = true;
            this.BTN_del.Click += new System.EventHandler(this.BTN_del_Click);
            // 
            // BTN_TP
            // 
            this.BTN_TP.Location = new System.Drawing.Point(336, 238);
            this.BTN_TP.Name = "BTN_TP";
            this.BTN_TP.Size = new System.Drawing.Size(142, 23);
            this.BTN_TP.TabIndex = 5;
            this.BTN_TP.Text = "/TP command";
            this.BTN_TP.UseVisualStyleBackColor = true;
            this.BTN_TP.Click += new System.EventHandler(this.BTN_TP_Click);
            // 
            // LVW_List
            // 
            this.LVW_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVC_Name,
            this.LVC_x,
            this.LVC_y,
            this.LVC_z,
            this.LVC_dim});
            this.LVW_List.FullRowSelect = true;
            this.LVW_List.GridLines = true;
            this.LVW_List.HideSelection = false;
            this.LVW_List.Location = new System.Drawing.Point(9, 34);
            this.LVW_List.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LVW_List.MultiSelect = false;
            this.LVW_List.Name = "LVW_List";
            this.LVW_List.Size = new System.Drawing.Size(470, 199);
            this.LVW_List.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LVW_List.TabIndex = 1;
            this.LVW_List.UseCompatibleStateImageBehavior = false;
            this.LVW_List.SelectedIndexChanged += new System.EventHandler(this.LVW_List_SelectedIndexChanged);
            // 
            // LVC_Name
            // 
            this.LVC_Name.Text = "Name";
            // 
            // LVC_x
            // 
            this.LVC_x.Text = "X";
            // 
            // LVC_y
            // 
            this.LVC_y.Text = "Y";
            // 
            // LVC_z
            // 
            this.LVC_z.Text = "Z";
            // 
            // LVC_dim
            // 
            this.LVC_dim.Text = "Dimension";
            // 
            // CBX_WorldSelect
            // 
            this.CBX_WorldSelect.FormattingEnabled = true;
            this.CBX_WorldSelect.Location = new System.Drawing.Point(9, 10);
            this.CBX_WorldSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBX_WorldSelect.Name = "CBX_WorldSelect";
            this.CBX_WorldSelect.Size = new System.Drawing.Size(384, 21);
            this.CBX_WorldSelect.TabIndex = 0;
            this.CBX_WorldSelect.SelectedIndexChanged += new System.EventHandler(this.CBX_WorldSelect_SelectedIndexChanged);
            // 
            // BTN_options
            // 
            this.BTN_options.Enabled = false;
            this.BTN_options.Location = new System.Drawing.Point(397, 10);
            this.BTN_options.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_options.Name = "BTN_options";
            this.BTN_options.Size = new System.Drawing.Size(81, 20);
            this.BTN_options.TabIndex = 7;
            this.BTN_options.Text = "Options";
            this.BTN_options.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 273);
            this.Controls.Add(this.BTN_options);
            this.Controls.Add(this.CBX_WorldSelect);
            this.Controls.Add(this.LVW_List);
            this.Controls.Add(this.BTN_TP);
            this.Controls.Add(this.BTN_del);
            this.Controls.Add(this.BTN_edit);
            this.Controls.Add(this.BTN_new);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Coordinate Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_new;
        private System.Windows.Forms.Button BTN_edit;
        private System.Windows.Forms.Button BTN_del;
        private System.Windows.Forms.Button BTN_TP;
        private System.Windows.Forms.ListView LVW_List;
        private System.Windows.Forms.ColumnHeader LVC_Name;
        private System.Windows.Forms.ColumnHeader LVC_x;
        private System.Windows.Forms.ColumnHeader LVC_y;
        private System.Windows.Forms.ColumnHeader LVC_z;
        private System.Windows.Forms.ColumnHeader LVC_dim;
        private System.Windows.Forms.ComboBox CBX_WorldSelect;
        private System.Windows.Forms.Button BTN_options;
    }
}

