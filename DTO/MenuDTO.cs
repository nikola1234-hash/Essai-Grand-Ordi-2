using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai_Grand_Ordi_1.DTO
{
    public class MenuDTO
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public double PRICE { get; set; }
        public int Quantity { get; set; }
        public MenuDTO()
        {

        }

        public MenuDTO(string nAME, double pRICE, int itemID)
        {
            NAME = nAME;
            PRICE = pRICE;
            ID = itemID;
            Quantity = 1;
        }
    }
}
