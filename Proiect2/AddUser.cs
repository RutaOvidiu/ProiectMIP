using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                Utilizator u = new Utilizator();
                String username = txtUsernameAddUser.Text;
                var res = db.Utilizatori.SingleOrDefault(x => x.username == username);
                if (res == null)
                {
                    u.nume = txtNumeAddUser.Text;
                    u.prenume = txtPrenumeAddUser.Text;
                    u.username = txtUsernameAddUser.Text;
                    u.password = txtPasswordAddUser.Text;
                    db.Utilizatori.Add(u);
                    db.SaveChanges();
                    MessageBox.Show("User add with succes");
                }
                else
                {
                    MessageBox.Show("This userneame is already taken");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
