using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern_MarcoProaño.Diagramas
{
    class Moto
    {
        private string _motoTipo;
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();

        // Constructor
        public Moto(string motoTipo)
        {
            this._motoTipo = motoTipo;
        }

        // Indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Tipo de Moto: {0}", _motoTipo);
            Console.WriteLine(" Motor : {0}", _parts["motor"]);
            Console.WriteLine(" Ruedas: {0}", _parts["ruedas"]);
            Console.WriteLine(" Carroceria : {0}", _parts["carroceria"]);
        }
    }
}
