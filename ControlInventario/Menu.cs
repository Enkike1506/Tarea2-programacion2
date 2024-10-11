using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario
{
    internal class Menu
    {
        //menu principal
        public static void Principal()
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("1- Inicializar arreglos");
                Console.WriteLine("2- Ingresar artículos");
                Console.WriteLine("3- Modificar artículos");
                Console.WriteLine("4- Borrar artículos");
                Console.WriteLine("5- Consultar artículos");
                Console.WriteLine("6- Buscar un artículo");
                Console.WriteLine("7- Salir");
                Console.WriteLine("Digite una opción:");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Articulos.InicializarArreglos();
                        break;
                    case 2:
                        Articulos.IngresarProductos();
                        break;
                    case 3:
                        Articulos.ModificarProductos();
                        break;
                    case 4:
                        Articulos.ExcluirProductos();
                        break;
                    case 5:
                        Articulos.ConsultarProductos();
                        break;
                    case 6:
                        Articulos.BuscarProducto();
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del sistema");
                        break;
                    default:
                        Console.WriteLine("*** Opción incorrecta ***");
                        break;
                }
            } while (opcion != 7);     //mientras que la opción sea diferente de 7 ==> true
        }
    }
}
