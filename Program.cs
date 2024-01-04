using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new("37 99132-8778", "Iphone 7", "234324323253232", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("21 2222-222", "G60", "323233232323", 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");