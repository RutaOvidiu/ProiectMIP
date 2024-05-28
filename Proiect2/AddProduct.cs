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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                Produs p = new Produs();
                p.Denumire = txtDenumire.Text;
                p.DescriereProdus = txtDescriere.Text;
                p.DataIntrare = dtpDataIntrare.Value;
                p.DataValabilitate = dtpDataValabilitate.Value;
                p.Cantitate = int.Parse(txtCantitate.Text);
                db.Produse.Add(p);
                db.SaveChanges();
                MessageBox.Show("Product add with succes");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
