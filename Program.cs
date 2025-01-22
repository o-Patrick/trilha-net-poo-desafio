using DesafioPOO.Models;

Console.WriteLine("| Smarthphone Nokia |");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("| Smartphone IPhone |");
Smartphone iphone = new Iphone(numero: "12345678", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
