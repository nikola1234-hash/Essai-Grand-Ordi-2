using Essai_Grand_Ordi_1.DataAccess;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Essai_Grand_Ordi_1
{
    public partial class FormProducts : Form
    {
        private IUnitOfWork _unit;
        private Essai_Grand_Ordi_1.DataAccess.Entities.Menu selectedProduct;
        public FormProducts(IUnitOfWork unit)
        {
            InitializeComponent();
            _unit = unit;
            listView1.View = View.Details;
            listView1.Columns.Add("Name", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Price", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Description", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Id", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Is Active", 60, HorizontalAlignment.Left);
            listView1.FullRowSelect = true;

        }



        private void FormProducts_Load(object sender, EventArgs e)
        {
            var products = _unit.Menu.GetAll().ToList();


            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(product.NAME);
                item.SubItems.Add(product.PRICE.ToString());
                item.SubItems.Add(product.DESCRIPTION);
                item.SubItems.Add(product.ID.ToString());
                item.SubItems.Add(product.IS_ACTIVE.ToString());
                listView1.Items.Add(item);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ProductDetails productDetails = new ProductDetails(_unit);
            productDetails.ShowDialog();
            listView1.Items.Clear();
            FormProducts_Load(sender, e);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            var id = listView1.SelectedItems[0].SubItems[3].Text;
            var product = _unit.Menu.GetById(int.Parse(id));
            if (product == null)
            {
                MessageBox.Show("Product not found");
                return;
            }
            pictureBox3.Image = Image.FromFile(product.IMAGE_PATH);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Refresh();
            selectedProduct = product;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                ProductDetails productDetails = new ProductDetails(_unit, selectedProduct);
                productDetails.ShowDialog();
                listView1.Items.Clear();
                FormProducts_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a product");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _unit.Menu.Delete(selectedProduct);
                MessageBox.Show("Product deleted successfully");
                listView1.Items.Clear();
                FormProducts_Load(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}