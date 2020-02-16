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
        ////kitab elave etmek
        private void BtnAddNewBook_Click(object sender, EventArgs e)
        {

            //textboxlarin bosh olmamagini yoxlamaq uchun if 
            if (!string.IsNullOrEmpty(TxtNewBookAuthor.Text)||
                !string.IsNullOrEmpty(TxtNewBookGenre.Text) ||
                !string.IsNullOrEmpty(TxtNewBookTitle.Text) ||
                !string.IsNullOrEmpty(TxtNewBookCount.Text) ||
                !string.IsNullOrEmpty(TxtNewBookPrice.Text))


            {
                //yaradilan kitabi database elave etmek uchun
                Book book = new Book
                {


                    Title = TxtNewBookTitle.Text,
                    Genre = TxtNewBookGenre.Text,
                    Author = TxtNewBookAuthor.Text,
                    Count = Convert.ToInt32(TxtNewBookCount.Text),
                    Price = Convert.ToDecimal(TxtNewBookPrice.Text)
                    
                   
                };
                _context.Books.Add(book);
                _context.SaveChanges();

                this.Close();

            }
        }
    }
}
