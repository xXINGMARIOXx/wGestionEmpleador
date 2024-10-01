using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wGestionEmpleador
{
    public abstract class clsEmpleado
    {


        public string Nombre { get; set; }
        public decimal Salario { get; set; }

        public clsEmpleado(string nombre, decimal salario)
        {
            Nombre = nombre;
            Salario = salario;
        }

        // metoddo abstracto calcular bono

        public abstract decimal CalcularBono();

        // metodo mostrar informacion

        public virtual string MostrarInformacion()
        {
            return $"Nombre : {Nombre}, decimal {Salario}";
        }


    }
}
