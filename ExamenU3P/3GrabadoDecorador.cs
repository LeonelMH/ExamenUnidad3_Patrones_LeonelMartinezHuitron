using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3P
{
    public class _3GrabadoDecorador : _1JoyaDecorador
    {
        public _3GrabadoDecorador(_0JoyeriaInterfazComponent joyas) : base(joyas)
        {
        }
        public override double Costo => _joyas.Costo + 150.0;
        public override string Descripcion => _joyas.Descripcion + "\n\n (+) Grabado\t\t\t\t$150.0";
    }
}
