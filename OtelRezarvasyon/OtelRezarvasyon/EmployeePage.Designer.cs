
namespace OtelRezarvasyon
{
    partial class EmployeePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmployeeTasks = new System.Windows.Forms.Label();
            this.lblGorev = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEmployeeTasks);
            this.panel1.Controls.Add(this.lblGorev);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 733);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblEmployeeTasks
            // 
            this.lblEmployeeTasks.AutoSize = true;
            this.lblEmployeeTasks.Location = new System.Drawing.Point(84, 128);
            this.lblEmployeeTasks.Name = "lblEmployeeTasks";
            this.lblEmployeeTasks.Size = new System.Drawing.Size(77, 20);
            this.lblEmployeeTasks.TabIndex = 9;
            this.lblEmployeeTasks.Text = "Görevler....";
            // 
            // lblGorev
            // 
            this.lblGorev.Location = new System.Drawing.Point(37, 33);
            this.lblGorev.Name = "lblGorev";
            this.lblGorev.Size = new System.Drawing.Size(84, 40);
            this.lblGorev.TabIndex = 9;
            this.lblGorev.Text = "Görevim : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(734, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 553);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişisel Bilgiler";
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "EmployeePage";
            this.Size = new System.Drawing.Size(1097, 746);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmployeeTasks;
        private System.Windows.Forms.Label lblGorev;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
