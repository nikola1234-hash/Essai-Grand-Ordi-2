using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai_Grand_Ordi_1.DataAccess.Entities
{
    [Table("PAYMENTS")]
    public class Payments : BaseEntity
    {
        public int ORDER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
}
