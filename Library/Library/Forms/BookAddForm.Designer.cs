namespace Library.Forms
{
    partial class BookAddForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNewBookTitle = new System.Windows.Forms.TextBox();
            this.TxtNewBookAuthor = new System.Windows.Forms.TextBox();
            this.TxtNewBookGenre = new System.Windows.Forms.TextBox();
            this.BtnAddNewBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNewBookCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNewBookPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("News701 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("News701 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("News701 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre";
            // 
            // TxtNewBookTitle
            // 
            this.TxtNewBookTitle.Location = new System.Drawing.Point(105, 72);
            this.TxtNewBookTitle.Name = "TxtNewBookTitle";
            this.TxtNewBookTitle.Size = new System.Drawing.Size(219, 26);
            this.TxtNewBookTitle.TabIndex = 3;
            // 
            // TxtNewBookAuthor
            // 
            this.TxtNewBookAuthor.Location = new System.Drawing.Point(457, 72);
            this.TxtNewBookAuthor.Name = "TxtNewBookAuthor";
            this.TxtNewBookAuthor.Size = new System.Drawing.Size(219, 26);
            this.TxtNewBookAuthor.TabIndex = 4;
            // 
            // TxtNewBookGenre
            // 
            this.TxtNewBookGenre.Location = new System.Drawing.Point(105, 168);
            this.TxtNewBookGenre.Name = "TxtNewBookGenre";
            this.TxtNewBookGenre.Size = new System.Drawing.Size(219, 26);
            this.TxtNewBookGenre.TabIndex = 5;
            // 
            // BtnAddNewBook
            // 
            this.BtnAddNewBook.BackColor = System.Drawing.Color.NavajoWhite;
            this.BtnAddNewBook.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewBook.Location = new System.Drawing.Point(313, 357);
            this.BtnAddNewBook.Name = "BtnAddNewBook";
            this.BtnAddNewBook.Size = new System.Drawing.Size(155, 81);
            this.BtnAddNewBook.TabIndex = 6;
            this.BtnAddNewBook.Text = "Add";
            this.BtnAddNewBook.UseVisualStyleBackColor = false;
            this.BtnAddNewBook.Click += new System.EventHandler(this.BtnAddNewBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("News701 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Count";
            // 
            // TxtNewBookCount
            // 
            this.TxtNewBookCount.Location = new System.Drawing.Point(457, 168);
            this.TxtNewBookCount.Name = "TxtNewBookCount";
            this.TxtNewBookCount.Size = new System.Drawing.Size(219, 26);
            this.TxtNewBookCount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("News701 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price";
            // 
            // TxtNewBookPrice
            // 
            this.TxtNewBookPrice.Location = new System.Drawing.Point(277, 270);
            this.TxtNewBookPrice.Name = "TxtNewBookPrice";
            this.TxtNewBookPrice.Size = new System.Drawing.Size(219, 26);
            this.TxtNewBookPrice.TabIndex = 5;
            // 
            // BookAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.AddBookForm;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAddNewBook);
            this.Controls.Add(this.TxtNewBookPrice);
            this.Controls.Add(this.TxtNewBookCount);
            this.Controls.Add(this.TxtNewBookGenre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNewBookAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNewBookTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookAddForm";
            this.Text = "BookAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNewBookTitle;
        private System.Windows.Forms.TextBox TxtNewBookAuthor;
        private System.Windows.Forms.TextBox TxtNewBookGenre;
        private System.Windows.Forms.Button BtnAddNewBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNewBookCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNewBookPrice;
    }
}