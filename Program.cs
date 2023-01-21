using DesafioPOO.Models;

Smartphone nokia = new Nokia (numero: "123", modelo: "Modelo 1", imei: "111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "789", modelo: "Modelo xr", imei: "999", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
