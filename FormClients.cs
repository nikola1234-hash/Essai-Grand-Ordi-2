using Essai_Grand_Ordi_1.DataAccess;
using Essai_Grand_Ordi_1.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Essai_Grand_Ordi_1
{
    public partial class FormClients : Form
    {
        private IUnitOfWork _unit;
        private int clientId = default;
        private bool isOrder = false;
        public event EventHandler<int> ClientSelected;
        public FormClients(IUnitOfWork unit, bool isOrder = false)
        {
            InitializeComponent();
            _unit = unit;
            InitializeDataGrid();
            this.isOrder = isOrder;
            this.button4.Enabled = isOrder;
            this.button4.Visible = isOrder;
        }

        private void cLIENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }
        private void OnClientSelected(int clientId)
        {
            ClientSelected?.Invoke(this, clientId);
        }
        private void InitializeDataGrid()
        {
            cLIENTSDataGridView.AutoGenerateColumns = true;
            cLIENTSDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cLIENTSDataGridView.ReadOnly = true;
            cLIENTSDataGridView.AllowUserToAddRows = false;
            var clients = _unit.Client.GetAll().ToList();
            var city = _unit.City.GetAll().ToList();
            var joined = from c in clients
                         join ci in city on c.CITY_ID equals ci.ID
                         select new ClientDTO
                         {
                             ID = c.ID,
                             PHONE_NUMBER = c.PHONE_NUMBER,
                             FIRST_NAME = c.FIRST_NAME,
                             LAST_NAME = c.LAST_NAME,
                             STREET = c.STREET,
                             APARTMENT_NUMBER = c.APARTMENT_NUMBER,
                             HOME_NUMBER = c.HOME_NUMBER,
                             FLOOR = c.FLOOR,
                             CITY = ci.NAME
                         };

            cLIENTSDataGridView.DataSource = joined.ToList();
        }
        private void FormClients_Load(object sender, EventArgs e)
        {

            this.button2.Enabled = false;
        }

        private void btnHomeClients_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu(_unit);
            formMenu.ShowDialog();
            this.Hide();
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu(_unit);
            formMenu.ShowDialog();
            this.Hide();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void cLIENTSDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure a valid row is clicked (excluding header row)
            {
                DataGridViewRow selectedRow = cLIENTSDataGridView.Rows[e.RowIndex];

                // Populate the text boxes with the values from the selected row
                this.pHONE_NUMBERTextBox.Text = selectedRow.Cells["PHONE_NUMBER"].Value.ToString();
                this.fIRST_NAMETextBox.Text = selectedRow.Cells["FIRST_NAME"].Value.ToString();
                this.lAST_NAMETextBox.Text = selectedRow.Cells["LAST_NAME"].Value.ToString();
                this.sTREETTextBox.Text = selectedRow.Cells["STREET"].Value.ToString();
                this.cITYTextBox.Text = selectedRow.Cells["CITY"].Value.ToString();
                this.aPARTMENT_NUMBERTextBox.Text = selectedRow.Cells["APARTMENT_NUMBER"].Value.ToString();
                this.fLOORTextBox.Text = selectedRow.Cells["FLOOR"].Value.ToString();
                this.hOME_NUMBERTextBox.Text = selectedRow.Cells["HOME_NUMBER"].Value.ToString();
                this.button2.Enabled = true;
                clientId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClientDetails details = new FormClientDetails(_unit);
            details.ShowDialog();
            cLIENTSDataGridView.DataSource = null;
            cLIENTSDataGridView.Rows.Clear();
            InitializeDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clientId == 0)
            {
                MessageBox.Show("Please select a client to update");
                return;
            }

            var client = _unit.Client.GetById(clientId);
            FormClientDetails details = new FormClientDetails(_unit, client);
            details.ShowDialog();
            cLIENTSDataGridView.DataSource = null;
            cLIENTSDataGridView.Rows.Clear();
            InitializeDataGrid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clientId == 0)
            {
                MessageBox.Show("Please select a client to order");
            }
            else
            {
                OnClientSelected(clientId);
                this.Close();
            }

        }
    }
}
