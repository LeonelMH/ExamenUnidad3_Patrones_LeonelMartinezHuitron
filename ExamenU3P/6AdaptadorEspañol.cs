using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3P
{
    public class _6AdaptadorEspañol : _5nterfazInternacionalAdaptador
    {
        private _0JoyeriaInterfazComponent _joya;

        public _6AdaptadorEspañol(_0JoyeriaInterfazComponent joya)
        {
            _joya = joya;
        }

        public override void MostrarDescripcion()
        {
            Console.WriteLine("Descripción:\n" + _joya.Descripcion);
        }

        public override void MostrarCosto()
        {
            Console.WriteLine($"Costo total: ${_joya.Costo}");
        }

    }
}
