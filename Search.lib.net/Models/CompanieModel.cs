using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.lib.net.Models
{
   public class CompanieModel
    {
        public long id { get; set; }
        public string ruc { get; set; }
        public string razon_social { get; set; }
        public string estadoContribuyente { get; set; }
        public string condicionDomicilio { get; set; }
        public string ubigeo { get; set; }
        public string tipoVia { get; set; }
        public string nombreVia { get; set; }
        public string codigoZona { get; set; }
        public string tipoZona { get; set; }
        public string numero { get; set; }
        public string interior { get; set; }
        public string lote { get; set; }
        public string departamento { get; set; }
        public string manzana { get; set; }
        public string kilometro { get; set; }
    }
}
