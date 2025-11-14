using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3P
{
    public class _2Anillo : _0JoyeriaInterfazComponent
    {
        public override double Costo => 250.0;
        public override string Descripcion => "Anillo\t\t\t\t\t$250.0" +
                                             "\n (-) Estuche\t\t\t\t$0.00" +
                                             "\n (-) Grabado\t\t\t\t$0.00" +
                                             "\n (-) Seguro\t\t\t\t$0.00";
    }
}
