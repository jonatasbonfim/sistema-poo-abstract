using trilha_poo.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("71 991811031","Iphone 11","123654789", 8);
iphone.Ligar();
iphone.InstalarAplicativo("whatsapp");

Console.WriteLine("");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Smartphone Nokia ");
Smartphone nokia = new Nokia("71 991811031","Nokia","123654789", 4);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("telegram");
