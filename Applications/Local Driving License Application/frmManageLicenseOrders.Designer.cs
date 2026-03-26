namespace DVLD
{
    partial class frmManageLicenseOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLicenseOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rjDropdownMenu1 = new DVLD.RJDropdownMenu(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.CancleApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.schdualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schdulevisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleWrittienTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.rjDropdownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbmFilterBy);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 78);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search By";
            // 
            // cbmFilterBy
            // 
            this.cbmFilterBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmFilterBy.FormattingEnabled = true;
            this.cbmFilterBy.Items.AddRange(new object[] {
            "ApplicationID",
            "NationalNo",
            "FullName",
            "ApplicationStatus"});
            this.cbmFilterBy.Location = new System.Drawing.Point(74, 36);
            this.cbmFilterBy.Name = "cbmFilterBy";
            this.cbmFilterBy.Size = new System.Drawing.Size(211, 23);
            this.cbmFilterBy.TabIndex = 8;
            this.cbmFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbmFilterBy_SelectedIndexChanged);
            this.cbmFilterBy.SelectedValueChanged += new System.EventHandler(this.cbmFilterBy_SelectedValueChanged);
            this.cbmFilterBy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbmFilterBy_MouseClick);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(291, 36);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(154, 24);
            this.txtFilter.TabIndex = 9;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(548, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(412, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Local Driving License Applications";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1304, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 61);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1223, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 37);
            this.button2.TabIndex = 189;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsNumber.ForeColor = System.Drawing.Color.Black;
            this.lblRecordsNumber.Location = new System.Drawing.Point(175, 599);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(0, 18);
            this.lblRecordsNumber.TabIndex = 188;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 187;
            this.label2.Text = "# Records Number :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 33;
            this.dataGridView1.ContextMenuStrip = this.rjDropdownMenu1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1384, 265);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.EditApplication,
            this.DeleteApplication,
            this.CancleApplication,
            this.schdualToolStripMenuItem,
            this.issueToolStripMenuItem,
            this.licenseInfoToolStripMenuItem,
            this.driverLicenseHistoryToolStripMenuItem});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(226, 180);
            this.rjDropdownMenu1.Opening += new System.ComponentModel.CancelEventHandler(this.rjDropdownMenu1_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Applications Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // EditApplication
            // 
            this.EditApplication.Image = ((System.Drawing.Image)(resources.GetObject("EditApplication.Image")));
            this.EditApplication.Name = "EditApplication";
            this.EditApplication.Size = new System.Drawing.Size(225, 22);
            this.EditApplication.Text = "Edit Application";
            this.EditApplication.Click += new System.EventHandler(this.EditApplication_Click);
            // 
            // DeleteApplication
            // 
            this.DeleteApplication.Image = ((System.Drawing.Image)(resources.GetObject("DeleteApplication.Image")));
            this.DeleteApplication.Name = "DeleteApplication";
            this.DeleteApplication.Size = new System.Drawing.Size(225, 22);
            this.DeleteApplication.Text = "Delete Application";
            this.DeleteApplication.Click += new System.EventHandler(this.DeleteApplication_Click);
            // 
            // CancleApplication
            // 
            this.CancleApplication.Image = ((System.Drawing.Image)(resources.GetObject("CancleApplication.Image")));
            this.CancleApplication.Name = "CancleApplication";
            this.CancleApplication.Size = new System.Drawing.Size(225, 22);
            this.CancleApplication.Text = "Cancle Application";
            this.CancleApplication.Click += new System.EventHandler(this.CancleApplication_Click);
            // 
            // schdualToolStripMenuItem
            // 
            this.schdualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schdulevisionTestToolStripMenuItem,
            this.sechduleWrittienTestToolStripMenuItem,
            this.sechduleStreetTestToolStripMenuItem});
            this.schdualToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("schdualToolStripMenuItem.Image")));
            this.schdualToolStripMenuItem.Name = "schdualToolStripMenuItem";
            this.schdualToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.schdualToolStripMenuItem.Text = "Sechdule Test ";
            this.schdualToolStripMenuItem.Click += new System.EventHandler(this.sedhudalToolStripMenuItem_Click);
            // 
            // schdulevisionTestToolStripMenuItem
            // 
            this.schdulevisionTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("schdulevisionTestToolStripMenuItem.Image")));
            this.schdulevisionTestToolStripMenuItem.Name = "schdulevisionTestToolStripMenuItem";
            this.schdulevisionTestToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.schdulevisionTestToolStripMenuItem.Text = "Sechdule Vision Test";
            this.schdulevisionTestToolStripMenuItem.Click += new System.EventHandler(this.visionTestToolStripMenuItem_Click);
            // 
            // sechduleWrittienTestToolStripMenuItem
            // 
            this.sechduleWrittienTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sechduleWrittienTestToolStripMenuItem.Image")));
            this.sechduleWrittienTestToolStripMenuItem.Name = "sechduleWrittienTestToolStripMenuItem";
            this.sechduleWrittienTestToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.sechduleWrittienTestToolStripMenuItem.Text = "Sechdule Writtien Test";
            this.sechduleWrittienTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleWrittienTestToolStripMenuItem_Click);
            // 
            // sechduleStreetTestToolStripMenuItem
            // 
            this.sechduleStreetTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sechduleStreetTestToolStripMenuItem.Image")));
            this.sechduleStreetTestToolStripMenuItem.Name = "sechduleStreetTestToolStripMenuItem";
            this.sechduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.sechduleStreetTestToolStripMenuItem.Text = "Sechdule Street Test";
            this.sechduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleStreetTestToolStripMenuItem_Click);
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueToolStripMenuItem.Image")));
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.issueToolStripMenuItem.Text = "Issue License (FirstTime)";
            this.issueToolStripMenuItem.Click += new System.EventHandler(this.issueToolStripMenuItem_Click);
            // 
            // licenseInfoToolStripMenuItem
            // 
            this.licenseInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("licenseInfoToolStripMenuItem.Image")));
            this.licenseInfoToolStripMenuItem.Name = "licenseInfoToolStripMenuItem";
            this.licenseInfoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.licenseInfoToolStripMenuItem.Text = "License Info";
            this.licenseInfoToolStripMenuItem.Click += new System.EventHandler(this.licenseInfoToolStripMenuItem_Click);
            // 
            // driverLicenseHistoryToolStripMenuItem
            // 
            this.driverLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("driverLicenseHistoryToolStripMenuItem.Image")));
            this.driverLicenseHistoryToolStripMenuItem.Name = "driverLicenseHistoryToolStripMenuItem";
            this.driverLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.driverLicenseHistoryToolStripMenuItem.Text = "Driver License History";
            this.driverLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.driverLicenseHistoryToolStripMenuItem_Click);
            // 
            // frmManageLicenseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1388, 629);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblRecordsNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmManageLicenseOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.frmManageLicenseOrders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.rjDropdownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmFilterBy;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditApplication;
        private System.Windows.Forms.ToolStripMenuItem DeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem CancleApplication;
        private System.Windows.Forms.ToolStripMenuItem schdualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schdulevisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleWrittienTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Label label2;
    }
}