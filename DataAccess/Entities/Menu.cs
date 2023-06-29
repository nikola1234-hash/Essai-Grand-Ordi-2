using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai_Grand_Ordi_1.DataAccess.Entities
{
    [Table("MENU")]
    public class Menu : BaseEntity
    {
        public string NAME { get; set; }
        public string IMAGE_PATH { get; set; }
        public string DESCRIPTION { get; set; }
        public decimal PRICE { get; set; }
        public bool IS_ACTIVE { get; set; }

    }
}
