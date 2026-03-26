namespace DVLD
{
    partial class ctrDriverLicenses
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrDriverLicenses));
            this.tpInterLicenses = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tPLocalLicense = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rjDropdownMenu1 = new DVLD.RJDropdownMenu(this.components);
            this.licenseInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.rjDropdownMenu2 = new DVLD.RJDropdownMenu(this.components);
            this.licenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpInterLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tPLocalLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.rjDropdownMenu1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.rjDropdownMenu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpInterLicenses
            // 
            this.tpInterLicenses.Controls.Add(this.label2);
            this.tpInterLicenses.Controls.Add(this.dataGridView2);
            this.tpInterLicenses.Location = new System.Drawing.Point(4, 29);
            this.tpInterLicenses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpInterLicenses.Name = "tpInterLicenses";
            this.tpInterLicenses.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpInterLicenses.Size = new System.Drawing.Size(842, 245);
            this.tpInterLicenses.TabIndex = 1;
            this.tpInterLicenses.Text = "International Licenses";
            this.tpInterLicenses.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 20);
            this.label2.TabIndex = 136;
            this.label2.Text = "International Licenses History:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.rjDropdownMenu2;
            this.dataGridView2.Location = new System.Drawing.Point(7, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(828, 209);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tPLocalLicense
            // 
            this.tPLocalLicense.Controls.Add(this.label1);
            this.tPLocalLicense.Controls.Add(this.dataGridView1);
            this.tPLocalLicense.Location = new System.Drawing.Point(4, 29);
            this.tPLocalLicense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tPLocalLicense.Name = "tPLocalLicense";
            this.tPLocalLicense.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tPLocalLicense.Size = new System.Drawing.Size(842, 245);
            this.tPLocalLicense.TabIndex = 0;
            this.tPLocalLicense.Text = "Local Licenses";
            this.tPLocalLicense.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 136;
            this.label1.Text = "Local Licenses History:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.rjDropdownMenu1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(832, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseInformationToolStripMenuItem});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(180, 26);
            // 
            // licenseInformationToolStripMenuItem
            // 
            this.licenseInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("licenseInformationToolStripMenuItem.Image")));
            this.licenseInformationToolStripMenuItem.Name = "licenseInformationToolStripMenuItem";
            this.licenseInformationToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.licenseInformationToolStripMenuItem.Text = "License Information";
            this.licenseInformationToolStripMenuItem.Click += new System.EventHandler(this.licenseInformationToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPLocalLicense);
            this.tabControl1.Controls.Add(this.tpInterLicenses);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 278);
            this.tabControl1.TabIndex = 0;
            // 
            // rjDropdownMenu2
            // 
            this.rjDropdownMenu2.IsMainMenu = false;
            this.rjDropdownMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseInfoToolStripMenuItem});
            this.rjDropdownMenu2.MenuItemHeight = 25;
            this.rjDropdownMenu2.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu2.Name = "rjDropdownMenu2";
            this.rjDropdownMenu2.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu2.Size = new System.Drawing.Size(138, 26);
            // 
            // licenseInfoToolStripMenuItem
            // 
            this.licenseInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("licenseInfoToolStripMenuItem.Image")));
            this.licenseInfoToolStripMenuItem.Name = "licenseInfoToolStripMenuItem";
            this.licenseInfoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.licenseInfoToolStripMenuItem.Text = "License Info";
            this.licenseInfoToolStripMenuItem.Click += new System.EventHandler(this.licenseInfoToolStripMenuItem_Click);
            // 
            // ctrDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrDriverLicenses";
            this.Size = new System.Drawing.Size(850, 280);
            this.tpInterLicenses.ResumeLayout(false);
            this.tpInterLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tPLocalLicense.ResumeLayout(false);
            this.tPLocalLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.rjDropdownMenu1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.rjDropdownMenu2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpInterLicenses;
        private System.Windows.Forms.TabPage tPLocalLicense;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem licenseInformationToolStripMenuItem;
        private RJDropdownMenu rjDropdownMenu2;
        private System.Windows.Forms.ToolStripMenuItem licenseInfoToolStripMenuItem;
    }
}
