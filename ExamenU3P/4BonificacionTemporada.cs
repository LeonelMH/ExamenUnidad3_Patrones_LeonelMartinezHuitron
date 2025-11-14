using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3P
{
    public class _4BonificacionTemporada : _1JoyaDecorador
    {
        private string _temporada;
        public _4BonificacionTemporada(_0JoyeriaInterfazComponent joyas, string temporada) : base(joyas)
        {
            _temporada = temporada;
        }
        public override string Descripcion
        {
            get
            {
                string detalle = "";

                if (_temporada == "Navidad") detalle = "15%";
                else if (_temporada == "San Valentín") detalle = "10%";
                else if (_temporada == "Verano") detalle = "5%";

                return _joyas.Descripcion + $"\n\n + Bonificación por temporada ({_temporada}) {detalle}";
            }
        }

        public override double Costo
        {
            get
            {
                double precioBase = _joyas.Costo;
                double descuento = 0;

                if (_temporada == "Navidad") descuento = 0.15;
                else if (_temporada == "San Valentín") descuento = 0.10;
                else if (_temporada == "Verano") descuento = 0.05;

                if (descuento > 0)
                {
                    return precioBase * (1 - descuento);
                }

                return precioBase;
            }
        }
    }
}
