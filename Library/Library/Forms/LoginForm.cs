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

    public partial class LoginForm : Form
    {

        private readonly LibraryDbContext _context;

        public LoginForm()
        {

            _context = new LibraryDbContext();

            InitializeComponent();
        }

        //Login button-un clickinde
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //TxtEmail ve password textboxunun bosh olmamagini yoxlamaq uchun
            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("Please enter your Email.");
                return;
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Please enter you password.");
                return;
            }

            //idarechi daxil olur
            Manager manager = _context.Managers.FirstOrDefault(m => m.Status && m.Email == TxtEmail.Text && m.Password == TxtPassword.Text);

            if (manager != null)
            {

                //Dashboard formunun achilmagi
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();

                return;
            }

            MessageBox.Show("Email or passwod is incorrect.");

        }
    }
}
