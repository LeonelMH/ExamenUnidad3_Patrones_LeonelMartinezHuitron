using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3P
{
    public class _3SeguroDecorador : _1JoyaDecorador
    {
        public _3SeguroDecorador(_0JoyeriaInterfazComponent joyas) : base(joyas)
        {
        }
        public override double Costo => _joyas.Costo + 500.0;
        public override string Descripcion => _joyas.Descripcion + "\n\n (+) Seguro\t\t\t\t$500.0";
    }
}
