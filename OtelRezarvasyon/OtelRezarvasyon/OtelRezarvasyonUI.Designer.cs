
namespace OtelRezarvasyon.FormsUI
{
    partial class OtelRezarvasyonUI
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
            this.loginPage1 = new OtelRezarvasyon.LoginPage();
            this.customerPage1 = new OtelRezarvasyon.CustomerPage();
            this.employeePage1 = new OtelRezarvasyon.EmployeePage();
            this.managerPage1 = new OtelRezarvasyon.ManagerPage();
            this.representativePage1 = new OtelRezarvasyon.RepresentativePage();
            this.SuspendLayout();
            // 
            // loginPage1
            // 
            this.loginPage1.Location = new System.Drawing.Point(11, 18);
            this.loginPage1.Name = "loginPage1";
            this.loginPage1.Size = new System.Drawing.Size(1101, 690);
            this.loginPage1.TabIndex = 0;
            // 
            // customerPage1
            // 
            this.customerPage1.Location = new System.Drawing.Point(11, 18);
            this.customerPage1.Name = "customerPage1";
            this.customerPage1.Size = new System.Drawing.Size(1110, 696);
            this.customerPage1.TabIndex = 1;
            // 
            // employeePage1
            // 
            this.employeePage1.Location = new System.Drawing.Point(12, 12);
            this.employeePage1.Name = "employeePage1";
            this.employeePage1.Size = new System.Drawing.Size(1118, 717);
            this.employeePage1.TabIndex = 2;
            // 
            // managerPage1
            // 
            this.managerPage1.Location = new System.Drawing.Point(12, 12);
            this.managerPage1.Name = "managerPage1";
            this.managerPage1.Size = new System.Drawing.Size(1118, 717);
            this.managerPage1.TabIndex = 3;
            // 
            // representativePage1
            // 
            this.representativePage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.representativePage1.Location = new System.Drawing.Point(12, 12);
            this.representativePage1.Name = "representativePage1";
            this.representativePage1.Size = new System.Drawing.Size(1083, 713);
            this.representativePage1.TabIndex = 4;
            // 
            // OtelRezarvasyonUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 737);
            this.Controls.Add(this.representativePage1);
            this.Controls.Add(this.managerPage1);
            this.Controls.Add(this.employeePage1);
            this.Controls.Add(this.customerPage1);
            this.Controls.Add(this.loginPage1);
            this.Name = "OtelRezarvasyonUI";
            this.Text = "OtelRezarvasyonUI";
            this.Load += new System.EventHandler(this.OtelRezarvasyonUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LoginPage loginPage1;
        private CustomerPage customerPage1;
        private EmployeePage employeePage1;
        private ManagerPage managerPage1;
        private RepresentativePage representativePage1;
    }
}