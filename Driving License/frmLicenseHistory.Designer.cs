namespace DVLD
{
    partial class frmLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenseHistory));
            this.label1 = new System.Windows.Forms.Label();
            this.ctrDriverLicenses1 = new DVLD.ctrDriverLicenses();
            this.ctrPersonCard1 = new DVLD.ctrPersonCard();
            this.rjDropdownMenu1 = new DVLD.RJDropdownMenu(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rjDropdownMenu1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Driver License History";
            // 
            // ctrDriverLicenses1
            // 
            this.ctrDriverLicenses1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrDriverLicenses1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrDriverLicenses1.Location = new System.Drawing.Point(1, 361);
            this.ctrDriverLicenses1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrDriverLicenses1.Name = "ctrDriverLicenses1";
            this.ctrDriverLicenses1.Size = new System.Drawing.Size(851, 280);
            this.ctrDriverLicenses1.TabIndex = 1;
            this.ctrDriverLicenses1.Load += new System.EventHandler(this.ctrDriverLicenses1_Load);
            // 
            // ctrPersonCard1
            // 
            this.ctrPersonCard1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrPersonCard1.Location = new System.Drawing.Point(7, 20);
            this.ctrPersonCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrPersonCard1.Name = "ctrPersonCard1";
            this.ctrPersonCard1.Size = new System.Drawing.Size(844, 233);
            this.ctrPersonCard1.TabIndex = 0;
            this.ctrPersonCard1.OnPersonSelected += new System.Action<int>(this.ctrPersonCard1_OnPersonSelected);
            this.ctrPersonCard1.Load += new System.EventHandler(this.ctrPersonCard1_Load);
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(170, 26);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseInfoToolStripMenuItem.Image")));
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrPersonCard1);
            this.groupBox1.Location = new System.Drawing.Point(1, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 272);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Information";
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(852, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrDriverLicenses1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLicenseHistory";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            this.rjDropdownMenu1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrPersonCard ctrPersonCard1;
        private ctrDriverLicenses ctrDriverLicenses1;
        private RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}