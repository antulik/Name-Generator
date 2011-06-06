namespace Client
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnUnreg = new System.Windows.Forms.Button();
            this.cmbKey = new System.Windows.Forms.ComboBox();
            this.gvMappings = new System.Windows.Forms.DataGridView();
            this.chkAlt = new System.Windows.Forms.CheckBox();
            this.chkWin = new System.Windows.Forms.CheckBox();
            this.chkCtrl = new System.Windows.Forms.CheckBox();
            this.chkShift = new System.Windows.Forms.CheckBox();
            this.bsMappings = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotkeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvMappings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMappings)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReg.Location = new System.Drawing.Point(377, 270);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Reg";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnUnreg
            // 
            this.btnUnreg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUnreg.Location = new System.Drawing.Point(458, 270);
            this.btnUnreg.Name = "btnUnreg";
            this.btnUnreg.Size = new System.Drawing.Size(75, 23);
            this.btnUnreg.TabIndex = 3;
            this.btnUnreg.Text = "Unreg";
            this.btnUnreg.UseVisualStyleBackColor = true;
            this.btnUnreg.Click += new System.EventHandler(this.btnUnreg_Click);
            // 
            // cmbKey
            // 
            this.cmbKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbKey.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsMappings, "KeyCode", true));
            this.cmbKey.FormattingEnabled = true;
            this.cmbKey.Location = new System.Drawing.Point(12, 270);
            this.cmbKey.Name = "cmbKey";
            this.cmbKey.Size = new System.Drawing.Size(158, 21);
            this.cmbKey.TabIndex = 4;
            // 
            // gvMappings
            // 
            this.gvMappings.AllowUserToAddRows = false;
            this.gvMappings.AllowUserToDeleteRows = false;
            this.gvMappings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMappings.AutoGenerateColumns = false;
            this.gvMappings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMappings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.hotkeyDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.gvMappings.DataSource = this.bsMappings;
            this.gvMappings.Location = new System.Drawing.Point(3, 12);
            this.gvMappings.Name = "gvMappings";
            this.gvMappings.ReadOnly = true;
            this.gvMappings.Size = new System.Drawing.Size(537, 242);
            this.gvMappings.TabIndex = 5;
            // 
            // chkAlt
            // 
            this.chkAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAlt.AutoSize = true;
            this.chkAlt.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMappings, "Alt", true));
            this.chkAlt.Location = new System.Drawing.Point(179, 272);
            this.chkAlt.Name = "chkAlt";
            this.chkAlt.Size = new System.Drawing.Size(38, 17);
            this.chkAlt.TabIndex = 7;
            this.chkAlt.Text = "Alt";
            this.chkAlt.UseVisualStyleBackColor = true;
            // 
            // chkWin
            // 
            this.chkWin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkWin.AutoSize = true;
            this.chkWin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMappings, "Win", true));
            this.chkWin.Location = new System.Drawing.Point(223, 272);
            this.chkWin.Name = "chkWin";
            this.chkWin.Size = new System.Drawing.Size(45, 17);
            this.chkWin.TabIndex = 8;
            this.chkWin.Text = "Win";
            this.chkWin.UseVisualStyleBackColor = true;
            // 
            // chkCtrl
            // 
            this.chkCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCtrl.AutoSize = true;
            this.chkCtrl.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMappings, "Control", true));
            this.chkCtrl.Location = new System.Drawing.Point(274, 272);
            this.chkCtrl.Name = "chkCtrl";
            this.chkCtrl.Size = new System.Drawing.Size(41, 17);
            this.chkCtrl.TabIndex = 9;
            this.chkCtrl.Text = "Ctrl";
            this.chkCtrl.UseVisualStyleBackColor = true;
            // 
            // chkShift
            // 
            this.chkShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShift.AutoSize = true;
            this.chkShift.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMappings, "Shift", true));
            this.chkShift.Location = new System.Drawing.Point(321, 272);
            this.chkShift.Name = "chkShift";
            this.chkShift.Size = new System.Drawing.Size(47, 17);
            this.chkShift.TabIndex = 10;
            this.chkShift.Text = "Shift";
            this.chkShift.UseVisualStyleBackColor = true;
            // 
            // bsMappings
            // 
            this.bsMappings.DataSource = typeof(Client.KeyMapping);
            this.bsMappings.CurrentChanged += new System.EventHandler(this.bsMappings_CurrentChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotkeyDataGridViewTextBoxColumn
            // 
            this.hotkeyDataGridViewTextBoxColumn.DataPropertyName = "Hotkey";
            this.hotkeyDataGridViewTextBoxColumn.HeaderText = "Hotkey";
            this.hotkeyDataGridViewTextBoxColumn.Name = "hotkeyDataGridViewTextBoxColumn";
            this.hotkeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 301);
            this.Controls.Add(this.chkShift);
            this.Controls.Add(this.chkCtrl);
            this.Controls.Add(this.chkWin);
            this.Controls.Add(this.chkAlt);
            this.Controls.Add(this.gvMappings);
            this.Controls.Add(this.cmbKey);
            this.Controls.Add(this.btnUnreg);
            this.Controls.Add(this.btnReg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvMappings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMappings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnUnreg;
        private System.Windows.Forms.ComboBox cmbKey;
        private System.Windows.Forms.DataGridView gvMappings;
        private System.Windows.Forms.CheckBox chkAlt;
        private System.Windows.Forms.CheckBox chkWin;
        private System.Windows.Forms.CheckBox chkCtrl;
        private System.Windows.Forms.CheckBox chkShift;
        private System.Windows.Forms.BindingSource bsMappings;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotkeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}

