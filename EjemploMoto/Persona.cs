using System;

namespace EjemploMoto
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public Moto moto;

        public void arrancarMoto()
        {
            moto.arracar();
        }

        public void apagarMoto()
        {
            moto.apagar();
        }
    }
}