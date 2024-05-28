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
    public partial class SellHistory : Form
    {
        public SellHistory()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int scr = int.Parse(txtSearch.Text);
            using (MyDbContext db = new MyDbContext())
            {
                var res = from s in db.Istoric
                          where s.id_user == scr
                          select new
                          {
                              s.id,
                              s.id_user,
                              s.denumireProdus,
                              s.canitate
                          };
                dataGridView1.DataSource = res.ToList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var res = from s in db.Istoric
                          select new
                          {
                              s.id,
                              s.id_user,
                              s.denumireProdus,
                              s.canitate
                          };
                dataGridView1.DataSource = res.ToList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
