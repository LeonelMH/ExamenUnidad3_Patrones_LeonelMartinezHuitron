using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3P
{
    public class _3EnvioDecorador : _1JoyaDecorador
    {
        public _3EnvioDecorador(_0JoyeriaInterfazComponent joyas) : base(joyas)
        {
        }
        public override double Costo => _joyas.Costo + 50.0;
        public override string Descripcion => _joyas.Descripcion + "\n\n (+) Envio a domicilio\t\t\t$50.0";
    }
}
