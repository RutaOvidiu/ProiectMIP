using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class Magazin : Form
    {
        public Magazin()
        {
            InitializeComponent();
        }

        private void adaugareProdusNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await AddProductAsync());
        }

        private async Task AddProductAsync()
        {
            await Task.Run(() =>
            {
                AddProduct addProduct = new AddProduct();
                addProduct.ShowDialog();
            });
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await SearchRefresh());
        }
        private async Task SearchRefresh()
        {
            await Task.Run(() =>
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var res = from s in db.Produse
                              select new
                              {
                                  s.Id,
                                  s.Denumire,
                                  s.Cantitate
                              };
                    this.Invoke((MethodInvoker)delegate
                    {
                        dataGridView1.DataSource = res.ToList();
                    });
                }
            });
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await SearchAsync());
        }
        private async Task SearchAsync()
        {
            String src = txtSerach.Text;

            await Task.Run(() =>
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var res = from s in db.Produse
                              where s.Denumire.Contains(src)
                              select new
                              {
                                  s.Id,
                                  s.Denumire,
                                  s.Cantitate
                              };
                    this.Invoke((MethodInvoker)delegate
                    {
                        dataGridView1.DataSource = res.ToList();
                    });
                }
            });
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Task.Run(async () => await UpdateProductAsync(e.RowIndex));
        }

        private async Task UpdateProductAsync(int rowIndex)
        {
            int id;

            id = int.Parse(dataGridView1.Rows[rowIndex].Cells["Id"].Value.ToString());

            await Task.Run(() =>
            {
                using (MyDbContext mdb = new MyDbContext())
                {
                    var res = mdb.Produse.SingleOrDefault(x => x.Id == id);

                    if (res != null)
                    {
                        res.Cantitate--;
                        if (res.Cantitate <= 0)
                        {
                            mdb.Produse.Remove(res);
                        }
                        mdb.SaveChanges();
                    }
                }
            });
        }

        private void adaugareUtilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await AddUserAsync());
        }

        private async Task AddUserAsync()
        {
            await Task.Run(() =>
            {
                AddUser addUser = new AddUser();
                addUser.ShowDialog();
            });
        }

        private void stergereUtilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await DeleteUserAsync());
        }

        private async Task DeleteUserAsync()
        {
            await Task.Run(() =>
            {
                DeleteUser deleteUser = new DeleteUser();
                deleteUser.ShowDialog();
            });
        }

        private void adaugareCantitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await AddQuantityAsync());
        }

        private async Task AddQuantityAsync()
        {
            await Task.Run(() =>
            {
                AddQuantity addQuantity = new AddQuantity();
                addQuantity.ShowDialog();
            });
        }



        private void istoricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await ShowSellHistoryAsync());
        }

        private async Task ShowSellHistoryAsync()
        {
            await Task.Run(() =>
            {
                SellHistory istoricVanzari = new SellHistory();
                istoricVanzari.ShowDialog();
            });
        }

        private void cumparareProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await BuyProductsAsync());
        }

        private async Task BuyProductsAsync()
        {
            await Task.Run(() =>
            {
                CumparareProduse cumparareProduse = new CumparareProduse();
                cumparareProduse.ShowDialog();
            });
        }

        private void Magazin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

