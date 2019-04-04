using System;

namespace EjemploMoto
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto unaMoto = new Moto();
            unaMoto.anio = 2009;
            unaMoto.estadoMotor = false; // motor apagado
            unaMoto.capacidadTanque = 10;
            unaMoto.cantidadNafta = 10;

            unaMoto.informarEstado();
            unaMoto.arracar();
            unaMoto.informarEstado();

            Persona unaPersona = new Persona();
            Console.WriteLine("Ingrese nombre de la persona:");
            unaPersona.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad de la persona:");
            unaPersona.edad = Convert.ToInt32(Console.ReadLine());

            unaPersona.moto = unaMoto;

            //unaPersona.moto.apagar();

            unaPersona.apagarMoto();

            unaPersona.moto.informarEstado();
        }
    }
}
