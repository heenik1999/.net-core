using System;

namespace Q_34
{
    class Program
    {

        interface Bike
        {
            void wheels();
        }
        class Honda :  Bike
        {
            public void wheels()
            {
                Console.WriteLine("Honda Activa has Two wheels.");
            }
        }
        class Ather : Bike
        {
            public void wheels()
            {
                Console.WriteLine("Ather E-Bike has Two wheels.");
            }
        }
        static void Main(string[] args)
        {
            {
                Honda h = new Honda();
                Ather a = new Ather();
                h.wheels();
                a.wheels();
            }
        }
    }
}
