using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern_MarcoProaño.Diagramas
{
    class EnduroBuilder : MotoBuilder
    {
        public EnduroBuilder()
        {
            moto = new Moto("Enduro");
        }

        public override void construirCarroceria()
        {
            moto["carroceria"] = "Aluminio";
        }

        public override void construirMotor()
        {
            moto["motor"] = "250cc";
        }

        public override void construirRuedas()
        {
            moto["ruedas"] = "Rodado 22";
        }
    }
}

