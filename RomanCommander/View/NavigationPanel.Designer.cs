namespace RomanCommander.View
{
    partial class NavigationPanel
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
            this.BrowseView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExtentionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AttributesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullPathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SelectDriveComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowseView
            // 
            this.BrowseView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.ExtentionColumn,
            this.SizeColumn,
            this.AttributesColumn,
            this.FullPathColumn});
            this.BrowseView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseView.FullRowSelect = true;
            this.BrowseView.Location = new System.Drawing.Point(0, 0);
            this.BrowseView.Name = "BrowseView";
            this.BrowseView.Size = new System.Drawing.Size(683, 649);
            this.BrowseView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.BrowseView.TabIndex = 0;
            this.BrowseView.UseCompatibleStateImageBehavior = false;
            this.BrowseView.View = System.Windows.Forms.View.Details;
            this.BrowseView.Enter += new System.EventHandler(this.BrowseView_Enter);
            this.BrowseView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BrowseView_KeyPress);
            this.BrowseView.Leave += new System.EventHandler(this.BrowseView_Leave);
            this.BrowseView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BrowseView_MouseDoubleClick);
            // 
            // NameColumn
            // 
            this.NameColumn.Tag = "";
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 209;
            // 
            // ExtentionColumn
            // 
            this.ExtentionColumn.Text = "Extention";
            // 
            // SizeColumn
            // 
            this.SizeColumn.Text = "Size";
            // 
            // AttributesColumn
            // 
            this.AttributesColumn.DisplayIndex = 4;
            this.AttributesColumn.Text = "Attributes";
            // 
            // FullPathColumn
            // 
            this.FullPathColumn.DisplayIndex = 3;
            this.FullPathColumn.Text = "Full Path";
            this.FullPathColumn.Width = 115;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.BrowseView);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(683, 649);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(683, 674);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectDriveComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(135, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // SelectDriveComboBox
            // 
            this.SelectDriveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectDriveComboBox.Items.AddRange(new object[] {
            "Environment.GetLogicalDrives()"});
            this.SelectDriveComboBox.Name = "SelectDriveComboBox";
            this.SelectDriveComboBox.Size = new System.Drawing.Size(121, 25);
            this.SelectDriveComboBox.Tag = "Select Drive";
            this.SelectDriveComboBox.DropDownClosed += new System.EventHandler(this.SelectDriveComboBox_SelectedIndexChanged);
            // 
            // NavigationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "NavigationPanel";
            this.Size = new System.Drawing.Size(683, 674);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView BrowseView;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox SelectDriveComboBox;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader ExtentionColumn;
        private System.Windows.Forms.ColumnHeader SizeColumn;
        private System.Windows.Forms.ColumnHeader FullPathColumn;
        private System.Windows.Forms.ColumnHeader AttributesColumn;
    }
}
