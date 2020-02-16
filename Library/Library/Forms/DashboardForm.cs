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
    public partial class Dashboard : Form
    {
        private readonly LibraryDbContext _context;
        private Client _selectedClient;
        private Book _selectedBook;
        private Order _selectedOrder;


        public Dashboard()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            FillClientData();
            FillBookData();
            FillOrderData();
            FillTodaysReturns();
            FillTomorrowsReturns();
            FillLateReturns();
        }

        //Gecikenler tabinin dgv-sini doldurmaq uchun fill
        private void FillLateReturns()
        {
            var LateReturn = _context.Orders.
                       Include("Book").
                       Include("Client").
                       Where(d => d.Deadline < DateTime.Now).
                       ToList();
            foreach (var item in LateReturn)
            {
                DgvLateReturns.Rows.Add(item.Id,
                                           item.Client.Name,
                                           item.Client.Lastname,
                                           item.Client.Phone,
                                           item.Count);
            }
        }

        private void FillTomorrowsReturns()
        {
            DateTime tomorrow = DateTime.Today.AddDays(1);
            var ReturnTomorrow = _context.Orders.
                           Include("Book").
                           Include("Client").
                           Where(d =>  d.Deadline.Year == tomorrow.Year &&
                                       d.Deadline.Month == tomorrow.Month &&
                                       d.Deadline.Day == tomorrow.Day).
                           ToList();
            foreach (var item in ReturnTomorrow)
            {
                DgvTomorrowReturn.Rows.Add(item.Id,
                                           item.Client.Name,
                                           item.Client.Lastname,
                                           item.Client.Phone,
                                           item.Count);
            }
        }

        private void FillTodaysReturns()
        {
            DateTime now = DateTime.Now;
            var ReturnToday = _context.Orders.
                                  Include("Book").
                                  Include("Client").
                                  Where(d => d.Deadline.Year == now.Year &&
                                       d.Deadline.Month == now.Month &&
                                       d.Deadline.Day == now.Day).
                                  ToList();
            foreach (var item in ReturnToday)
            {
                DgvTodayReturns.Rows.Add(item.Id,
                                         item.Client.Name,
                                         item.Client.Lastname,
                                         item.Client.Phone,
                                         item.Count);
            }
        }

        private void FillOrderData()
        {
            var ShowOrders = _context.Orders.ToList();
            //var notDoneOrder = _context.Orders.FirstOrDefault(d => d.IsDone == false);
            
            //if (notDoneOrder.IsDone != true)
            //{
             foreach (var item in ShowOrders)
            {
                DgvCart.Rows.Add(item.Id,
                                 item.Client.Name,
                                 item.Client.Lastname,
                                 item.Client.Email,
                                 item.Book.Title,
                                 item.Date,
                                 item.Deadline,
                                 item.Book.Price,
                                 item.Count);
            }
            //}
           
        }

        private void FillClientData()
        {
            var ShowClients = _context.Clients.ToList();

            foreach (var item in ShowClients)
            {
                DgvClientSearch.Rows.Add(item.Id,
                                         item.Name,
                                         item.Lastname,
                                         item.Email,
                                         item.Phone);
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
                                         item.Genre,
                                         item.Price,
                                         item.Count);
            }

            foreach (var item in ShowBooks)
            {
                DgvOrderBook.Rows.Add(item.Id,
                                         item.Title,
                                         item.Author,
                                         item.Genre,
                                         item.Price,
                                         item.Count);
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
            _context.Clients.Remove(_selectedClient);
            _context.SaveChanges();
            DgvClientSearch.Rows.Clear();
            FillClientData();

         }

        private void BtnBookDelete_Click(object sender, EventArgs e)
        {
            _context.Books.Remove(_selectedBook);
            _context.SaveChanges();
            DgvBookSearch.Rows.Clear();
            FillBookData();
        }

        private void BtnClientOrder_Click(object sender, EventArgs e)
        {


            try
            {
               DgvCart.Rows.Add(_selectedClient.Id,
                             _selectedClient.Name,
                             _selectedClient.Lastname,
                             _selectedClient.Email,
                             _selectedBook.Title,
                              DateTime.Now.ToString("MM.dd.yyyy"),
                              DtpDeadline.Value,
                              _selectedBook.Price,
                              _selectedBook.Count);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please choose and fill out everything.");
            }
            return;
                               
            Order order = new Order
            {
                ClientId = _selectedClient.Id,
                Date = DateTime.Now,
                Deadline = DtpDeadline.Value,
                BookId = _selectedBook.Id,
                IsDone = false,
                Count = Convert.ToInt32(TxtNewOrderBookCount.Text)

                
            };
            _context.Orders.Add(order);
            _selectedBook.Count -= Convert.ToInt32(TxtNewOrderBookCount.Text);
            _context.SaveChanges();
            DgvBookSearch.Rows.Clear();
            DgvOrderBook.Rows.Clear();
            DgvCart.Rows.Clear();
            DgvTodayReturns.Rows.Clear();
            DgvTomorrowReturn.Rows.Clear();
            DgvLateReturns.Rows.Clear();
            TxtNewOrderBookCount.Clear();
            FillOrderData();
            FillBookData();
            FillTodaysReturns();
            FillTomorrowsReturns();
            FillLateReturns();
        }
        int rowIndex;                        
        private void DgvOrderClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int id = Convert.ToInt32(DgvOrderClient.Rows[e.RowIndex].Cells[0].Value.ToString());
            _selectedClient = _context.Clients.Find(id);
            
        }

        private void DgvOrderBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(DgvOrderBook.Rows[e.RowIndex].Cells[0].Value.ToString());
            _selectedBook = _context.Books.Find(id);
        }

        private void DgvClientSearch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            int id = Convert.ToInt32(DgvClientSearch.Rows[e.RowIndex].Cells[0].Value.ToString());
            _selectedClient = _context.Clients.Find(id);
        }

        private void DgvBookSearch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvBookSearch.Rows[e.RowIndex].Cells[0].Value.ToString());
            _selectedBook = _context.Books.Find(id);
        }
        int id;
        private void DgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            id = Convert.ToInt32(DgvCart.Rows[e.RowIndex].Cells[0].Value.ToString());
            _selectedOrder = _context.Orders.Find(id);
        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {   

            double prc = Convert.ToInt32(_selectedOrder.Book.Price);

            if (DgvCart.SelectedRows != null)
            {
                if (_selectedOrder.Deadline > DateTime.Now)
                {
                       MessageBox.Show("Your bill is" + " " + _selectedOrder.Book.Price);
                }
                else if(_selectedOrder.Deadline < DateTime.Now)
                {
                MessageBox.Show("Your bill is" + " " + ((prc*0.005)+prc));
                }
                else
                {
                    MessageBox.Show("Please choose an order.");
                }





                Order doneOrder = _context.Orders.FirstOrDefault(d => d.Id == id);
                var countBook = _context.Books.Where(b => b.Id == _selectedOrder.Book.Id).First().Count;
                var resultCount= countBook+_selectedOrder.Count;
                _context.Books.Where(b => b.Id == _selectedOrder.Book.Id).First().Count = resultCount;
                DgvCart.Rows.RemoveAt(rowIndex);
                doneOrder.IsDone = true;
                _context.SaveChanges();
                DgvBookSearch.Rows.Clear();
                DgvOrderBook.Rows.Clear();
                DgvCart.Rows.Clear();
                DgvTodayReturns.Rows.Clear();
                DgvTomorrowReturn.Rows.Clear();
                DgvLateReturns.Rows.Clear();
                FillOrderData();
                FillBookData();
                FillTodaysReturns();
                FillTomorrowsReturns();
                FillLateReturns();
            }          
        }

        private void BtnOrderSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtOrderSearch.Text))
            {
                MessageBox.Show("Please enter the client's name.");
                return;
            }

            var order = _context.Orders.Where(o =>
                                             (TxtOrderSearch.Text != string.Empty ?
                                               o.Client.Name.Contains(TxtOrderSearch.Text) : false))
                                               .ToList();

            DgvCart.Rows.Clear();

            foreach (var item in order)
            {
                DgvCart.Rows.Add(item.Id,
                                 item.Client.Name,
                                 item.Client.Lastname,
                                 item.Client.Email,
                                 item.Book.Title,
                                 item.Date,
                                 item.Deadline,
                                 item.Book.Price);
            }
        }

        private void BtnNewOrderClientSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNewOrderClientSearch.Text))
            {
                MessageBox.Show("Please enter the client's name.");
                return;
            }

            var client = _context.Clients.Where(c => c.Status &&
                                               (TxtNewOrderClientSearch.Text != string.Empty ?
                                               c.Name.Contains(TxtNewOrderClientSearch.Text) : false))
                                               .ToList();

            DgvOrderClient.Rows.Clear();

            foreach (var item in client)
            {
                DgvOrderClient.Rows.Add(item.Id,
                                         item.Name,
                                         item.Lastname,
                                         item.Email,
                                         item.Phone);
            }
        }

    }
}

