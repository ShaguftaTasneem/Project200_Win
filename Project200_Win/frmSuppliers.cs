using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;
using DataLayer;

namespace Project200_Win
{
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.travelExpertsDataSet.Suppliers);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lst = DataLayer.SuppliersDB.GetSuppliersGridDB();
            dataGridView1.DataSource = lst;
        }

        private void btnSupDetail_Click(object sender, EventArgs e)
        {
            //DateTime ShipDate = Convert.ToDateTime(txtShippedDate.Text);  //Reads and convert to datetime datatype
            //int iret = DataLayer.OrdersDB.UpdateOrder(ShipDate);          // Function Call
            var lst = DataLayer.SuppliersDB.UpdateSupplier(SupName);
            txtSupName.DataSource = lst;

            if (iret > 0)           // If function works
            {

                MessageBox.Show(" Shipped Date is Updated");
            }
            else    // If function does not work
            {
                MessageBox.Show(" Please enter Valid Shipped Date where RequiredDate > ShippedDate AND ShippedDate < OrderDate in the form of mm/dd/yyyy");

            }


        }
    }
    }

