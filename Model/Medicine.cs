using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Medicine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int PersonelID { get; set; }
        public int FactoryID { get; set; }
    }
}
