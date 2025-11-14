using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3P
{
    public abstract class _1JoyaDecorador : _0JoyeriaInterfazComponent
    {
        protected _0JoyeriaInterfazComponent _joyas;
        public _1JoyaDecorador(_0JoyeriaInterfazComponent joyas)
        {
            _joyas = joyas;
        }
    }
}
