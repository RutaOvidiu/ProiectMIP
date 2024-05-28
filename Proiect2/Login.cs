using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
            using(MyDbContext db = new MyDbContext())
            {
                Utilizator u = new Utilizator();
                String username = "admin";
                var res = db.Utilizatori.SingleOrDefault(x => x.username == username);
                if (res == null)
                {
                    u.nume = "admin";
                    u.prenume = "admin";
                    u.username = "admin";
                    u.password = "admin";
                    db.Utilizatori.Add(u);
                    db.SaveChanges();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                Utilizator u = new Utilizator();
                String username = txtUsernameLogin.Text;
                String password = txtPasswordLogin.Text;
                var res = db.Utilizatori.SingleOrDefault(x => x.username == username && x.password == password);
                if (res == null)
                {
                    MessageBox.Show("Username or password is wrong!");
                }
                else 
                {
                    Magazin magazin = new Magazin();
                    magazin.Owner = this;
                    magazin.Show();
                    AutentificareUtilizator.NumeUtilizator = res.username;
                    this.Hide();
                }
            }
        }

        public String getUsername() 
        { 
            return txtUsernameLogin.Text;
        } 
    }
}
