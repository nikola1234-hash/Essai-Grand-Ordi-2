using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai_Grand_Ordi_1.DataAccess.Entities
{
    [Table("ORDERS")]
    public class Orders : BaseEntity
    {
        public int CLIENT_ID { get; set; }
        public string DATE_ORDERED { get; set; }
        public string ORDER_RECIEVED { get; set; }
        public string ORDER_TYPE { get; set; }
        public int ORDER_DETAILS_ID { get; set; }
    }
}
