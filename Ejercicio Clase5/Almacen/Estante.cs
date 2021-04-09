using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            string mensaje = "";
            int i = 1;
            foreach (Producto p in e.productos)
            {
                if (!(p is null))
                {
                    mensaje += string.Format("Producto N°: {0} \nCodigo de Barra: {1}\tMarca: {2}\tPrecio: {3}\n", i, (string)p, p.GetMarca(), p.GetPrecio());
                }
                i++;
            }
            return string.Format("Ubicacion del estante: {0} \nposee {1} productos\n{2}", e.ubicacionEstante, e.productos.Length, mensaje);
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool result = false;
            foreach (Producto e2 in e.productos)
            {
                if (e2 == p)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static Estante operator -(Estante e, Producto p)
        {

            if (!(e is null) && !(p is null))
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                    }
                }
            }
            return e;
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool result = false;
            if (!(e is null) && !(p is null))
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        break;
                    }
                    else
                    {
                        if (Object.ReferenceEquals(e.productos[i], null))
                        {
                            e.productos[i] = p;
                            result = true;
                            break;
                        }
                    }
                }
            }
            return result;
        }
    }
}
