using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data;
using Library.Models;

namespace Library.Forms
{
    public partial class BookAddForm : Form
    {

        public readonly LibraryDbContext _context;

        public BookAddForm()
        {

            _context = new LibraryDbContext();
            InitializeComponent();
        }

        private void BtnAddNewBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNewBookAuthor.Text) ||
             !string.IsNullOrEmpty(TxtNewBookGenre.Text) ||
             !string.IsNullOrEmpty(TxtNewBookTitle.Text))
            {

                Book book = new Book
                {


                    Title = TxtNewBookTitle.Text,
                    Genre = TxtNewBookGenre.Text,
                    Author = TxtNewBookAuthor.Text,
                   
                };
                _context.Books.Add(book);
                _context.SaveChanges();

                this.Close();

            }
        }
    }
}
