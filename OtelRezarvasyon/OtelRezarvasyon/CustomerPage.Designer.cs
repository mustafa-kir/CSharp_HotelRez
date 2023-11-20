
namespace OtelRezarvasyon
{
    partial class CustomerPage
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBxRoomDayPriceFilter = new System.Windows.Forms.TextBox();
            this.tBxRoomCapacityFilter = new System.Windows.Forms.TextBox();
            this.btnRoomReservation = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dGWMusteriOdalar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblMusteriFilitrele2 = new System.Windows.Forms.Label();
            this.lblMusteriFilitrele1 = new System.Windows.Forms.Label();
            this.tBxUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBxPassword = new System.Windows.Forms.TextBox();
            this.tBxAssignment = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWMusteriOdalar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tBxRoomDayPriceFilter);
            this.panel2.Controls.Add(this.tBxRoomCapacityFilter);
            this.panel2.Controls.Add(this.btnRoomReservation);
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.dGWMusteriOdalar);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lblMusteriFilitrele2);
            this.panel2.Controls.Add(this.lblMusteriFilitrele1);
            this.panel2.Location = new System.Drawing.Point(8, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 709);
            this.panel2.TabIndex = 3;
            // 
            // tBxRoomDayPriceFilter
            // 
            this.tBxRoomDayPriceFilter.Location = new System.Drawing.Point(232, 79);
            this.tBxRoomDayPriceFilter.Name = "tBxRoomDayPriceFilter";
            this.tBxRoomDayPriceFilter.Size = new System.Drawing.Size(106, 27);
            this.tBxRoomDayPriceFilter.TabIndex = 6;
            // 
            // tBxRoomCapacityFilter
            // 
            this.tBxRoomCapacityFilter.Location = new System.Drawing.Point(232, 23);
            this.tBxRoomCapacityFilter.Name = "tBxRoomCapacityFilter";
            this.tBxRoomCapacityFilter.Size = new System.Drawing.Size(106, 27);
            this.tBxRoomCapacityFilter.TabIndex = 5;
            // 
            // btnRoomReservation
            // 
            this.btnRoomReservation.Location = new System.Drawing.Point(542, 576);
            this.btnRoomReservation.Name = "btnRoomReservation";
            this.btnRoomReservation.Size = new System.Drawing.Size(127, 26);
            this.btnRoomReservation.TabIndex = 3;
            this.btnRoomReservation.Text = "Odayı Tut";
            this.btnRoomReservation.UseVisualStyleBackColor = true;
            this.btnRoomReservation.Click += new System.EventHandler(this.btnRoomReservation_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(479, 129);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(190, 26);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filitrele";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dGWMusteriOdalar
            // 
            this.dGWMusteriOdalar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGWMusteriOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWMusteriOdalar.Location = new System.Drawing.Point(18, 161);
            this.dGWMusteriOdalar.Name = "dGWMusteriOdalar";
            this.dGWMusteriOdalar.RowHeadersWidth = 51;
            this.dGWMusteriOdalar.RowTemplate.Height = 29;
            this.dGWMusteriOdalar.Size = new System.Drawing.Size(651, 387);
            this.dGWMusteriOdalar.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBxAssignment);
            this.groupBox1.Controls.Add(this.tBxPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.tBxUserName);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Location = new System.Drawing.Point(713, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 626);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(21, 103);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(92, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Kullanıcı Adı";
            // 
            // lblMusteriFilitrele2
            // 
            this.lblMusteriFilitrele2.Location = new System.Drawing.Point(18, 82);
            this.lblMusteriFilitrele2.Name = "lblMusteriFilitrele2";
            this.lblMusteriFilitrele2.Size = new System.Drawing.Size(192, 31);
            this.lblMusteriFilitrele2.TabIndex = 3;
            this.lblMusteriFilitrele2.Text = "Oda Günlük Kişi Başı Ücret";
            // 
            // lblMusteriFilitrele1
            // 
            this.lblMusteriFilitrele1.Location = new System.Drawing.Point(18, 26);
            this.lblMusteriFilitrele1.Name = "lblMusteriFilitrele1";
            this.lblMusteriFilitrele1.Size = new System.Drawing.Size(156, 26);
            this.lblMusteriFilitrele1.TabIndex = 3;
            this.lblMusteriFilitrele1.Text = "Oda Kişi Sayısı";
            // 
            // tBxUserName
            // 
            this.tBxUserName.Enabled = false;
            this.tBxUserName.Location = new System.Drawing.Point(129, 100);
            this.tBxUserName.Name = "tBxUserName";
            this.tBxUserName.Size = new System.Drawing.Size(105, 27);
            this.tBxUserName.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(21, 151);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(39, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Görevi";
            // 
            // tBxPassword
            // 
            this.tBxPassword.Enabled = false;
            this.tBxPassword.Location = new System.Drawing.Point(131, 156);
            this.tBxPassword.Name = "tBxPassword";
            this.tBxPassword.Size = new System.Drawing.Size(103, 27);
            this.tBxPassword.TabIndex = 4;
            // 
            // tBxAssignment
            // 
            this.tBxAssignment.Enabled = false;
            this.tBxAssignment.Location = new System.Drawing.Point(129, 204);
            this.tBxAssignment.Name = "tBxAssignment";
            this.tBxAssignment.Size = new System.Drawing.Size(105, 27);
            this.tBxAssignment.TabIndex = 5;
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "CustomerPage";
            this.Size = new System.Drawing.Size(1059, 735);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWMusteriOdalar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRoomReservation;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dGWMusteriOdalar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMusteriFilitrele2;
        private System.Windows.Forms.Label lblMusteriFilitrele1;
        private System.Windows.Forms.TextBox tBxRoomDayPriceFilter;
        private System.Windows.Forms.TextBox tBxRoomCapacityFilter;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tBxAssignment;
        private System.Windows.Forms.TextBox tBxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tBxUserName;
    }
}
