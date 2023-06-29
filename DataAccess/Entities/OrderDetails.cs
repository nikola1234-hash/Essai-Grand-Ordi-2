using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai_Grand_Ordi_1.DataAccess.Entities
{
    [Table("ORDER_DETAILS")]
    public class OrderDetails : BaseEntity
    {
        public int DISH_ID { get; set; }
        public int QUANTITY { get; set; }
    }
}
