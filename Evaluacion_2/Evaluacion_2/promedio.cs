using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_2
{
    public class promedio
    {
        private string nombre;
        private int cuenta;
        private decimal not1;
        private decimal not2;
        private decimal not3;
        private decimal not4;
        private decimal resultado;
        private string decision;

        public string Nombre  { get; set; }
        public decimal Cuenta { get; set; }
        public decimal nota1  { get; set; }
        public decimal nota2  { get; set; }
        public decimal nota3  { get; set; }
        public decimal nota4  { get; set; }
        public promedio() { }

        public promedio(string _nombre, int _cuenta)
        {
            Nombre = _nombre;
            Cuenta = _cuenta;

        }

        public promedio(decimal _not1, decimal _not2, decimal _not3, decimal _not4)
        {
            nota1 = _not1;
            nota2 = _not2;
            nota3 = _not3;
            nota4 = _not4;
        }


        public decimal Resultado()
        {
            resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            return resultado;
        }

        public string Decision()
        {
            if (Convert.ToDecimal(resultado) >= 70 && Convert.ToDecimal(resultado) <= 100)
            {
                decision = "APROBADO";
            }
            else
            {
                decision = "REPROBADO";
            }

            return decision;
        }
        
    }
}
