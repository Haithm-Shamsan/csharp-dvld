namespace DVLD
{
    partial class frmLocalDrivingLicenseAppInfo
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
            this.ApplicationBasicInfo2 = new DVLD.ctrApplicationBasicInfo();
            this.ctrLocalLicenseAppInfo1 = new DVLD.ctrLocalLicenseAppInfo();
            this.SuspendLayout();
            // 
            // ApplicationBasicInfo2
            // 
            this.ApplicationBasicInfo2.Location = new System.Drawing.Point(-2, 168);
            this.ApplicationBasicInfo2.Name = "ApplicationBasicInfo2";
            this.ApplicationBasicInfo2.Size = new System.Drawing.Size(802, 219);
            this.ApplicationBasicInfo2.TabIndex = 1;
            this.ApplicationBasicInfo2.Load += new System.EventHandler(this.ApplicationBasicInfo2_Load);
            // 
            // ctrLocalLicenseAppInfo1
            // 
            this.ctrLocalLicenseAppInfo1.Location = new System.Drawing.Point(-2, 12);
            this.ctrLocalLicenseAppInfo1.Name = "ctrLocalLicenseAppInfo1";
            this.ctrLocalLicenseAppInfo1.Size = new System.Drawing.Size(802, 150);
            this.ctrLocalLicenseAppInfo1.TabIndex = 0;
            this.ctrLocalLicenseAppInfo1.Load += new System.EventHandler(this.ctrLocalLicenseAppInfo1_Load);
            // 
            // frmLocalDrivingLicenseAppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.ApplicationBasicInfo2);
            this.Controls.Add(this.ctrLocalLicenseAppInfo1);
            this.Name = "frmLocalDrivingLicenseAppInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLocalDrivingLicenseAppInfo";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseAppInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrApplicationBasicInfo applicationBasicInfo1;
        private ctrLocalLicenseAppInfo ctrLocalLicenseAppInfo1;
        private DVLD.ctrApplicationBasicInfo ApplicationBasicInfo2;
    }
}