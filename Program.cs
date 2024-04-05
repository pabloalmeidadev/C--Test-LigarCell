using Celular.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("1651616132", "Modelo 12", "11111111", 5);
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da Cobrinha");

Smartphone iphone = new Iphone("482849486456", "Modelo 15ProMAx", "88778789879", 128);
iphone.ReceberLigacao();
nokia.InstalarAplicativo("Minecraft");