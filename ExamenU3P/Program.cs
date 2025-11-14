using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool joyaValido = false, personalizado = true;
            string opcion = "";
            _0JoyeriaInterfazComponent joya = null;
            while (!joyaValido)
            {

                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("\t\tJOYERIA CHULA VISTA");
                Console.WriteLine("---------------------------------------------------------\n");

                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Bienvenido a Joyeria Chula Vista");
                Console.WriteLine("---------------------------------------------------------\n");

                Console.WriteLine("1. Anillo\t\t\t$250.00");
                Console.WriteLine("2. Aretes\t\t\t$300.00");
                Console.WriteLine("3. Collar\t\t\t$350.00");
                Console.WriteLine("4. Pulsera\t\t\t$400.00");
                Console.WriteLine("Elige una opción:");
                opcion = Console.ReadLine();
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        joya = new _2Anillo();
                        joyaValido = true;
                        break;
                    case "2":
                        joya = new _2Aretes();
                        joyaValido = true;
                        break;
                    case "3":
                        joya = new _2Collar();
                        joyaValido = true;
                        break;
                    case "4":
                        joya = new _2Pulsera();
                        joyaValido = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine($"\tJOYA SELECCIONADO\n{joya.Descripcion}");

            Console.WriteLine("\n¿Deseas personalizar tu JOYA?");
            Console.WriteLine("1. Sí/\n2. No");
            Console.WriteLine("Elige una opción:");
            opcion = Console.ReadLine();
            Console.Clear();
            bool deseaEnvio = false;
            if (opcion == "1")
            {
                while (personalizado)
                {
                    Console.WriteLine("\nOpciones de personalización:");
                    Console.WriteLine("1. Agregar Estuche Lujoso");
                    Console.WriteLine("2. Agregar Grabado");
                    Console.WriteLine("3. Agregar Seguro");
                    Console.WriteLine("4. Finalizar personalización");

                    Console.WriteLine("\nElige una opción:");
                    opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            joya = new _3EstucheDecorador(joya);
                            Console.WriteLine("Estuche lujoso añadido.");
                            break;
                        case "2":
                            joya = new _3GrabadoDecorador(joya);
                            Console.WriteLine("Grabado personalizado añadido.");
                            break;
                        case "3":
                            joya = new _3SeguroDecorador(joya);
                            Console.WriteLine("Seguro de protección añadido.");
                            break;
                        case "4":
                            personalizado = false;
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente de nuevo.");
                            break;

                    }
                    Console.ReadKey();
                    Console.Clear();

                }
                Console.WriteLine("¿Te gustaria un envio a domicilio?");
                Console.WriteLine("1. Sí/\n2. No");
                Console.WriteLine("Elige una opción:");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        deseaEnvio = true;
                        if (deseaEnvio)
                        {
                            joya = new _3EnvioDecorador(joya);
                        }
                        break;
                    case "2":
                        deseaEnvio = false;
                        Console.WriteLine("¡Disfruta tu pedido!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("¿Deseas aplicar bonificación por material?");
            Console.WriteLine("1. Sí\n2. No");
            opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Console.WriteLine("Ingresa el tipo de material (Oro, Plata, Platino):");
                string material = Console.ReadLine();
                joya = new _4BonificacionMaterial(joya, material);
                Console.Clear();
            }

            Console.WriteLine("¿Deseas aplicar bonificación por temporada?");
            Console.WriteLine("1. Sí\n2. No");
            opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Console.WriteLine("Ingresa la temporada (Navidad, San Valentín, Verano):");
                string temporada = Console.ReadLine();
                joya = new _4BonificacionTemporada(joya, temporada);
                Console.Clear();
            }

            Console.WriteLine("¿Cuántas piezas deseas comprar?");
            int cantidad = int.Parse(Console.ReadLine());
            joya = new _4BonificacionCantidad(joya, cantidad);
            Console.Clear();

            Console.WriteLine("¿Deseas ver el resumen en otro idioma?");
            Console.WriteLine("1. Español\n2. Ingles");
            Console.WriteLine("Elige una opción:");
            opcion = Console.ReadLine();
            string etiquetaIdioma = "";

            _5nterfazInternacionalAdaptador joyaTraducida;

            switch (opcion)
            {
                case "1":
                    joyaTraducida = new _6AdaptadorEspañol(joya);
                    etiquetaIdioma = "EN ESPAÑOL";
                    break;
                case "2":
                    joyaTraducida = new _6AdaptadorIngles(joya);
                    etiquetaIdioma = "IN ENGLISH";
                    break;
                default:
                    Console.WriteLine("Idioma no reconocido. Se mostrará en español.");
                    joyaTraducida = new _6AdaptadorEspañol(joya);
                    etiquetaIdioma = "EN ESPAÑOL";
                    break;
            }

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"---\t\t\tORDER SUMMARY ({etiquetaIdioma})\t\t---");
            Console.WriteLine("-------------------------------------------------------------------");
            joyaTraducida.MostrarDescripcion();
            joyaTraducida.MostrarCosto();

            Console.WriteLine("\nThank you for your purchase. Come back soon to Joyeria Chula Vista!");
            Console.WriteLine();

            double total = joya.Costo;
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"---\t\t\tRESUMEN DE TU PEDIDO\t\t\t---");
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine(joya.Descripcion);
            Console.WriteLine($"\nTOTAL A PAGAR\t\t\t${total}");
            Console.WriteLine("\nGracias por tu compra. ¡Vuelve pronto a Joyeria Chula Vista!");

            Console.ReadKey();

        }
    }
}
