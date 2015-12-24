using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace utStore.Library.Entidades
{
    public class Clientes
    {
        public int ID { set; get; }
        public string nombre { set; get; }
        public decimal deuda_maxima { set; get; }
        public decimal deuda { set; get; }
    }
}
