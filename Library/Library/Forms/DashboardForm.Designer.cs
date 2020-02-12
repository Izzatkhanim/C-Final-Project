namespace Library.Forms
{
    partial class Dashboard
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
            this.BtnBookDelete = new System.Windows.Forms.Button();
            this.BtnClientDelete = new System.Windows.Forms.Button();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.BtnAddClient = new System.Windows.Forms.Button();
            this.BtnBookSearch = new System.Windows.Forms.Button();
            this.BtnClientSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvBookSearch = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBookSearch = new System.Windows.Forms.TextBox();
            this.TxtClientSearch = new System.Windows.Forms.TextBox();
            this.DgvCart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientOrderEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientSearch = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnClientOrder = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvOrderClient = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvOrderBook = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnBookDelete);
            this.panel1.Controls.Add(this.BtnClientDelete);
            this.panel1.Controls.Add(this.BtnAddBook);
            this.panel1.Controls.Add(this.BtnAddClient);
            this.panel1.Controls.Add(this.BtnBookSearch);
            this.panel1.Controls.Add(this.BtnClientSearch);
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
            // BtnBookDelete
            // 
            this.BtnBookDelete.Location = new System.Drawing.Point(559, 448);
            this.BtnBookDelete.Name = "BtnBookDelete";
            this.BtnBookDelete.Size = new System.Drawing.Size(125, 43);
            this.BtnBookDelete.TabIndex = 11;
            this.BtnBookDelete.Text = "Delete Book";
            this.BtnBookDelete.UseVisualStyleBackColor = true;
            this.BtnBookDelete.Click += new System.EventHandler(this.BtnBookDelete_Click);
            // 
            // BtnClientDelete
            // 
            this.BtnClientDelete.Location = new System.Drawing.Point(559, 58);
            this.BtnClientDelete.Name = "BtnClientDelete";
            this.BtnClientDelete.Size = new System.Drawing.Size(125, 40);
            this.BtnClientDelete.TabIndex = 11;
            this.BtnClientDelete.Text = "Delete Client";
            this.BtnClientDelete.UseVisualStyleBackColor = true;
            this.BtnClientDelete.Click += new System.EventHandler(this.BtnClientDelete_Click);
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.Location = new System.Drawing.Point(428, 448);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(114, 43);
            this.BtnAddBook.TabIndex = 10;
            this.BtnAddBook.Text = "Add Book";
            this.BtnAddBook.UseVisualStyleBackColor = true;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // BtnAddClient
            // 
            this.BtnAddClient.Location = new System.Drawing.Point(428, 58);
            this.BtnAddClient.Name = "BtnAddClient";
            this.BtnAddClient.Size = new System.Drawing.Size(114, 40);
            this.BtnAddClient.TabIndex = 10;
            this.BtnAddClient.Text = "Add Client";
            this.BtnAddClient.UseVisualStyleBackColor = true;
            this.BtnAddClient.Click += new System.EventHandler(this.BtnAddClient_Click);
            // 
            // BtnBookSearch
            // 
            this.BtnBookSearch.Location = new System.Drawing.Point(297, 448);
            this.BtnBookSearch.Name = "BtnBookSearch";
            this.BtnBookSearch.Size = new System.Drawing.Size(116, 43);
            this.BtnBookSearch.TabIndex = 9;
            this.BtnBookSearch.Text = "Search";
            this.BtnBookSearch.UseVisualStyleBackColor = true;
            this.BtnBookSearch.Click += new System.EventHandler(this.BtnBookSearch_Click);
            // 
            // BtnClientSearch
            // 
            this.BtnClientSearch.Location = new System.Drawing.Point(297, 58);
            this.BtnClientSearch.Name = "BtnClientSearch";
            this.BtnClientSearch.Size = new System.Drawing.Size(116, 40);
            this.BtnClientSearch.TabIndex = 8;
            this.BtnClientSearch.Text = "Search";
            this.BtnClientSearch.UseVisualStyleBackColor = true;
            this.BtnClientSearch.Click += new System.EventHandler(this.BtnClientSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 857);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Orders";
            // 
            // DgvBookSearch
            // 
            this.DgvBookSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBookSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBookSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.BookName,
            this.AuthorName,
            this.GenreName});
            this.DgvBookSearch.Location = new System.Drawing.Point(19, 516);
            this.DgvBookSearch.Name = "DgvBookSearch";
            this.DgvBookSearch.RowHeadersWidth = 62;
            this.DgvBookSearch.RowTemplate.Height = 28;
            this.DgvBookSearch.Size = new System.Drawing.Size(665, 201);
            this.DgvBookSearch.TabIndex = 5;
            this.DgvBookSearch.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBookSearch_RowHeaderMouseClick);
            // 
            // BookId
            // 
            this.BookId.HeaderText = "Id";
            this.BookId.MinimumWidth = 8;
            this.BookId.Name = "BookId";
            this.BookId.Visible = false;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Title";
            this.BookName.MinimumWidth = 8;
            this.BookName.Name = "BookName";
            // 
            // AuthorName
            // 
            this.AuthorName.HeaderText = "Author";
            this.AuthorName.MinimumWidth = 8;
            this.AuthorName.Name = "AuthorName";
            // 
            // GenreName
            // 
            this.GenreName.HeaderText = "Genre";
            this.GenreName.MinimumWidth = 8;
            this.GenreName.Name = "GenreName";
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
            this.TxtBookSearch.Size = new System.Drawing.Size(250, 26);
            this.TxtBookSearch.TabIndex = 2;
            // 
            // TxtClientSearch
            // 
            this.TxtClientSearch.Location = new System.Drawing.Point(34, 65);
            this.TxtClientSearch.Name = "TxtClientSearch";
            this.TxtClientSearch.Size = new System.Drawing.Size(244, 26);
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
            this.ClientOrderEmail,
            this.dataGridViewTextBoxColumn4,
            this.ReturnDate});
            this.DgvCart.Location = new System.Drawing.Point(28, 882);
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
            // ClientOrderEmail
            // 
            this.ClientOrderEmail.HeaderText = "Email";
            this.ClientOrderEmail.MinimumWidth = 8;
            this.ClientOrderEmail.Name = "ClientOrderEmail";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Books";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.MinimumWidth = 8;
            this.ReturnDate.Name = "ReturnDate";
            // 
            // DgvClientSearch
            // 
            this.DgvClientSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClientSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4});
            this.DgvClientSearch.Location = new System.Drawing.Point(24, 126);
            this.DgvClientSearch.Name = "DgvClientSearch";
            this.DgvClientSearch.RowHeadersWidth = 62;
            this.DgvClientSearch.RowTemplate.Height = 28;
            this.DgvClientSearch.Size = new System.Drawing.Size(665, 212);
            this.DgvClientSearch.TabIndex = 1;
            this.DgvClientSearch.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvClientSearch_RowHeaderMouseClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Lastname";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Books";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // BtnClientOrder
            // 
            this.BtnClientOrder.Location = new System.Drawing.Point(1803, 467);
            this.BtnClientOrder.Name = "BtnClientOrder";
            this.BtnClientOrder.Size = new System.Drawing.Size(131, 48);
            this.BtnClientOrder.TabIndex = 7;
            this.BtnClientOrder.Text = "New Order";
            this.BtnClientOrder.UseVisualStyleBackColor = true;
            this.BtnClientOrder.Click += new System.EventHandler(this.BtnClientOrder_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Schadow BT", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1444, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 54);
            this.label4.TabIndex = 8;
            this.label4.Text = "New Order";
            // 
            // DgvOrderClient
            // 
            this.DgvOrderClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrderClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrderClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.ClientEmail});
            this.DgvOrderClient.Location = new System.Drawing.Point(871, 195);
            this.DgvOrderClient.Name = "DgvOrderClient";
            this.DgvOrderClient.RowHeadersWidth = 62;
            this.DgvOrderClient.RowTemplate.Height = 28;
            this.DgvOrderClient.Size = new System.Drawing.Size(656, 201);
            this.DgvOrderClient.TabIndex = 1;
            this.DgvOrderClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrderClient_CellClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Lastname";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // ClientEmail
            // 
            this.ClientEmail.HeaderText = "Email";
            this.ClientEmail.MinimumWidth = 8;
            this.ClientEmail.Name = "ClientEmail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(878, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1629, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Book";
            // 
            // DgvOrderBook
            // 
            this.DgvOrderBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrderBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrderBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.DgvOrderBook.Location = new System.Drawing.Point(1634, 195);
            this.DgvOrderBook.Name = "DgvOrderBook";
            this.DgvOrderBook.RowHeadersWidth = 62;
            this.DgvOrderBook.RowTemplate.Height = 28;
            this.DgvOrderBook.Size = new System.Drawing.Size(664, 201);
            this.DgvOrderBook.TabIndex = 5;
            this.DgvOrderBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrderBook_CellClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Id";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Title";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Author";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // DtpDeadline
            // 
            this.DtpDeadline.Location = new System.Drawing.Point(1444, 487);
            this.DtpDeadline.Name = "DtpDeadline";
            this.DtpDeadline.Size = new System.Drawing.Size(290, 26);
            this.DtpDeadline.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1541, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Deadline";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(2249, 1264);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtpDeadline);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.BtnClientOrder);
            this.Controls.Add(this.DgvOrderClient);
            this.Controls.Add(this.DgvOrderBook);
            this.Text = "Library Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnClientOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvBookSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBookSearch;
        private System.Windows.Forms.TextBox TxtClientSearch;
        private System.Windows.Forms.DataGridView DgvCart;
        private System.Windows.Forms.DataGridView DgvClientSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button BtnBookSearch;
        private System.Windows.Forms.Button BtnClientSearch;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.Button BtnAddClient;
        private System.Windows.Forms.Button BtnBookDelete;
        private System.Windows.Forms.Button BtnClientDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvOrderClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvOrderBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DateTimePicker DtpDeadline;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientOrderEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}