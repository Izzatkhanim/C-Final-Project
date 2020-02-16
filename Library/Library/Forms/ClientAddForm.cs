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
using Library.Forms;

namespace Library.Forms
{
    public partial class ClientAddForm : Form
    {
        public LibraryDbContext _context;

        public ClientAddForm()
        {

            _context = new LibraryDbContext();
            InitializeComponent();
            
        }

        private void BtnAddNewClient_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TxtNewClientName.Text)||
               !string.IsNullOrEmpty(TxtNewClientLastname.Text)||
               !string.IsNullOrEmpty(TxtNewClientEmail.Text)||
               !string.IsNullOrEmpty(TxtNewClientPassword.Text)||
               !string.IsNullOrEmpty(TxtNewtClientPhone.Text))
            {

                Client client = new Client
             {


                    Name = TxtNewClientName.Text,
                    Lastname = TxtNewClientLastname.Text,
                    Email = TxtNewClientEmail.Text,
                    Password = TxtNewClientPassword.Text,
                    Phone = Convert.ToString(TxtNewtClientPhone.Text),
                    Status = true
              };
                     _context.Clients.Add(client);
                     _context.SaveChanges();
                
                      this.Close();
            }
           

            
            
                    
        }
        

    }
}
