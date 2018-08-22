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
            this.PNL_World = new System.Windows.Forms.Panel();
            this.CBX_InstSel = new System.Windows.Forms.ComboBox();
            this.BTN_NewWorld = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Options = new System.Windows.Forms.Button();
            this.CBX_WordlSel = new System.Windows.Forms.ComboBox();
            this.LVW_Coords = new System.Windows.Forms.ListView();
            this.PNL_Editor = new System.Windows.Forms.Panel();
            this.PNL_Set = new System.Windows.Forms.Panel();
            this.BTN_TP = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Del = new System.Windows.Forms.Button();
            this.CBX_TagSel = new System.Windows.Forms.ComboBox();
            this.CBX_DimSel = new System.Windows.Forms.ComboBox();
            this.NUM_Zcoord = new System.Windows.Forms.NumericUpDown();
            this.NUM_Ycoord = new System.Windows.Forms.NumericUpDown();
            this.NUM_Xcoord = new System.Windows.Forms.NumericUpDown();
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.BTN_New = new System.Windows.Forms.Button();
            this.PNL_Coords = new System.Windows.Forms.Panel();
            this.PNL_World.SuspendLayout();
            this.PNL_Editor.SuspendLayout();
            this.PNL_Set.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Zcoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Ycoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Xcoord)).BeginInit();
            this.PNL_Coords.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_World
            // 
            this.PNL_World.Controls.Add(this.CBX_InstSel);
            this.PNL_World.Controls.Add(this.BTN_NewWorld);
            this.PNL_World.Controls.Add(this.BTN_Save);
            this.PNL_World.Controls.Add(this.BTN_Options);
            this.PNL_World.Controls.Add(this.CBX_WordlSel);
            this.PNL_World.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_World.Location = new System.Drawing.Point(0, 0);
            this.PNL_World.Margin = new System.Windows.Forms.Padding(2);
            this.PNL_World.Name = "PNL_World";
            this.PNL_World.Padding = new System.Windows.Forms.Padding(2);
            this.PNL_World.Size = new System.Drawing.Size(640, 47);
            this.PNL_World.TabIndex = 5;
            // 
            // CBX_InstSel
            // 
            this.CBX_InstSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBX_InstSel.FormattingEnabled = true;
            this.CBX_InstSel.Location = new System.Drawing.Point(2, 2);
            this.CBX_InstSel.Margin = new System.Windows.Forms.Padding(2);
            this.CBX_InstSel.Name = "CBX_InstSel";
            this.CBX_InstSel.Size = new System.Drawing.Size(396, 21);
            this.CBX_InstSel.TabIndex = 10;
            // 
            // BTN_NewWorld
            // 
            this.BTN_NewWorld.AutoSize = true;
            this.BTN_NewWorld.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_NewWorld.Location = new System.Drawing.Point(398, 2);
            this.BTN_NewWorld.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_NewWorld.Name = "BTN_NewWorld";
            this.BTN_NewWorld.Size = new System.Drawing.Size(80, 22);
            this.BTN_NewWorld.TabIndex = 13;
            this.BTN_NewWorld.Text = "NW";
            this.BTN_NewWorld.UseVisualStyleBackColor = true;
            // 
            // BTN_Save
            // 
            this.BTN_Save.AutoSize = true;
            this.BTN_Save.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Save.Location = new System.Drawing.Point(478, 2);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(80, 22);
            this.BTN_Save.TabIndex = 12;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            // 
            // BTN_Options
            // 
            this.BTN_Options.AutoSize = true;
            this.BTN_Options.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Options.Location = new System.Drawing.Point(558, 2);
            this.BTN_Options.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Options.Name = "BTN_Options";
            this.BTN_Options.Size = new System.Drawing.Size(80, 22);
            this.BTN_Options.TabIndex = 11;
            this.BTN_Options.Text = "Options";
            this.BTN_Options.UseVisualStyleBackColor = true;
            // 
            // CBX_WordlSel
            // 
            this.CBX_WordlSel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CBX_WordlSel.FormattingEnabled = true;
            this.CBX_WordlSel.Location = new System.Drawing.Point(2, 24);
            this.CBX_WordlSel.Margin = new System.Windows.Forms.Padding(2);
            this.CBX_WordlSel.Name = "CBX_WordlSel";
            this.CBX_WordlSel.Size = new System.Drawing.Size(636, 21);
            this.CBX_WordlSel.TabIndex = 0;
            this.CBX_WordlSel.SelectedIndexChanged += new System.EventHandler(this.CBX_WordlSel_SelectedIndexChanged);
            // 
            // LVW_Coords
            // 
            this.LVW_Coords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LVW_Coords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVW_Coords.FullRowSelect = true;
            this.LVW_Coords.GridLines = true;
            this.LVW_Coords.Location = new System.Drawing.Point(2, 2);
            this.LVW_Coords.Margin = new System.Windows.Forms.Padding(2);
            this.LVW_Coords.MultiSelect = false;
            this.LVW_Coords.Name = "LVW_Coords";
            this.LVW_Coords.Size = new System.Drawing.Size(476, 349);
            this.LVW_Coords.TabIndex = 6;
            this.LVW_Coords.UseCompatibleStateImageBehavior = false;
            this.LVW_Coords.SelectedIndexChanged += new System.EventHandler(this.LVW_Coords_SelectedIndexChanged);
            // 
            // PNL_Editor
            // 
            this.PNL_Editor.Controls.Add(this.PNL_Set);
            this.PNL_Editor.Controls.Add(this.BTN_New);
            this.PNL_Editor.Dock = System.Windows.Forms.DockStyle.Right;
            this.PNL_Editor.Location = new System.Drawing.Point(480, 47);
            this.PNL_Editor.Margin = new System.Windows.Forms.Padding(2);
            this.PNL_Editor.Name = "PNL_Editor";
            this.PNL_Editor.Padding = new System.Windows.Forms.Padding(2);
            this.PNL_Editor.Size = new System.Drawing.Size(160, 353);
            this.PNL_Editor.TabIndex = 7;
            // 
            // PNL_Set
            // 
            this.PNL_Set.AutoScroll = true;
            this.PNL_Set.Controls.Add(this.BTN_TP);
            this.PNL_Set.Controls.Add(this.BTN_Edit);
            this.PNL_Set.Controls.Add(this.BTN_Cancel);
            this.PNL_Set.Controls.Add(this.BTN_Del);
            this.PNL_Set.Controls.Add(this.CBX_TagSel);
            this.PNL_Set.Controls.Add(this.CBX_DimSel);
            this.PNL_Set.Controls.Add(this.NUM_Zcoord);
            this.PNL_Set.Controls.Add(this.NUM_Ycoord);
            this.PNL_Set.Controls.Add(this.NUM_Xcoord);
            this.PNL_Set.Controls.Add(this.TXT_Name);
            this.PNL_Set.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Set.Location = new System.Drawing.Point(2, 2);
            this.PNL_Set.Margin = new System.Windows.Forms.Padding(2);
            this.PNL_Set.Name = "PNL_Set";
            this.PNL_Set.Size = new System.Drawing.Size(156, 330);
            this.PNL_Set.TabIndex = 16;
            // 
            // BTN_TP
            // 
            this.BTN_TP.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_TP.Location = new System.Drawing.Point(0, 179);
            this.BTN_TP.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_TP.Name = "BTN_TP";
            this.BTN_TP.Size = new System.Drawing.Size(156, 19);
            this.BTN_TP.TabIndex = 12;
            this.BTN_TP.Text = "TP";
            this.BTN_TP.UseVisualStyleBackColor = true;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Edit.Location = new System.Drawing.Point(0, 160);
            this.BTN_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(156, 19);
            this.BTN_Edit.TabIndex = 11;
            this.BTN_Edit.Text = "Edit";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Cancel.Location = new System.Drawing.Point(0, 141);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(156, 19);
            this.BTN_Cancel.TabIndex = 13;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Del
            // 
            this.BTN_Del.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Del.Location = new System.Drawing.Point(0, 122);
            this.BTN_Del.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Del.Name = "BTN_Del";
            this.BTN_Del.Size = new System.Drawing.Size(156, 19);
            this.BTN_Del.TabIndex = 10;
            this.BTN_Del.Text = "Del";
            this.BTN_Del.UseVisualStyleBackColor = true;
            this.BTN_Del.Click += new System.EventHandler(this.BTN_Del_Click);
            // 
            // CBX_TagSel
            // 
            this.CBX_TagSel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBX_TagSel.FormattingEnabled = true;
            this.CBX_TagSel.Location = new System.Drawing.Point(0, 101);
            this.CBX_TagSel.Margin = new System.Windows.Forms.Padding(2);
            this.CBX_TagSel.Name = "CBX_TagSel";
            this.CBX_TagSel.Size = new System.Drawing.Size(156, 21);
            this.CBX_TagSel.TabIndex = 14;
            // 
            // CBX_DimSel
            // 
            this.CBX_DimSel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBX_DimSel.FormattingEnabled = true;
            this.CBX_DimSel.Location = new System.Drawing.Point(0, 80);
            this.CBX_DimSel.Margin = new System.Windows.Forms.Padding(2);
            this.CBX_DimSel.Name = "CBX_DimSel";
            this.CBX_DimSel.Size = new System.Drawing.Size(156, 21);
            this.CBX_DimSel.TabIndex = 9;
            // 
            // NUM_Zcoord
            // 
            this.NUM_Zcoord.Dock = System.Windows.Forms.DockStyle.Top;
            this.NUM_Zcoord.Location = new System.Drawing.Point(0, 60);
            this.NUM_Zcoord.Margin = new System.Windows.Forms.Padding(2);
            this.NUM_Zcoord.Name = "NUM_Zcoord";
            this.NUM_Zcoord.Size = new System.Drawing.Size(156, 20);
            this.NUM_Zcoord.TabIndex = 7;
            // 
            // NUM_Ycoord
            // 
            this.NUM_Ycoord.Dock = System.Windows.Forms.DockStyle.Top;
            this.NUM_Ycoord.Location = new System.Drawing.Point(0, 40);
            this.NUM_Ycoord.Margin = new System.Windows.Forms.Padding(2);
            this.NUM_Ycoord.Name = "NUM_Ycoord";
            this.NUM_Ycoord.Size = new System.Drawing.Size(156, 20);
            this.NUM_Ycoord.TabIndex = 8;
            // 
            // NUM_Xcoord
            // 
            this.NUM_Xcoord.Dock = System.Windows.Forms.DockStyle.Top;
            this.NUM_Xcoord.Location = new System.Drawing.Point(0, 20);
            this.NUM_Xcoord.Margin = new System.Windows.Forms.Padding(2);
            this.NUM_Xcoord.Name = "NUM_Xcoord";
            this.NUM_Xcoord.Size = new System.Drawing.Size(156, 20);
            this.NUM_Xcoord.TabIndex = 6;
            // 
            // TXT_Name
            // 
            this.TXT_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.TXT_Name.Location = new System.Drawing.Point(0, 0);
            this.TXT_Name.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(156, 20);
            this.TXT_Name.TabIndex = 5;
            // 
            // BTN_New
            // 
            this.BTN_New.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_New.Location = new System.Drawing.Point(2, 332);
            this.BTN_New.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_New.Name = "BTN_New";
            this.BTN_New.Size = new System.Drawing.Size(156, 19);
            this.BTN_New.TabIndex = 15;
            this.BTN_New.Text = "New";
            this.BTN_New.UseVisualStyleBackColor = true;
            this.BTN_New.Click += new System.EventHandler(this.BTN_New_Click);
            // 
            // PNL_Coords
            // 
            this.PNL_Coords.Controls.Add(this.LVW_Coords);
            this.PNL_Coords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Coords.Location = new System.Drawing.Point(0, 47);
            this.PNL_Coords.Margin = new System.Windows.Forms.Padding(2);
            this.PNL_Coords.Name = "PNL_Coords";
            this.PNL_Coords.Padding = new System.Windows.Forms.Padding(2);
            this.PNL_Coords.Size = new System.Drawing.Size(480, 353);
            this.PNL_Coords.TabIndex = 8;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(640, 400);
            this.Controls.Add(this.PNL_Coords);
            this.Controls.Add(this.PNL_Editor);
            this.Controls.Add(this.PNL_World);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Coordinate Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PNL_World.ResumeLayout(false);
            this.PNL_World.PerformLayout();
            this.PNL_Editor.ResumeLayout(false);
            this.PNL_Set.ResumeLayout(false);
            this.PNL_Set.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Zcoord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Ycoord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Xcoord)).EndInit();
            this.PNL_Coords.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PNL_World;
        private System.Windows.Forms.ListView LVW_Coords;
        private System.Windows.Forms.ComboBox CBX_WordlSel;
        private System.Windows.Forms.Button BTN_NewWorld;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Options;
        private System.Windows.Forms.ComboBox CBX_InstSel;
        private System.Windows.Forms.Panel PNL_Editor;
        private System.Windows.Forms.Button BTN_New;
        private System.Windows.Forms.ComboBox CBX_TagSel;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_TP;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Del;
        private System.Windows.Forms.ComboBox CBX_DimSel;
        private System.Windows.Forms.NumericUpDown NUM_Ycoord;
        private System.Windows.Forms.NumericUpDown NUM_Zcoord;
        private System.Windows.Forms.NumericUpDown NUM_Xcoord;
        private System.Windows.Forms.TextBox TXT_Name;
        private System.Windows.Forms.Panel PNL_Coords;
        private System.Windows.Forms.Panel PNL_Set;
    }
}

