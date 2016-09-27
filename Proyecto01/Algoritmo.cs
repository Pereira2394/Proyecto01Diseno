using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    abstract class Algoritmo
    {
        abstract public String codificar(String abecedario, String tiraEntrada, String tipoAlgoritmo);
        abstract public String decodificar(String abecedario, String tiraEntrada, String tipoAlgoritmo);
    }
}
