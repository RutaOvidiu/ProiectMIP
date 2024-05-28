using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Proiect2
{
    public partial class CumparareProduse : Form
    {
        public CumparareProduse()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            String usr = AutentificareUtilizator.NumeUtilizator;
            using (MyDbContext db = new MyDbContext())
            {
                IstoricVanzari istoric = new IstoricVanzari();
                var res = db.Utilizatori.SingleOrDefault(x => x.username == usr);
                istoric.id_user= res.id;
                int id = int.Parse(txtIdBuy.Text);
                var res2 = db.Produse.SingleOrDefault(x => x.Id == id);
                if (res2 != null)
                {
                    istoric.denumireProdus = res2.Denumire;
                    istoric.canitate = res2.Cantitate;
                    int cantitate = int.Parse(txtQuantityBuy.Text);
                    res2.Cantitate -= cantitate;
                    if (res2.Cantitate < 0)
                    {
                        MessageBox.Show("Stock is out");
                    }else if (res2.Cantitate == 0)
                    {
                        db.Produse.Remove(res2);
                        MessageBox.Show("Buy succes");
                        db.Istoric.Add(istoric);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Istoric.Add(istoric);
                        MessageBox.Show("Buy succes");
                        db.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("The product with this id is missing");
                }
            }
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
