using Essai_Grand_Ordi_1.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai_Grand_Ordi_1
{
    public partial class FormMenu : Form
    {
        IUnitOfWork _unit;
        public FormMenu(IUnitOfWork unit)
        {
            InitializeComponent();
            _unit = unit;
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordersDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormToOrder formtoOrder = new FormToOrder(_unit);
            formtoOrder.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts(_unit);
            formProducts.ShowDialog();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(_unit);
            formClients.ShowDialog();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContact formContact = new FormContact();
            formContact.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are you sure to want to exit?", "Exit",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)

            {
                Close();

            }
        }

        private void ordersDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders(_unit);
            formOrders.ShowDialog();

        }

        private void ordersToValidateToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'bAKERYDataSet.CLIENTS' table. You can move, or remove it, as needed.
            //this.cLIENTSTableAdapter.Fill(this.bAKERYDataSet.CLIENTS);

        }

        private void cLIENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bAKERYDataSet);

        }
    }
}