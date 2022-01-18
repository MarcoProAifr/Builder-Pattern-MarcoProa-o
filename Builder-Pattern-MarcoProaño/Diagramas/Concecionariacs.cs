using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern_MarcoProaño.Diagramas
{
    class Concecionaria
    {
        public void Construct(MotoBuilder motoBuilder)
        {
            motoBuilder.construirMotor();
            motoBuilder.construirCarroceria();
            motoBuilder.construirRuedas();
        }
    }
}