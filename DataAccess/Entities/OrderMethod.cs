using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai_Grand_Ordi_1.DataAccess.Entities
{
    [Table("ORDER_METHOD")]
    public class OrderMethod : BaseEntity
    {
        public string DESCRIPTION { get; set; }
    }
}
