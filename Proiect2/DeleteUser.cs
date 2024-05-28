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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;

            id = int.Parse(txtIdDeleteUser.Text);

            using (MyDbContext mdb = new MyDbContext())
            {
                var res = mdb.Utilizatori.SingleOrDefault(x => x.id == id);

                if (res != null)
                {
                    mdb.Utilizatori.Remove(res);
                    mdb.SaveChanges();
                    MessageBox.Show("User deleted successfully");
                }
                else
                {
                    MessageBox.Show("The user with this id does not exist");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
