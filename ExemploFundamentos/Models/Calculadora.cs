using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Seno(double angulo) {
            double radiano = angulo * Math.PI / 180;

            double seno = Math.Sin(radiano);

            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo) {
            double radiano = angulo * Math.PI / 180;

            double coseno = Math.Cos(radiano);

            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo) {
            double radiano = angulo * Math.PI / 180;

            double tangente = Math.Tan(radiano);

            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }
        public void 
    }
}