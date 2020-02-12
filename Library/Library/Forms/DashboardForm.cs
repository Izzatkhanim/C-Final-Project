using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.Data;
using System.Data.SqlClient;

namespace Library.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly LibraryDbContext _context; 
        public DashboardForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            FillClientData();
            FillBookData();
            FillOrderData();
        }

        private void FillOrderData()
        {
            var ShowOrders = _context.Orders.ToList();

            foreach (var item in ShowOrders)
            {
                DgvCart.Rows.Add(item.Id,
                                 item.Client.Name,
                                 item.Client.Lastname,
                                 item.Book.Title,
                                 item.Deadline);
            }
        }

        private void FillClientData()
        {
            var ShowClients = _context.Clients.ToList();

            foreach (var item in ShowClients)
            {
                DgvClientSearch.Rows.Add(item.Id,
                                         item.Name,
                                         item.Lastname,
                                         item.Book);
            }

            foreach (var item in ShowClients)
            {
                DgvOrderClient.Rows.Add(item.Id,
                                         item.Name,
                                         item.Lastname,
                                         item.Email);
            }
        }

        private void FillBookData()
        {
            var ShowBooks = _context.Books.ToList();

            foreach (var item in ShowBooks)
            {
                DgvBookSearch.Rows.Add(item.Id,
                                         item.Title,
                                         item.Author,
                                         item.Genre);
            }

            foreach (var item in ShowBooks)
            {
                DgvOrderBook.Rows.Add(item.Id,
                                         item.Title,
                                         item.Author,
                                         item.Genre);
            }
        }

        private void BtnClientSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtClientSearch.Text))
            {
                MessageBox.Show("Please enter the client's name.");
                return;
            }

            var client = _context.Clients.Where(c => c.Status && 
                                               (TxtClientSearch.Text != string.Empty ? 
                                               c.Name.Contains(TxtClientSearch.Text) : false))
                                               .ToList();

            DgvClientSearch.Rows.Clear();

            foreach (var item in client)
            {
                DgvClientSearch.Rows.Add(item.Id,
                                         item.Name,
                                         item.Lastname,
                                         item.Book);
            }

         
        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            ClientAddForm clientAddForm = new ClientAddForm();
            clientAddForm.Show();
            return;
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            BookAddForm bookAddForm = new BookAddForm();
            bookAddForm.Show();

            return;
        }

        private void BtnBookSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBookSearch.Text))
            {
                MessageBox.Show("Please enter the book's title.");
                return;
            }

            var book = _context.Books.Where(b =>(TxtBookSearch.Text != string.Empty ?
                                               b.Title.Contains(TxtBookSearch.Text) : false))
                                               .ToList();
                                               

            DgvBookSearch.Rows.Clear();

            foreach (var item in book)
            {
                DgvBookSearch.Rows.Add(item.Id,
                                         item.Title,
                                         item.Author,
                                         item.Genre);
            }
        }

        private void BtnClientDelete_Click(object sender, EventArgs e)
        {
            DgvClientSearch.Rows.RemoveAt(DgvClientSearch.SelectedRows[0].Index);
            _context.SaveChanges();
        }

        private void BtnBookDelete_Click(object sender, EventArgs e)
        {
            DgvClientSearch.Rows.RemoveAt(DgvClientSearch.SelectedRows[0].Index);
            _context.SaveChanges();
        }

        private void BtnClientOrder_Click(object sender, EventArgs e)
        {
      
        }

        }
}

