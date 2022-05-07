using System;
using ver1;


public class Copier : BaseDevice, IPrinter, IScanner
{

    public int PrintCounter { get; set; } = 0;
    public int ScanCounter { get; set; } = 0;

   
    public void Print(in IDocument document)
    {
        if (state == IDevice.State.on)
        {
            var date = DateTime.Now;
            Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss") + "Print: " + document.GetFileName());
            PrintCounter++;
        }
    }

    public new void Scan(out IDocument document, IDocument.FormatType formatType = IDocument.FormatType.JPG)
    {
        if(state == IDevice.State.on)
        {
            DateTime date = DateTime.Now;
            switch (formatType)
            {
                case IDocument.FormatType.TXT:
                    document = new TextDocument("TextScan" + ScanCounter + "txt");
                    ScanCounter++;
                    break;

                case IDocument.FormatType.PDF:
                    document = new PDFDocument("PDFScan" + ScanCounter + "pdf");
                    ScanCounter++;
                    break;
                case IDocument.FormatType.JPG:
                    document = new ImageDocument("ImageScan" + ScanCounter + "jpg");
                    ScanCounter++;
                    break;
                default:
                    throw new NotImplementedException();
            }

            Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss") + "Scan: " + document.GetFileName());
        }
        else
        {
            document = null;
        }

    }

    public void ScanAndPrint()
    {
        IDocument document;
        Scan(out document, IDocument.FormatType.JPG);
        Print(document);
    }

  
}


