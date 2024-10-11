using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario
{
    internal class Arreglo
    {
        public void ejercicio()
        {
            int[] codigo = new int[10];     //arreglo de 10 posiciones códigos
            string[] producto = new string[10];     //arreglo de 10 posiciones producto
            float[] costo = new float[10];
            int[] cantidad = new int[10];
            costo[2] = 200;
            costo[9] = 500;
            codigo[2] = 50;
            producto[0] = "Teclado";
            producto[2] = "Mouse";
            producto[9] = "Pantalla";
            codigo[9] = 100;

            //imprimir los valores de un arreglo
            for (int i = 0; i < 10; i++)
            {
                //and (&&) or (||) not (!) 
                if (codigo[i] > 0)
                {
                    Console.WriteLine($"Código: {codigo[i]} Producto: {producto[i]} Precio: {costo[i]}");      //interpolación
                }
            }
        
        }
    }
}
