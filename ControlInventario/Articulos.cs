using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario
{
    internal class Articulos
    {
        public static int[] id = new int[3]; //código del artículo
        public static string[] nombre = new string[3]; //nombre del artículo
        public static float[] precio = new float[3]; //precio del artículo
        public static int[] cantidad = new int[3]; //cantidad del artículo
        public static int[] bodega = new int[3]; //bodega del artículo

        //Método para inicializar arreglos
        public static void InicializarArreglos()
        {
            for(int i = 0; i < id.Length; i++)
            {
                id[i] = 0;
                nombre[i] = string.Empty;
                precio[i] = 0;
                cantidad[i] = 0;
                bodega[i] = 0;
            }
            Console.WriteLine("Los arreglos han sido inicializados");
            Console.ReadKey();
            Console.Clear();
        }

        //Método para ingresar productos
        public static void IngresarProductos()
        {
            int indice = 0;
            while (indice < id.Length)
            {
                Console.Write("Digite un código: ");
                id[indice] = int.Parse(Console.ReadLine());
                Console.Write("Digite un artículo: ");
                nombre[indice] = Console.ReadLine();
                Console.Write("Digite un precio: ");
                precio[indice] = int.Parse(Console.ReadLine());
                Console.Write("Digite una cantidad: ");
                cantidad[indice] = int.Parse(Console.ReadLine());
                Console.Write("Digite un número de bodega: ");
                bodega[indice] = int.Parse(Console.ReadLine());

                indice++;
                Console.Clear();
            }
            Console.WriteLine("Los artículos han sido ingresados");
            Console.ReadKey();
            Console.Clear();
        }

        //Método para modificar productos
        public static void ModificarProductos()
        {
            Console.Write("Digite el código del artículo que desea modificar: ");
            int nuevoCodigo = int.Parse(Console.ReadLine());
            for (int i = 0; i < id.Length; i++)
            {
                if(nuevoCodigo == id[i])
                {
                    Console.WriteLine($"Código: {id[i]} Nombre: {nombre[i]} Precio: {precio[i]} Cantidad: {cantidad[i]} Bodega: {bodega[i]}");
                    Console.Write("Digite un nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.Write("Digite un precio: ");
                    precio[i] = int.Parse(Console.ReadLine());
                    Console.Write("Digite una cantidad: ");
                    cantidad[i] = int.Parse(Console.ReadLine());
                    Console.Write("Digite un número de bodega: ");
                    bodega[i] = int.Parse(Console.ReadLine());
                    break;
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        
        //Método para eliminar productos
        public static void ExcluirProductos()
        {
            Console.Write("Digite el código del artículo que desea eliminar: ");
            int nuevoCodigo = int.Parse(Console.ReadLine());
            for (int i = 0; i < id.Length; i++)
            {
                if (nuevoCodigo == id[i])
                {
                    Console.WriteLine($"El artículo {nombre[i]} con código {id[i]} será eliminado");
                    id[i] = 0;
                    nombre[i] = string.Empty;
                    precio[i] = 0;
                    cantidad[i] = 0;
                    bodega[i] = 0;
                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        //Método para consultar productos
        public static void ConsultarProductos()
        {
            Console.WriteLine("*** REPORTE DE ARTÍCULOS ***");
            for(int i = 0; i < id.Length; i++)
            {
                Console.WriteLine($"Código: {id[i]} Nombre: {nombre[i]} Precio: {precio[i]} Cantidad: {cantidad[i]} Bodega: {bodega[i]}");
            }
            Console.WriteLine("*** FIN DEL REPORTE ***");
            Console.ReadKey();
            Console.Clear();
        }

        //Método para buscar por código o por nombre
        public static void BuscarProducto()
        {
            Console.Write("Ingrese 1 si desea buscar por código o 2 si desea buscar por nombre: ");
            int buscar = 0;
            buscar = int.Parse(Console.ReadLine());
            if (buscar == 1)
            {
                Console.Write("Ingrese el código del artículo que desea buscar: ");
                int codigoBuscado = 0;
                codigoBuscado = int.Parse(Console.ReadLine());
                for (int i = 0; i < id.Length; i++)
                {
                    if (codigoBuscado == id[i])
                    {
                        Console.WriteLine($"Código: {id[i]} Nombre: {nombre[i]} Precio: {precio[i]} Cantidad: {cantidad[i]} Bodega: {bodega[i]}");
                    }
                }
            }
            else if (buscar == 2)
            {
                Console.Write("Ingrese el nombre del artículo que desea buscar: ");
                string nombreBuscado = string.Empty;
                nombreBuscado = Console.ReadLine();
                for (int i = 0; i < id.Length; i++)
                {
                    if (nombreBuscado == nombre[i])
                    {
                        Console.WriteLine($"Código: {id[i]} Nombre: {nombre[i]} Precio: {precio[i]} Cantidad: {cantidad[i]} Bodega: {bodega[i]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("El número ingresado no es válido");
            }
            Console.ReadKey();
            Console.Clear();
        } 
    }
}
