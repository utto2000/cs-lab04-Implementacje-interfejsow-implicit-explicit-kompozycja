using System;
using ver1;
using zadanie1;

class Program	
{
	static void Main()
	{
		var xerox = new Copier();
		xerox.PowerOn();
        IDocument doc1 = new PDFDocument("aaa.pdf");
        xerox.Print(in doc1);

        IDocument doc2;
        xerox.Scan(out doc2,IDocument.FormatType.TXT);
        xerox.ScanAndPrint();
        System.Console.WriteLine(xerox.Counter);
        System.Console.WriteLine(xerox.PrintCounter);
        System.Console.WriteLine(xerox.ScanCounter);
        Console.WriteLine();

        var multifunction = new MultifunctionalDevice();
        multifunction.PowerOff();  
        multifunction.SendDocument();
        multifunction.Print(in doc1);

    }
}
