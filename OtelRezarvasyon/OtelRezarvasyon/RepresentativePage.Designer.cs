
namespace OtelRezarvasyon
{
    partial class RepresentativePage
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
            this.btnOnay = new System.Windows.Forms.Button();
            this.dGWMusteriOdalar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWMusteriOdalar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOnay);
            this.panel1.Controls.Add(this.dGWMusteriOdalar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 735);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnOnay
            // 
            this.btnOnay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOnay.Location = new System.Drawing.Point(553, 539);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(173, 38);
            this.btnOnay.TabIndex = 5;
            this.btnOnay.Text = "ONAYLA";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // dGWMusteriOdalar
            // 
            this.dGWMusteriOdalar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGWMusteriOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWMusteriOdalar.Location = new System.Drawing.Point(17, 118);
            this.dGWMusteriOdalar.Name = "dGWMusteriOdalar";
            this.dGWMusteriOdalar.RowHeadersWidth = 51;
            this.dGWMusteriOdalar.RowTemplate.Height = 29;
            this.dGWMusteriOdalar.Size = new System.Drawing.Size(709, 387);
            this.dGWMusteriOdalar.TabIndex = 5;
            this.dGWMusteriOdalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVMusteriOdalar_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(756, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 667);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // RepresentativePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "RepresentativePage";
            this.Size = new System.Drawing.Size(1244, 764);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGWMusteriOdalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.DataGridView dGWMusteriOdalar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
