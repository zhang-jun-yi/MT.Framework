using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Data;


namespace MT.Account
{
    public class Role:IDataModle
    {
        public long ID { get; set; }
        public int Num { get; set; }
    }
}
