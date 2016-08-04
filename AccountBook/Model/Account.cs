using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook
{
    public class Account
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public decimal Money { get; set; }

        public int Type { get; set; }

        public string Remark { get; set; }

        public string IsOut { get; set; }
    }
}
