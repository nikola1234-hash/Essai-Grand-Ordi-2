using Essai_Grand_Ordi_1.DataAccess;
using Essai_Grand_Ordi_1.DTO;
using Essai_Grand_Ordi_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Essai_Grand_Ordi_1
{
    public partial class FormOrders : Form
    {
        private IUnitOfWork _unit;
        private OrderService os;
        private List<OrderDTO> orders;
        public FormOrders(IUnitOfWork unit)
        {
            InitializeComponent();
            _unit = unit;
            os = new OrderService();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private void FormOrders_Load(object sender, EventArgs e)
        {
            orders = os.GetOrders().ToList();
            dataGridView1.DataSource = orders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a valid search term");
                return;
            }

            var filteredOrders = orders.Where(o => o.FIRST_NAME.Contains(textBox1.Text) || o.LAST_NAME.Contains(textBox1.Text) || o.PHONE_NUMBER.Contains(textBox1.Text)).ToList();

            if (filteredOrders.Count == 0)
            {
                MessageBox.Show("No results found");
                return;
            }

            dataGridView1.DataSource = filteredOrders;
            dataGridView1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
