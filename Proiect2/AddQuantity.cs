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
    public partial class AddQuantity : Form
    {
        public AddQuantity()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id;
            int quantity;
            id = int.Parse(txtIdQuantity.Text);
            quantity = int.Parse(txtQuantityAdd.Text);

            using (MyDbContext mdb = new MyDbContext())
            {
                var res = mdb.Produse.SingleOrDefault(x => x.Id == id);

                if (res != null)
                {
                    res.Cantitate += quantity;
                    mdb.SaveChanges();
                    MessageBox.Show("Quantity add with succes");
                }
                else
                {
                    MessageBox.Show("This product does not exist");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

