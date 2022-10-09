using SistemaAbstraindoCelularPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99999-8857", modelo: "NK-058", imei: "587986-11-555555-1", memoria: 32);
Console.WriteLine(nokia.Ligar("Igor"));
nokia.InstalarAplicativo("Instagram");
nokia.ExibirConfiguracoes();

Console.WriteLine("===================================");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "98858-5454", modelo: "XS", imei: "587986-11-555555-1", memoria: 128);
iphone.ReceberLigacao();
Console.WriteLine(iphone.Ligar());
iphone.InstalarAplicativo("Pou");
iphone.ExibirConfiguracoes();

TorreDeTelefone.AlternarSinal();
Console.WriteLine("Agora, os processos serão repetidos " + (TorreDeTelefone.VerificarSinal() ? "com " : "sem ") +
                      "sinal, por favor, tecle enter para continuar");
Console.ReadLine();

