using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "654321", modelo: "Modelo 01", imei: "123",memoria: 254);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("--------------------------------------------------");

Console.WriteLine("Smartphone iphone:");
Iphone iphone = new Iphone(numero: "123456", modelo: "Modelo 02", imei: "321",memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tiktok");



