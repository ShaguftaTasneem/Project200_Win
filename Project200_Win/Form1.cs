using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using System.Data.SqlClient;

namespace Project200_Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnPackages_Click(object sender, EventArgs e)
        {
            frmPackages pk = new frmPackages();
            pk.Show();
        }


        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts p = new frmProducts();
            p.Show();
        }

        private void btnProdSuppliers_Click(object sender, EventArgs e)
        {
            frmProduct_Suppliers ps = new frmProduct_Suppliers();
            ps.Show();

        }

        private void btnPk_Pr_Supplier_Click(object sender, EventArgs e)
        {

            frmPk_Pr_Suppliers pps = new frmPk_Pr_Suppliers();
            pps.Show();

        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            frmSuppliers s = new frmSuppliers();
            s.Show();
        }
    }
}
