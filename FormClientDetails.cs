using Essai_Grand_Ordi_1.DataAccess;
using Essai_Grand_Ordi_1.DataAccess.Entities;
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
    public partial class FormClientDetails : Form
    {
        private IUnitOfWork _unit;
        private Client _client;
        private bool isUpdate = false;
        public FormClientDetails(IUnitOfWork unit)
        {
            InitializeComponent();
            _unit = unit;
            _client = new Client();

        }
        public FormClientDetails(IUnitOfWork unit, Client client)
        {
            InitializeComponent();
            _unit = unit;
            _client = client;
            isUpdate = true;
            InitializeFields();
        }

        private void InitializeFields()
        {
            this.pHONE_NUMBERTextBox.Text = _client.PHONE_NUMBER;
            this.fIRST_NAMETextBox.Text = _client.FIRST_NAME;
            this.lAST_NAMETextBox.Text = _client.LAST_NAME;
            this.sTREETTextBox.Text = _client.STREET;
            this.comboBox1.SelectedValue = _client.CITY_ID;
            this.aPARTMENT_NUMBERTextBox.Text = _client.APARTMENT_NUMBER;
            this.fLOORTextBox.Text = _client.FLOOR;
            this.hOME_NUMBERTextBox.Text = _client.HOME_NUMBER;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate PHONE_NUMBER
                if (string.IsNullOrWhiteSpace(this.pHONE_NUMBERTextBox.Text))
                {
                    MessageBox.Show("Please enter a phone number.");
                    return; // Stop further processing
                }
                _client.PHONE_NUMBER = this.pHONE_NUMBERTextBox.Text;

                // Validate FIRST_NAME
                if (string.IsNullOrWhiteSpace(this.fIRST_NAMETextBox.Text))
                {
                    MessageBox.Show("Please enter a first name.");
                    return;
                }
                _client.FIRST_NAME = this.fIRST_NAMETextBox.Text;

                // Validate LAST_NAME
                if (string.IsNullOrWhiteSpace(this.lAST_NAMETextBox.Text))
                {
                    MessageBox.Show("Please enter a last name.");
                    return;
                }
                _client.LAST_NAME = this.lAST_NAMETextBox.Text;

                // Validate STREET
                if (string.IsNullOrWhiteSpace(this.sTREETTextBox.Text))
                {
                    MessageBox.Show("Please enter a street.");
                    return;
                }
                _client.STREET = this.sTREETTextBox.Text;

                // Validate CITY_ID
                if (this.comboBox1.SelectedValue == null || !(this.comboBox1.SelectedValue is int))
                {
                    MessageBox.Show("Please select a valid city.");
                    return;
                }
                _client.CITY_ID = (int)this.comboBox1.SelectedValue;

                // Validate APARTMENT_NUMBER
                if (string.IsNullOrWhiteSpace(this.aPARTMENT_NUMBERTextBox.Text))
                {
                    MessageBox.Show("Please enter an apartment number.");
                    return;
                }
                _client.APARTMENT_NUMBER = this.aPARTMENT_NUMBERTextBox.Text;

                // Validate FLOOR
                if (string.IsNullOrWhiteSpace(this.fLOORTextBox.Text))
                {
                    MessageBox.Show("Please enter a floor.");
                    return;
                }
                _client.FLOOR = this.fLOORTextBox.Text;

                // Validate HOME_NUMBER
                if (string.IsNullOrWhiteSpace(this.hOME_NUMBERTextBox.Text))
                {
                    MessageBox.Show("Please enter a home number.");
                    return;
                }
                _client.HOME_NUMBER = this.hOME_NUMBERTextBox.Text;

                if (isUpdate)
                {
                    _unit.Client.Update(_client);
                    MessageBox.Show("Successfully updated Client");
                }
                else
                {
                    _unit.Client.Insert(_client);
                    MessageBox.Show("Successfully added new Client");

                }



                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClientDetails_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = _unit.City.GetAll().ToList();
            this.comboBox1.DisplayMember = "NAME";
            this.comboBox1.ValueMember = "ID";
        }

    }
}
