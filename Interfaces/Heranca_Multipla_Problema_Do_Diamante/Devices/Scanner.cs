using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Multipla_Problema_Do_Diamante.Devices
{
    internal class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing " + document);
        }
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
