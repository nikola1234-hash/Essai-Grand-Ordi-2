using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai_Grand_Ordi_1.DataAccess.Entities
{
    [Table("CLIENT")]
    public class Client : BaseEntity
    {
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string STREET { get; set; }
        public string APARTMENT_NUMBER { get; set; }
        public string FLOOR { get; set; }
        public string HOME_NUMBER { get; set; }
        public int CITY_ID { get; set; }
        public string PHONE_NUMBER { get; set; }
    }
}
