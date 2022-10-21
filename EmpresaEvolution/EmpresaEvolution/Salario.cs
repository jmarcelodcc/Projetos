using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaEvolution
{
    internal class Salario
    {
        public double salario, porce30, porce8;
        
        internal void Retorno()
        {
            porce30 = salario * 0.3;
            porce8 = salario * 0.08;
        }
    }
}
