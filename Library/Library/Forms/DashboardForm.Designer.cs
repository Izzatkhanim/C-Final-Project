namespace Library.Forms
{
    partial class DashboardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClientOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvBookSearch = new System.Windows.Forms.DataGridView();
            this.BoookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBookSearch = new System.Windows.Forms.TextBox();
            this.TxtClientSearch = new System.Windows.Forms.TextBox();
            this.DgvCart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientSearch = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.BtnClientSearch = new System.Windows.Forms.Button();
            this.BtnBookSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnBookSearch);
            this.panel1.Controls.Add(this.BtnClientSearch);
            this.panel1.Controls.Add(this.BtnClientOrder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DgvBookSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtBookSearch);
            this.panel1.Controls.Add(this.TxtClientSearch);
            this.panel1.Controls.Add(this.DgvCart);
            this.panel1.Controls.Add(this.DgvClientSearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 1219);
            this.panel1.TabIndex = 0;
            // 
            // BtnClientOrder
            // 
            this.BtnClientOrder.Location = new System.Drawing.Point(269, 1096);
            this.BtnClientOrder.Name = "BtnClientOrder";
            this.BtnClientOrder.Size = new System.Drawing.Size(180, 88);
            this.BtnClientOrder.TabIndex = 7;
            this.BtnClientOrder.Text = "Order";
            this.BtnClientOrder.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 798);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Order";
            // 
            // DgvBookSearch
            // 
            this.DgvBookSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBookSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBookSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BoookId,
            this.BookName,
            this.Author,
            this.Genre});
            this.DgvBookSearch.Location = new System.Drawing.Point(24, 521);
            this.DgvBookSearch.Name = "DgvBookSearch";
            this.DgvBookSearch.RowHeadersWidth = 62;
            this.DgvBookSearch.RowTemplate.Height = 28;
            this.DgvBookSearch.Size = new System.Drawing.Size(665, 201);
            this.DgvBookSearch.TabIndex = 5;
            // 
            // BoookId
            // 
            this.BoookId.HeaderText = "Id";
            this.BoookId.MinimumWidth = 8;
            this.BoookId.Name = "BoookId";
            this.BoookId.Visible = false;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Title";
            this.BookName.MinimumWidth = 8;
            this.BookName.Name = "BookName";
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 8;
            this.Author.Name = "Author";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 8;
            this.Genre.Name = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client Search";
            // 
            // TxtBookSearch
            // 
            this.TxtBookSearch.Location = new System.Drawing.Point(28, 456);
            this.TxtBookSearch.Name = "TxtBookSearch";
            this.TxtBookSearch.Size = new System.Drawing.Size(322, 26);
            this.TxtBookSearch.TabIndex = 2;
            // 
            // TxtClientSearch
            // 
            this.TxtClientSearch.Location = new System.Drawing.Point(34, 65);
            this.TxtClientSearch.Name = "TxtClientSearch";
            this.TxtClientSearch.Size = new System.Drawing.Size(322, 26);
            this.TxtClientSearch.TabIndex = 2;
            // 
            // DgvCart
            // 
            this.DgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DgvCart.Location = new System.Drawing.Point(24, 839);
            this.DgvCart.Name = "DgvCart";
            this.DgvCart.RowHeadersWidth = 62;
            this.DgvCart.RowTemplate.Height = 28;
            this.DgvCart.Size = new System.Drawing.Size(665, 212);
            this.DgvCart.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Lastname";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Books";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // DgvClientSearch
            // 
            this.DgvClientSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClientSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Lastname,
            this.Books});
            this.DgvClientSearch.Location = new System.Drawing.Point(24, 126);
            this.DgvClientSearch.Name = "DgvClientSearch";
            this.DgvClientSearch.RowHeadersWidth = 62;
            this.DgvClientSearch.RowTemplate.Height = 28;
            this.DgvClientSearch.Size = new System.Drawing.Size(665, 212);
            this.DgvClientSearch.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.MinimumWidth = 8;
            this.Lastname.Name = "Lastname";
            // 
            // Books
            // 
            this.Books.HeaderText = "Books";
            this.Books.MinimumWidth = 8;
            this.Books.Name = "Books";
            // 
            // BtnOrder
            // 
            this.BtnOrder.Location = new System.Drawing.Point(12, 579);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(125, 68);
            this.BtnOrder.TabIndex = 0;
            this.BtnOrder.Text = "Order";
            this.BtnOrder.UseVisualStyleBackColor = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // BtnClientSearch
            // 
            this.BtnClientSearch.Location = new System.Drawing.Point(469, 58);
            this.BtnClientSearch.Name = "BtnClientSearch";
            this.BtnClientSearch.Size = new System.Drawing.Size(116, 40);
            this.BtnClientSearch.TabIndex = 8;
            this.BtnClientSearch.Text = "Search";
            this.BtnClientSearch.UseVisualStyleBackColor = true;
            // 
            // BtnBookSearch
            // 
            this.BtnBookSearch.Location = new System.Drawing.Point(469, 448);
            this.BtnBookSearch.Name = "BtnBookSearch";
            this.BtnBookSearch.Size = new System.Drawing.Size(116, 43);
            this.BtnBookSearch.TabIndex = 9;
            this.BtnBookSearch.Text = "Search";
            this.BtnBookSearch.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2126, 1264);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnOrder);
            this.Text = "DashboardForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnClientOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvBookSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBookSearch;
        private System.Windows.Forms.TextBox TxtClientSearch;
        private System.Windows.Forms.DataGridView DgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView DgvClientSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Books;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button BtnBookSearch;
        private System.Windows.Forms.Button BtnClientSearch;
    }
}