namespace VisitorApp
{
    partial class FrmHome
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
            this.dgvListVisitor = new System.Windows.Forms.DataGridView();
            this.lblTotalVisitor = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gBPersonal = new System.Windows.Forms.GroupBox();
            this.txtPersonalDepartment = new System.Windows.Forms.TextBox();
            this.lblPersonalDep = new System.Windows.Forms.Label();
            this.txtPersonalSurname = new System.Windows.Forms.TextBox();
            this.lblPersonalName = new System.Windows.Forms.Label();
            this.lblPersonalSurname = new System.Windows.Forms.Label();
            this.txtPersonalName = new System.Windows.Forms.TextBox();
            this.btnSaved = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mskBPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbVisitReason = new System.Windows.Forms.ComboBox();
            this.lblSurName = new System.Windows.Forms.Label();
            this.dtpEnterDate = new System.Windows.Forms.DateTimePicker();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblVisitReason = new System.Windows.Forms.Label();
            this.lblEnterDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVisitor)).BeginInit();
            this.gBPersonal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListVisitor
            // 
            this.dgvListVisitor.AllowUserToAddRows = false;
            this.dgvListVisitor.AllowUserToDeleteRows = false;
            this.dgvListVisitor.AllowUserToResizeColumns = false;
            this.dgvListVisitor.AllowUserToResizeRows = false;
            this.dgvListVisitor.ColumnHeadersHeight = 29;
            this.dgvListVisitor.Location = new System.Drawing.Point(20, 8);
            this.dgvListVisitor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListVisitor.Name = "dgvListVisitor";
            this.dgvListVisitor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListVisitor.RowHeadersVisible = false;
            this.dgvListVisitor.RowHeadersWidth = 45;
            this.dgvListVisitor.RowTemplate.Height = 29;
            this.dgvListVisitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListVisitor.Size = new System.Drawing.Size(1338, 715);
            this.dgvListVisitor.TabIndex = 3;
            this.dgvListVisitor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListVisitor_CellContentClick);
            this.dgvListVisitor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListVisitor_RowHeaderMouseClick);
            // 
            // lblTotalVisitor
            // 
            this.lblTotalVisitor.AutoSize = true;
            this.lblTotalVisitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTotalVisitor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalVisitor.Location = new System.Drawing.Point(1175, 677);
            this.lblTotalVisitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalVisitor.Name = "lblTotalVisitor";
            this.lblTotalVisitor.Size = new System.Drawing.Size(141, 22);
            this.lblTotalVisitor.TabIndex = 3;
            this.lblTotalVisitor.Text = "Ziyaretçi Sayısı:";
            this.lblTotalVisitor.Click += new System.EventHandler(this.lblTotalVisitor_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcel.Location = new System.Drawing.Point(979, 740);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(183, 55);
            this.btnExcel.TabIndex = 13;
            this.btnExcel.Text = "Excel Çıktısı";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(20, 740);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 55);
            this.button2.TabIndex = 14;
            this.button2.Text = "Geçmiş Kayıtlar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(1175, 740);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 55);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "ZİYARETÇİ ÇIKIŞ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gBPersonal
            // 
            this.gBPersonal.Controls.Add(this.txtPersonalDepartment);
            this.gBPersonal.Controls.Add(this.lblPersonalDep);
            this.gBPersonal.Controls.Add(this.txtPersonalSurname);
            this.gBPersonal.Controls.Add(this.lblPersonalName);
            this.gBPersonal.Controls.Add(this.lblPersonalSurname);
            this.gBPersonal.Controls.Add(this.txtPersonalName);
            this.gBPersonal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gBPersonal.Location = new System.Drawing.Point(1396, 333);
            this.gBPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.gBPersonal.Name = "gBPersonal";
            this.gBPersonal.Padding = new System.Windows.Forms.Padding(2);
            this.gBPersonal.Size = new System.Drawing.Size(437, 228);
            this.gBPersonal.TabIndex = 2;
            this.gBPersonal.TabStop = false;
            this.gBPersonal.Text = "Ziyaret Edilen Personel";
            // 
            // txtPersonalDepartment
            // 
            this.txtPersonalDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPersonalDepartment.Location = new System.Drawing.Point(161, 158);
            this.txtPersonalDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.txtPersonalDepartment.Name = "txtPersonalDepartment";
            this.txtPersonalDepartment.Size = new System.Drawing.Size(239, 30);
            this.txtPersonalDepartment.TabIndex = 9;
            // 
            // lblPersonalDep
            // 
            this.lblPersonalDep.AutoSize = true;
            this.lblPersonalDep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPersonalDep.Location = new System.Drawing.Point(64, 165);
            this.lblPersonalDep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonalDep.Name = "lblPersonalDep";
            this.lblPersonalDep.Size = new System.Drawing.Size(64, 23);
            this.lblPersonalDep.TabIndex = 11;
            this.lblPersonalDep.Text = "Bölüm";
            // 
            // txtPersonalSurname
            // 
            this.txtPersonalSurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPersonalSurname.Location = new System.Drawing.Point(160, 99);
            this.txtPersonalSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtPersonalSurname.Name = "txtPersonalSurname";
            this.txtPersonalSurname.Size = new System.Drawing.Size(239, 30);
            this.txtPersonalSurname.TabIndex = 8;
            // 
            // lblPersonalName
            // 
            this.lblPersonalName.AutoSize = true;
            this.lblPersonalName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPersonalName.Location = new System.Drawing.Point(89, 49);
            this.lblPersonalName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonalName.Name = "lblPersonalName";
            this.lblPersonalName.Size = new System.Drawing.Size(39, 23);
            this.lblPersonalName.TabIndex = 8;
            this.lblPersonalName.Text = "Adı";
            // 
            // lblPersonalSurname
            // 
            this.lblPersonalSurname.AutoSize = true;
            this.lblPersonalSurname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPersonalSurname.Location = new System.Drawing.Point(64, 102);
            this.lblPersonalSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonalSurname.Name = "lblPersonalSurname";
            this.lblPersonalSurname.Size = new System.Drawing.Size(66, 23);
            this.lblPersonalSurname.TabIndex = 7;
            this.lblPersonalSurname.Text = "Soyadı";
            // 
            // txtPersonalName
            // 
            this.txtPersonalName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPersonalName.Location = new System.Drawing.Point(160, 46);
            this.txtPersonalName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPersonalName.Name = "txtPersonalName";
            this.txtPersonalName.Size = new System.Drawing.Size(239, 30);
            this.txtPersonalName.TabIndex = 7;
            // 
            // btnSaved
            // 
            this.btnSaved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaved.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaved.Location = new System.Drawing.Point(1620, 728);
            this.btnSaved.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(213, 61);
            this.btnSaved.TabIndex = 11;
            this.btnSaved.Text = "ZİYARETÇİ KAYDET";
            this.btnSaved.UseVisualStyleBackColor = false;
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(1540, 576);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(293, 138);
            this.txtDescription.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(1396, 576);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 23);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Açıklama";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.mskBPhone);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.cmbVisitReason);
            this.groupBox1.Controls.Add(this.lblSurName);
            this.groupBox1.Controls.Add(this.dtpEnterDate);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.txtCardNo);
            this.groupBox1.Controls.Add(this.lblCardNo);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.lblVisitReason);
            this.groupBox1.Controls.Add(this.lblEnterDate);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(1396, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(437, 321);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ziyaretçi";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(174, 27);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 30);
            this.txtName.TabIndex = 1;
            // 
            // mskBPhone
            // 
            this.mskBPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mskBPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mskBPhone.Location = new System.Drawing.Point(174, 142);
            this.mskBPhone.Margin = new System.Windows.Forms.Padding(2);
            this.mskBPhone.Mask = "(999) 000-0000";
            this.mskBPhone.Name = "mskBPhone";
            this.mskBPhone.Size = new System.Drawing.Size(239, 30);
            this.mskBPhone.TabIndex = 4;
            this.mskBPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskBPhone_MaskInputRejected);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(102, 34);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 23);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Adı";
            // 
            // cmbVisitReason
            // 
            this.cmbVisitReason.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbVisitReason.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbVisitReason.FormattingEnabled = true;
            this.cmbVisitReason.Location = new System.Drawing.Point(174, 189);
            this.cmbVisitReason.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVisitReason.Name = "cmbVisitReason";
            this.cmbVisitReason.Size = new System.Drawing.Size(239, 31);
            this.cmbVisitReason.TabIndex = 5;
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSurName.Location = new System.Drawing.Point(83, 76);
            this.lblSurName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(66, 23);
            this.lblSurName.TabIndex = 38;
            this.lblSurName.Text = "Soyadı";
            // 
            // dtpEnterDate
            // 
            this.dtpEnterDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpEnterDate.Enabled = false;
            this.dtpEnterDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpEnterDate.Location = new System.Drawing.Point(174, 239);
            this.dtpEnterDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEnterDate.Name = "dtpEnterDate";
            this.dtpEnterDate.Size = new System.Drawing.Size(239, 30);
            this.dtpEnterDate.TabIndex = 999;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(49, 149);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(102, 23);
            this.lblPhone.TabIndex = 37;
            this.lblPhone.Text = "Telefon No";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCardNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCardNo.Location = new System.Drawing.Point(174, 106);
            this.txtCardNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCardNo.MaxLength = 2;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(239, 30);
            this.txtCardNo.TabIndex = 3;
            this.txtCardNo.TextChanged += new System.EventHandler(this.txtCardNo_TextChanged);
            this.txtCardNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNo_KeyPress_1);
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardNo.Location = new System.Drawing.Point(72, 113);
            this.lblCardNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(78, 23);
            this.lblCardNo.TabIndex = 36;
            this.lblCardNo.Text = "Kart No";
            // 
            // txtSurname
            // 
            this.txtSurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSurname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSurname.Location = new System.Drawing.Point(174, 69);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(239, 30);
            this.txtSurname.TabIndex = 2;
            // 
            // lblVisitReason
            // 
            this.lblVisitReason.AutoSize = true;
            this.lblVisitReason.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVisitReason.Location = new System.Drawing.Point(14, 197);
            this.lblVisitReason.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVisitReason.Name = "lblVisitReason";
            this.lblVisitReason.Size = new System.Drawing.Size(136, 23);
            this.lblVisitReason.TabIndex = 35;
            this.lblVisitReason.Text = "Ziyaret Nedeni";
            // 
            // lblEnterDate
            // 
            this.lblEnterDate.AutoSize = true;
            this.lblEnterDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnterDate.Location = new System.Drawing.Point(44, 246);
            this.lblEnterDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterDate.Name = "lblEnterDate";
            this.lblEnterDate.Size = new System.Drawing.Size(106, 23);
            this.lblEnterDate.TabIndex = 34;
            this.lblEnterDate.Text = "Giriş Tarihi";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(2646, 925);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBPersonal);
            this.Controls.Add(this.btnSaved);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lblTotalVisitor);
            this.Controls.Add(this.dgvListVisitor);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHome_FormClosed);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVisitor)).EndInit();
            this.gBPersonal.ResumeLayout(false);
            this.gBPersonal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvListVisitor;
        private Label lblTotalVisitor;
        private Button btnExcel;
        private Button button2;
        private Button btnExit;
        private GroupBox gBPersonal;
        private TextBox txtPersonalDepartment;
        private Label lblPersonalDep;
        private TextBox txtPersonalSurname;
        private Label lblPersonalName;
        private Label lblPersonalSurname;
        private TextBox txtPersonalName;
        private Button btnSaved;
        private TextBox txtDescription;
        private Label lblDescription;
        private GroupBox groupBox1;
        private TextBox txtName;
        private MaskedTextBox mskBPhone;
        private Label lblName;
        private ComboBox cmbVisitReason;
        private Label lblSurName;
        private DateTimePicker dtpEnterDate;
        private Label lblPhone;
        private TextBox txtCardNo;
        private Label lblCardNo;
        private TextBox txtSurname;
        private Label lblVisitReason;
        private Label lblEnterDate;
    }
}