using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace envio_mails
{
    class Sistema
    {
        private string nombre;
        private string apellido;
        private int edad;
        private int mPago;
        private int monto;
        List<Persona> listaPersonas = new List<Persona>();
        public void agregarPersona(Persona a)
        {
            this.listaPersonas.Add(a);
        }

        public void opcVenderEntrada()
        {
            Console.Clear();
            monto = 20000;

            Console.WriteLine("Ingrese los siguientes datos:\n");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Edad: ");
            edad = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("\nMetodo De Pago (Ingrese el nro)");
                Console.WriteLine("1. Al contado \n2. Mercado Pago \n3. Tarjeta de credito");
                Console.Write("=> ");
                mPago = int.Parse(Console.ReadLine());
            } while (mPago != 1 && mPago != 2 && mPago != 3);

            Persona datos = new Persona();
            datos.setNombre(nombre);
            datos.setApellido(apellido);
            datos.setEdad(edad);
            datos.setMetodoPago(mPago);
            datos.setMayor(datos.esMayor());
            datos.setNombreMetodoPago(datos.metodoDePago());

            if (mPago == 1)
            {
                monto -= (monto * 50) / 100;
            }
            if (mPago == 2)
            {
                monto -= (monto * 25) / 100;
            }


            datos.setMonto(monto);

            agregarPersona(datos);

        }

        public void opcEnviarMail(string mail)
        {
            int i = 0;
            string cuerpo = "";

            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress(mail));
            email.From = new MailAddress("cosasescolares356@gmail.com", "COPA AMERICA");
            email.Subject = "Entradas vendidas ( " + DateTime.Now.ToString("dd / MMM / yyy / hh:mm") + ") ";
            foreach (Persona persona in listaPersonas)
            {
                i++;
                cuerpo += ("<p>" + i + ". " + persona.getNombre() + "  " + persona.getApellido() + " - " + persona.getMayor() + " - " + persona.getNombreMetodoPago() + " - $" + persona.getMonto() + "<p>" +"\n");
            }
            cuerpo += "Entradas vendidas: " + i;
            email.Body = cuerpo;
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("cosasescolares356@gmail.com", "jomfahpybxgfmpfc");
            smtp.EnableSsl = true;

            string output = null;
            try
            {
                smtp.Send(email);
                email.Dispose();
                output = "Correo electrónico fue enviado satisfactoriamente.";
            }
            catch (Exception ex)
            {
                output = "Error enviando correo electrónico: " + ex.Message;
            }
            Console.WriteLine(output);
        }
    }
}
