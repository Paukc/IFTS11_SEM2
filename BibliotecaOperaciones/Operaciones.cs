using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOperaciones
{
    public class Operaciones
    {
        private double num1, num2;
        public double numero1 { get => num1; set => num1 = value; }
        public double numero2 { get => num2; set => num2 = value; }
    
        public Operaciones(double Num1, double Num2)
        {
            this.numero1 = Num1;
            this.numero2 = Num2;
        }


        public static double Suma(double numero1, double numero2)
        {
            return (numero1 + numero2);
        }

        public static double Resta(double numero1, double numero2)
        {
            return (numero1 - numero2);
        }

        public static double Multiplicacion(double numero1, double numero2)
        {
            return (numero1 * numero2);
        }

        public static string Division(double numero1, double numero2)
        {
            if (numero2 == '0')
            {
                return "No se puede dividir por cero";
            }
            else
            {
                return (numero1 / numero2).ToString();
            }

        }

        public static double Percentage (double numero1, double numero2)
        {
            double result = (numero1 * 100) / numero2;
            return result;
        }
    }
}
