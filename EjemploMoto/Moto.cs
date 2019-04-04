using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploMoto
{
    public class Moto
    {
        public string modelo;

        public string patente;

        public double cantidadNafta;

        public int anio;

        public int nroSerie;

        public string fabricante;

        public double capacidadTanque;

        internal void informarEstado()
        {
            Console.WriteLine($"Estado Motor: {estadoMotor} Cantidad Nafta: {cantidadNafta}");
        }

        public bool estadoMotor;

        public void arracar()
        {
            if (!estadoMotor)
                estadoMotor = true; 
        }

        public void apagar()
        {
            if (estadoMotor)
                estadoMotor = false;
        }

        public void acelerar(double distancia)
        {
            
        }
    }
}
