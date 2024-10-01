using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wGestionEmpleador
{
    internal class clsGerente : clsEmpleado 
    {
        public clsGerente(string nombre, decimal salario) : base(nombre , salario)
        {
        
        }

        public override decimal CalcularBono()
        {
            return Salario * 0.20m;
        }

        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + "Rol: Gerente";
        }
    }
}
