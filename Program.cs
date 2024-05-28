using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone celularNokia = new Nokia(numero: "948072990", modelo: " Nokia C30", imei: "359517095710067", memoria: 32 );
celularNokia.InstalarAplicativo("WhatsApp");
celularNokia.Ligar();


Console.WriteLine("Smartphone Iphone: ");
Smartphone celularIphone = new Iphone(numero: "958723695", modelo: "Iphone 13", imei: "359517099609406", memoria: 64);
celularIphone.InstalarAplicativo("Instagram");
celularIphone.ReceberLigacao();