namespace VisitorApp
{
    partial class FrmExitVisitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExitVisitor));
            this.dgvExitVisitor = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.dtpFilter2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFilter1 = new System.Windows.Forms.DateTimePicker();
            this.lblTotalVisitor = new System.Windows.Forms.Label();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExitVisitor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExitVisitor
            // 
            this.dgvExitVisitor.AllowUserToAddRows = false;
            this.dgvExitVisitor.AllowUserToDeleteRows = false;
            this.dgvExitVisitor.AllowUserToResizeColumns = false;
            this.dgvExitVisitor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExitVisitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExitVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExitVisitor.Location = new System.Drawing.Point(56, 71);
            this.dgvExitVisitor.Name = "dgvExitVisitor";
            this.dgvExitVisitor.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExitVisitor.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExitVisitor.RowHeadersVisible = false;
            this.dgvExitVisitor.RowHeadersWidth = 70;
            this.dgvExitVisitor.RowTemplate.Height = 29;
            this.dgvExitVisitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExitVisitor.Size = new System.Drawing.Size(1627, 733);
            this.dgvExitVisitor.TabIndex = 8;
            this.dgvExitVisitor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExitVisitor_CellContentClick);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnList.Location = new System.Drawing.Point(821, 1);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(131, 55);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dtpFilter2
            // 
            this.dtpFilter2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFilter2.Location = new System.Drawing.Point(529, 1);
            this.dtpFilter2.Name = "dtpFilter2";
            this.dtpFilter2.Size = new System.Drawing.Size(258, 30);
            this.dtpFilter2.TabIndex = 6;
            this.dtpFilter2.ValueChanged += new System.EventHandler(this.dtpFilter2_ValueChanged);
            // 
            // dtpFilter1
            // 
            this.dtpFilter1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFilter1.Location = new System.Drawing.Point(253, 1);
            this.dtpFilter1.Name = "dtpFilter1";
            this.dtpFilter1.Size = new System.Drawing.Size(256, 30);
            this.dtpFilter1.TabIndex = 5;
            // 
            // lblTotalVisitor
            // 
            this.lblTotalVisitor.AutoSize = true;
            this.lblTotalVisitor.BackColor = System.Drawing.SystemColors.Info;
            this.lblTotalVisitor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalVisitor.Location = new System.Drawing.Point(1503, 756);
            this.lblTotalVisitor.Name = "lblTotalVisitor";
            this.lblTotalVisitor.Size = new System.Drawing.Size(141, 22);
            this.lblTotalVisitor.TabIndex = 9;
            this.lblTotalVisitor.Text = "Ziyaretçi Sayısı:";
            this.lblTotalVisitor.Click += new System.EventHandler(this.lblTotalVisitor_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExcelExport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcelExport.Location = new System.Drawing.Point(1503, 810);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(180, 49);
            this.btnExcelExport.TabIndex = 10;
            this.btnExcelExport.Text = "Excel Çıktısı";
            this.btnExcelExport.UseVisualStyleBackColor = false;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(52, 810);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ana Sayfa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(253, 35);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(534, 21);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "*Bu tarihler arasında çıkış yapan ziyaretçileri gösterir.";
            // 
            // FrmExitVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1836, 940);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExcelExport);
            this.Controls.Add(this.lblTotalVisitor);
            this.Controls.Add(this.dgvExitVisitor);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dtpFilter2);
            this.Controls.Add(this.dtpFilter1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmExitVisitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Geçmiş Kayıtlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmExitVisitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExitVisitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvExitVisitor;
        private Button btnList;
        private DateTimePicker dtpFilter2;
        private DateTimePicker dtpFilter1;
        private Label lblTotalVisitor;
        private Button btnExcelExport;
        private Button button1;
        private RichTextBox richTextBox1;
    }
}