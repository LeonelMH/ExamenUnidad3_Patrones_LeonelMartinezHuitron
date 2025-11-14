using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3P
{
    public class _4BonificacionMaterial : _1JoyaDecorador
    {
        private string _material;
        public _4BonificacionMaterial(_0JoyeriaInterfazComponent joyas, string material) : base(joyas)
        {
            _material = material;
        }
        public override string Descripcion
        {
            get
            {
                string detalle = "";

                if (_material == "Plata") detalle = "5%";
                else if (_material == "Platino") detalle = "8%";
                else if (_material == "Oro") detalle = "0%";

                return _joyas.Descripcion + $"\n\n + Bonificación por material ({_material}) {detalle}";
            }
        }

        public override double Costo
        {
            get
            {
                double precioBase = _joyas.Costo;
                double descuento = 0;

                if (_material == "Plata") descuento = 0.05;
                else if (_material == "Platino") descuento = 0.08;
                else if (_material == "Oro") descuento = 0.0;

                if (descuento > 0)
                {
                    return precioBase * (1 - descuento);
                }

                return precioBase;
            }
        }

    }
}
