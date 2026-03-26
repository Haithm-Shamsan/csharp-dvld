namespace DVLD
{
    partial class frmAddNewAppointmentTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewAppointmentTest));
            this.button1 = new System.Windows.Forms.Button();
            this.ctrSchduleTest1 = new DVLD.ctrSchduleTest();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 82;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrSchduleTest1
            // 
            this.ctrSchduleTest1.Location = new System.Drawing.Point(3, -1);
            this.ctrSchduleTest1.Name = "ctrSchduleTest1";
            this.ctrSchduleTest1.Size = new System.Drawing.Size(528, 713);
            this.ctrSchduleTest1.TabIndex = 0;
            this.ctrSchduleTest1.Load += new System.EventHandler(this.ctrSchduleTest1_Load);
            // 
            // frmAddNewAppointmentTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 713);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrSchduleTest1);
            this.Name = "frmAddNewAppointmentTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewAppointmentTest";
            this.Load += new System.EventHandler(this.frmAddNewAppointmentTest_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private ctrSchduleTest ctrSchduleTest1;
        private System.Windows.Forms.Button button1;
    }
}