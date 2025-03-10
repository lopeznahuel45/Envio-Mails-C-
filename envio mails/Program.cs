using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace envio_mails
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Sistema sistema = new Sistema();
            do
            {
                Console.Clear();
                Console.WriteLine("      COPA AMERICA");
                Console.WriteLine(" =======================\n");
                Console.WriteLine("  1.  Vender Entrada");
                Console.WriteLine("  2.  Enviar Mail");
                Console.WriteLine("  0.  Salir");
                Console.WriteLine("\n =======================\n");
                Console.Write("Ingresar opcion => ");
                opc = int.Parse(Console.ReadLine());

                if(opc == 1)
                {
                    sistema.opcVenderEntrada();
                }
                if(opc == 2)
                {
                    string mail;

                    Console.Clear();
                    Console.WriteLine("Indique el mail de destino");
                    Console.Write("Mail: ");
                    mail = Console.ReadLine();
                    sistema.opcEnviarMail(mail);
                }

            } while (opc != 0);
            
        }

        
    }
}
