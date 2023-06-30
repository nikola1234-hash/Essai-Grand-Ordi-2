using Essai_Grand_Ordi_1.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai_Grand_Ordi_1
{
    public partial class ProductDetails : Form
    {

        private IUnitOfWork _unit;
        private DataAccess.Entities.Menu _menu;
        private bool _isUpdate = false;
        private int _menuId = default;
        private string imagePath = string.Empty;
        private string destinationPath = string.Empty;
        public ProductDetails(IUnitOfWork unit)
        {
            InitializeComponent();
            _unit = unit;
        }
        public ProductDetails(IUnitOfWork unit, DataAccess.Entities.Menu menu)
        {
            InitializeComponent();
            _unit = unit;
            _menu = menu;
            _isUpdate = true;
            InitializeFields();
        }
        private void InitializeFields()
        {
            try
            {
                this.textBox1.Text = _menu.NAME;
                this.textBox2.Text = _menu.DESCRIPTION;
                this.textBox3.Text = _menu.PRICE.ToString();
                this.pictureBox1.Image = Image.FromFile(_menu.IMAGE_PATH);
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pictureBox1.Refresh();
                this.checkBox1.Checked = _menu.IS_ACTIVE;
                this.destinationPath = _menu.IMAGE_PATH;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_isUpdate)
                {
                    _menu = new DataAccess.Entities.Menu();
                }


                // Validate NAME
                if (string.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    MessageBox.Show("Please enter a name.");
                    return; // Stop further processing
                }
                _menu.NAME = this.textBox1.Text;

                // Validate DESCRIPTION
                if (string.IsNullOrWhiteSpace(this.textBox2.Text))
                {
                    MessageBox.Show("Please enter a description.");
                    return;
                }
                _menu.DESCRIPTION = this.textBox2.Text;

                // Validate PRICE
                if (!decimal.TryParse(this.textBox3.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Please enter a valid price greater than zero.");
                    return;
                }
                _menu.PRICE = price;

                // Validate IMAGE_PATH
                if (string.IsNullOrWhiteSpace(destinationPath))
                {
                    MessageBox.Show("Please select an image.");
                    return;
                }
                if (!string.IsNullOrEmpty(destinationPath))
                {
                    _menu.IMAGE_PATH = destinationPath;
                }
                else
                {
                    _menu.IMAGE_PATH = string.Empty;
                }

                // Set IS_ACTIVE
                _menu.IS_ACTIVE = this.checkBox1.Checked;



                if (_isUpdate)
                {
                    _unit.Menu.Update(_menu);
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        File.Copy(imagePath, destinationPath);
                    }
                    MessageBox.Show("Product updated successfully.");
                    this.Close();
                }
                else
                {

                    _unit.Menu.Insert(_menu);
                    File.Copy(imagePath, destinationPath);
                    MessageBox.Show("Product added successfully.");
                    this.Close();
                }





            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected image file path
                imagePath = openFileDialog.FileName;

                // Generate a new unique file name in the Resources folder
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imagePath);
                destinationPath = Path.Combine(Application.StartupPath, "ProductResources", fileName);

                try
                {

                    // Load the image into the PictureBox
                    pictureBox1.Image = Image.FromFile(imagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Refresh();

                    // Display a success message
                    MessageBox.Show("Image added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the image: {ex.Message}");
                }
            }
        }
    }
}
