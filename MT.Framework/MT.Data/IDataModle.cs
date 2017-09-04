using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Data
{
    public class IDataModle 
    {
        public string Name { get; set; }
        public DateTime CreatTime { get; set; } = DateTime.UtcNow;
        public DateTime? DeleteTime { get; set; } 
    }
}
