namespace Library.Forms
{
    partial class ExportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpReportFrom = new System.Windows.Forms.DateTimePicker();
            this.DtpReportTo = new System.Windows.Forms.DateTimePicker();
            this.BtnExcelExport = new System.Windows.Forms.Button();
            this.DgvReportOrders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnReportSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReportOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Perpetua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Perpetua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(905, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "To";
            // 
            // DtpReportFrom
            // 
            this.DtpReportFrom.Font = new System.Drawing.Font("Schadow BT", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpReportFrom.Location = new System.Drawing.Point(390, 137);
            this.DtpReportFrom.Name = "DtpReportFrom";
            this.DtpReportFrom.Size = new System.Drawing.Size(237, 29);
            this.DtpReportFrom.TabIndex = 1;
            // 
            // DtpReportTo
            // 
            this.DtpReportTo.Font = new System.Drawing.Font("Schadow BT", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpReportTo.Location = new System.Drawing.Point(808, 137);
            this.DtpReportTo.Name = "DtpReportTo";
            this.DtpReportTo.Size = new System.Drawing.Size(233, 29);
            this.DtpReportTo.TabIndex = 1;
            // 
            // BtnExcelExport
            // 
            this.BtnExcelExport.BackColor = System.Drawing.Color.White;
            this.BtnExcelExport.Font = new System.Drawing.Font("Pages Grotesque Demo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcelExport.Location = new System.Drawing.Point(597, 617);
            this.BtnExcelExport.Name = "BtnExcelExport";
            this.BtnExcelExport.Size = new System.Drawing.Size(256, 84);
            this.BtnExcelExport.TabIndex = 2;
            this.BtnExcelExport.Text = "Export to Excel";
            this.BtnExcelExport.UseVisualStyleBackColor = false;
            this.BtnExcelExport.Click += new System.EventHandler(this.BtnExcelExport_Click);
            // 
            // DgvReportOrders
            // 
            this.DgvReportOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReportOrders.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DgvReportOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReportOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column11,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.DgvReportOrders.Location = new System.Drawing.Point(12, 190);
            this.DgvReportOrders.Name = "DgvReportOrders";
            this.DgvReportOrders.RowHeadersWidth = 62;
            this.DgvReportOrders.RowTemplate.Height = 28;
            this.DgvReportOrders.Size = new System.Drawing.Size(1450, 360);
            this.DgvReportOrders.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Lastname";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phone";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Book";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Count";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Take Date";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Return Date";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Deadline";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Return Price";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            // 
            // BtnReportSearch
            // 
            this.BtnReportSearch.BackColor = System.Drawing.Color.White;
            this.BtnReportSearch.Font = new System.Drawing.Font("Pages Grotesque Demo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportSearch.Location = new System.Drawing.Point(1130, 90);
            this.BtnReportSearch.Name = "BtnReportSearch";
            this.BtnReportSearch.Size = new System.Drawing.Size(151, 56);
            this.BtnReportSearch.TabIndex = 2;
            this.BtnReportSearch.Text = "Search";
            this.BtnReportSearch.UseVisualStyleBackColor = false;
            this.BtnReportSearch.Click += new System.EventHandler(this.BtnReportSearch_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Library.Properties.Resources.ExportForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1474, 770);
            this.Controls.Add(this.DgvReportOrders);
            this.Controls.Add(this.BtnReportSearch);
            this.Controls.Add(this.BtnExcelExport);
            this.Controls.Add(this.DtpReportTo);
            this.Controls.Add(this.DtpReportFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvReportOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpReportFrom;
        private System.Windows.Forms.DateTimePicker DtpReportTo;
        private System.Windows.Forms.Button BtnExcelExport;
        private System.Windows.Forms.DataGridView DgvReportOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button BtnReportSearch;
    }
}