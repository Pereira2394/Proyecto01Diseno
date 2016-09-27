using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    public class DTO
    {
        TextReader tr = new TextReader();
        public String[] abecedario { get; set; }
        public String[] tiraEntrada { get; set; }
        public String[] tiraSalida { get; set; }
        public String[] tipoAlgoritmo { get; set; }
    }
}
