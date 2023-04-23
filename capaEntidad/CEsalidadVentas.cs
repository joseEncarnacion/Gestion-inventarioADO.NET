using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class CEsalidadVentas
    {
        public int idSalida { get; set; }
        public string codigopdfk { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
    }
}
