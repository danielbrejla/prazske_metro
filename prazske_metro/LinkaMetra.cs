using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prazske_metro
{
    internal class LinkaMetra
    {
        public string Nazevlinky { get; set; }
        public string[] stanice { get; set; }
        public bool aktivni { get; set; }
        public string barva { get; set; }

        public void vypisVsechnyStanice()
        {
            if (stanice.Length > 0)
            {
                foreach (var jednaStanice in stanice)
                {
                    Console.WriteLine(jednaStanice);
                }
            }
        }
        public void VypisPrvniPosledni()
        {
            if (stanice.Length >= 2)
            {
                Console.WriteLine(stanice[0]);
                Console.WriteLine(stanice[stanice.Length - 1]);
            }
        }
        public void Nastavlinku()
        {
            if (barva == "zelená")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (barva == "červená")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (barva == "žlutá")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (barva == "modrá")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.WriteLine($"VÍTEJ V LINCE METRA {Nazevlinky}");

        } 
    }
     
    
}
