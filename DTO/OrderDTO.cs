using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai_Grand_Ordi_1.DTO
{
    public class OrderDTO
    {
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string STREET { get; set; }
        public string APARTMENT_NUMBER { get; set; }
        public string FLOOR { get; set; }
        public string HOME_NUMBER { get; set; }
        public string CITY { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string DATE_ORDERED { get; set; }
        public string ORDER_RECIEVED { get; set; }
        public string ORDER_TYPE { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public decimal PRICE { get; set; }
        public int QUANTITY { get; set; }
        public decimal TOTAL_PRICE { get; set; }
    }
}
