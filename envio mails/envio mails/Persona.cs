using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace envio_mails
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string mayor;
        private int metodoPago;
        private string nombreMetodoPago;
        private int monto;
        

        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getApellido()
        {
            return apellido;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public int getEdad()
        {
            return edad;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public int getMetodoPago()
        {
            return metodoPago;
        }
        public void setMetodoPago(int metodoPago)
        {
            this.metodoPago = metodoPago;
        }

        public int getMonto()
        {
            return monto;
        }
        public void setMonto(int monto)
        {
            this.monto = monto;
        }

        public void setMayor(string mayor)
        {
            this.mayor = mayor;
        }
        public string getMayor()
        {
            return mayor;
        }

        public void setNombreMetodoPago(string metodo)
        {
            this.nombreMetodoPago = metodo;
        }
        public string getNombreMetodoPago()
        {
            return nombreMetodoPago;
        }

        public string esMayor()
        {
            if (edad >= 18)
            {
                return "Es mayor";
            }
            else
            {
                return "Es menor";
            }
        }

        public string metodoDePago()
        {
            if (metodoPago == 1)
            {
                return "Al contado";
            }
            if (metodoPago == 2)
            {
                return "Mercado Pago";

            }
            if (metodoPago == 3)
            {
                return "Tarjeta de credito";

            }
            else
            {
                return "";
            }
        }

        

    }
}
