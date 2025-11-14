using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3P
{
    public class _6AdaptadorIngles : _5nterfazInternacionalAdaptador
    {
        private _0JoyeriaInterfazComponent _joya;
        public _6AdaptadorIngles(_0JoyeriaInterfazComponent joya)
        {
            _joya = joya;
        }

        public override void MostrarDescripcion()
        {
            Console.WriteLine("Description:\n" + _joya.Descripcion);
        }

        public override void MostrarCosto()
        {
            Console.WriteLine($"Total cost: ${_joya.Costo}");
        }

    }
}
