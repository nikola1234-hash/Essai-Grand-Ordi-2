using Essai_Grand_Ordi_1.DataAccess;
using Essai_Grand_Ordi_1.DTO;
using Essai_Grand_Ordi_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Essai_Grand_Ordi_1
{
    public partial class FormToOrder : Form
    {
        private List<Essai_Grand_Ordi_1.DataAccess.Entities.Menu> menu;
        private List<MenuDTO> cart;
        private IUnitOfWork _unit;
        private bool isPhase2 = false;
        private int clientId = default;
        private OrderService os;
        public FormToOrder(IUnitOfWork unit)
        {
            InitializeComponent();
            _unit = unit;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView2.FullRowSelect = true;
            listView2.View = View.Details;
            os = new OrderService();
        }

        private void FormToOrder_Load(object sender, EventArgs e)
        {
            menu = _unit.Menu.GetAll().ToList();
            PopulateMenuListView();
            listView2.Refresh();
        }
        private void PopulateMenuListView()
        {

            foreach (var item in menu)
            {
                ListViewItem listViewItem = new ListViewItem(item.NAME);
                listViewItem.SubItems.Add(item.PRICE.ToString("C2"));
                listViewItem.SubItems.Add(item.ID.ToString());
                listView1.Items.Add(listViewItem);
            }
            listView1.Refresh();
        }

        private void PopulateCartListView()
        {
            listView2.Items.Clear();

            foreach (var item in cart)
            {
                ListViewItem listViewItem = new ListViewItem(item.NAME);
                listViewItem.SubItems.Add(item.PRICE.ToString("C2"));
                listViewItem.SubItems.Add(item.Quantity.ToString());
                listView2.Items.Add(listViewItem);
            }
        }




        private void removeFromCartButton_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView2.SelectedItems[0];
                string itemName = selectedItem.SubItems[0].Text;

                MenuDTO cartItem = cart.Find(item => item.NAME == itemName);
                if (cartItem != null)
                {
                    cartItem.Quantity--;
                    if (cartItem.Quantity <= 0)
                    {
                        cart.Remove(cartItem);
                    }
                }
                if (cart.Count == 0)
                {
                    label3.Text = "Total: 0".ToString();
                }
                else
                {
                    label3.Text = "Total: " + cart.Sum(item => item.PRICE * item.Quantity).ToString("C2");
                }

                PopulateCartListView();
            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (cart == null)
            {
                cart = new List<MenuDTO>();
            }
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string itemName = selectedItem.SubItems[0].Text;
                double itemPrice = double.Parse(selectedItem.SubItems[1].Text.TrimStart('$'));
                int itemID = int.Parse(selectedItem.SubItems[2].Text);

                var existingItem = cart.Find(item => item.NAME == itemName);
                if (existingItem != null)
                {
                    existingItem.Quantity++;
                }
                else
                {
                    MenuDTO menuItem = new MenuDTO(itemName, itemPrice, itemID);
                    cart.Add(menuItem);
                }
                label3.Text = "Total: " + cart.Sum(item => item.PRICE * item.Quantity).ToString("C2");
                PopulateCartListView();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (isPhase2)
                {
                    try
                    {
                        os.SaveOrder(cart, clientId);
                        MessageBox.Show("Order saved");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    FormClients formClients = new FormClients(_unit, true);
                    formClients.ClientSelected += FormClients_ClientSelected;
                    formClients.ShowDialog();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void FormClients_ClientSelected(object sender, int e)
        {
            isPhase2 = true;
            this.button3.Text = "Order";
            clientId = e;
        }
    }

}

