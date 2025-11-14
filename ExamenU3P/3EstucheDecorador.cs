using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3P
{
    public class _3EstucheDecorador : _1JoyaDecorador
    {
        public _3EstucheDecorador(_0JoyeriaInterfazComponent joyas) : base(joyas) 
        {
        }
        public override double Costo => _joyas.Costo + 100.0;
        public override string Descripcion => _joyas.Descripcion + "\n\n (+) Estuche Lujoso\t\t\t$100.0";
    }
}
