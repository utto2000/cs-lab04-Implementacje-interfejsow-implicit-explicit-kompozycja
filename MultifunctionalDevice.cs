using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ver1;

namespace zadanie1
{
    public class MultifunctionalDevice : Copier, IFax, IDevice
    {

        public void SendDocument()
        {
            if (state == IDevice.State.on)
            {
                var date = DateTime.Now;
                IDocument document;
                Scan(out document, IDocument.FormatType.JPG);
                Console.WriteLine("Print faxNumber:");
                var number = Console.ReadLine();
                Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss") + "Fax send to: " + number);
            }



            }
    }
}
