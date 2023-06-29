using Dapper;
using Essai_Grand_Ordi_1.DataAccess;
using Essai_Grand_Ordi_1.DataAccess.Entities;
using Essai_Grand_Ordi_1.DataAccess.Extensions;
using Essai_Grand_Ordi_1.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Essai_Grand_Ordi_1.Services
{
    public class OrderService
    {
        private IUnitOfWork _unit;
        private string connectionStirng = ConfigurationManager.ConnectionStrings["Bakery"].ToString();

        public OrderService()
        {
            _unit = new UnitOfWork();
        }
        public IEnumerable<OrderDTO> GetOrders()
        {
            var orders = _unit.Orders.GetAll();
            var orderDetails = _unit.OrderDetils.GetAll();
            var orderMethod = _unit.OrderMethod.GetAll();
            var client = _unit.Client.GetAll();
            var product = _unit.Menu.GetAll();
            var city = _unit.City.GetAll();

            var ordersList = from o in orders
                             join c in client on o.CLIENT_ID equals c.ID
                             join od in orderDetails on o.ORDER_DETAILS_ID equals od.ID
                             join pr in product on od.DISH_ID equals pr.ID
                             join ci in city on c.CITY_ID equals ci.ID
                             select new OrderDTO
                             {
                                 FIRST_NAME = c.FIRST_NAME,
                                 LAST_NAME = c.LAST_NAME,
                                 STREET = c.STREET,
                                 APARTMENT_NUMBER = c.APARTMENT_NUMBER,
                                 HOME_NUMBER = c.HOME_NUMBER,
                                 FLOOR = c.FLOOR,
                                 CITY = ci.NAME,
                                 PHONE_NUMBER = c.PHONE_NUMBER,
                                 NAME = pr.NAME,
                                 PRICE = pr.PRICE,
                                 QUANTITY = od.QUANTITY,
                                 TOTAL_PRICE = pr.PRICE * od.QUANTITY,
                                 DATE_ORDERED = o.DATE_ORDERED,
                                 ORDER_RECIEVED = o.ORDER_RECIEVED,
                                 ORDER_TYPE = o.ORDER_TYPE

                             };
            return ordersList;




        }
        public void SaveOrder(List<MenuDTO> dto, int clientID)
        {

            using (IDbConnection conn = new OleDbConnection(connectionStirng))
            {
                conn.Open();
                using (IDbTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {

                        foreach (var item in dto)
                        {
                            var orderDetails = new OrderDetails
                            {
                                DISH_ID = item.ID,
                                QUANTITY = item.Quantity
                            };

                            conn.Execute("INSERT INTO ORDER_DETAILS (DISH_ID, QUANTITY) VALUES (@DISH_ID, @QUANTITY)", orderDetails, transaction);
                            var id = conn.Query<int>("SELECT @@IDENTITY", param: null, transaction).FirstOrDefault();
                            Orders order = new Orders
                            {
                                CLIENT_ID = clientID,
                                DATE_ORDERED = DateTime.Now.ToString(),
                                ORDER_RECIEVED = DateTime.Now.ToString(),
                                ORDER_TYPE = "Delivery",
                                ORDER_DETAILS_ID = Convert.ToInt32(id)
                            };
                            var param = new Dictionary<string, object>()
                            {
                                ["CLIENT_ID"] = clientID,
                                ["DATE_ORDERED"] = DateTime.Now.ToString(),
                                ["ORDER_RECIEVED"] = DateTime.Now.ToString(),
                                ["ORDER_TYPE"] = "Delivery",
                                ["ORDER_DETAILS_ID"] = Convert.ToInt32(id)
                            };
                            var dynamicParam = new DynamicParameters(param);
                            conn.Execute("INSERT INTO ORDERS (CLIENT_ID, DATE_ORDERED, ORDER_RECIEVED, ORDER_TYPE, ORDER_DETAILS_ID) VALUES (@CLIENT_ID, @DATE_ORDERED, @ORDER_RECIEVED, @ORDER_TYPE, @ORDER_DETAILS_ID)", dynamicParam, transaction);
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }


        }
    }
}
