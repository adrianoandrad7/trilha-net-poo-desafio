using DesafioPOO.Models;

Console.WriteLine("Smartphone iPhone");
Iphone ip = new Iphone("165525632", "15 PRO","8862", 128);
ip.Ligar();
ip.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Nokia nk = new Nokia("88563279", "Nokia T300", "8974", 64);
nk.ReceberLigacao();
nk.InstalarAplicativo("Instagram");


