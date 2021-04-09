using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;
        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto p)
        {
            return string.Format("el producto: {0}, de marca: {1}, tiene un precio de ${2}", p.codigoDeBarra, p.marca, p.precio);
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool result = false;
            if(!(p1 is null) && !(p2 is null))
            {
                if (p1.codigoDeBarra == p2.codigoDeBarra  && p1.marca == p2.marca)
                {
                    result = true;
                }
            }
            return result;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p1, string s)
        {
            bool result = false;
            if (!(p1 is null))
            {
                if (p1.marca == s)
                {
                    result = true;
                }
            }
            return result;
        }
        public static bool operator !=(Producto p1, string s)
        {
            return !(p1 == s);
        }
    }
}
