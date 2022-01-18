using System;
using Builder_Pattern_MarcoProaño.Diagramas;

namespace Builder_Pattern_MarcoProaño
{
    class Program
    {
        static void Main(string[] args)
        {
            MotoBuilder builder;

            // Create shop with vehicle builders
            Concecionaria concecionaria = new Concecionaria();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            concecionaria.Construct(builder);
            builder.Moto.Show();

            builder = new EnduroBuilder();
            concecionaria.Construct(builder);
            builder.Moto.Show();

            builder = new PisteroBuilder();
            concecionaria.Construct(builder);
            builder.Moto.Show();

            // Wait for user
            Console.ReadKey();

        }
    }
}
