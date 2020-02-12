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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre";
            // 
            // TxtNewBookTitle
            // 
            this.TxtNewBookTitle.Location = new System.Drawing.Point(154, 88);
            this.TxtNewBookTitle.Name = "TxtNewBookTitle";
            this.TxtNewBookTitle.Size = new System.Drawing.Size(219, 26);
            this.TxtNewBookTitle.TabIndex = 3;
            // 
            // TxtNewBookAuthor
            // 
            this.TxtNewBookAuthor.Location = new System.Drawing.Point(154, 207);
            this.TxtNewBookAuthor.Name = "TxtNewBookAuthor";
            this.TxtNewBookAuthor.Size = new System.Drawing.Size(219, 26);
            this.TxtNewBookAuthor.TabIndex = 4;
            // 
            // TxtNewBookGenre
            // 
            this.TxtNewBookGenre.Location = new System.Drawing.Point(154, 327);
            this.TxtNewBookGenre.Name = "TxtNewBookGenre";
            this.TxtNewBookGenre.Size = new System.Drawing.Size(219, 26);
            this.TxtNewBookGenre.TabIndex = 5;
            // 
            // BtnAddNewBook
            // 
            this.BtnAddNewBook.Location = new System.Drawing.Point(505, 180);
            this.BtnAddNewBook.Name = "BtnAddNewBook";
            this.BtnAddNewBook.Size = new System.Drawing.Size(155, 81);
            this.BtnAddNewBook.TabIndex = 6;
            this.BtnAddNewBook.Text = "Add";
            this.BtnAddNewBook.UseVisualStyleBackColor = true;
            this.BtnAddNewBook.Click += new System.EventHandler(this.BtnAddNewBook_Click);
            // 
            // BookAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAddNewBook);
            this.Controls.Add(this.TxtNewBookGenre);
            this.Controls.Add(this.TxtNewBookAuthor);
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
    }
}