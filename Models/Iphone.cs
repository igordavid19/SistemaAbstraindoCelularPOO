

namespace SistemaAbstraindoCelularPOO.Models

{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        public override void InstalarAplicativo(string nomeApp)
        {
            if(VerificarAplicativo(nomeApp))
            {
                Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\"no iphone");
            }
        }

        public sealed override void ExibirConfiguracoes()
        {
            Console.WriteLine($"As configurações do iPhone {Modelo} são: {Memoria} gigas de armazenamento e IMEI: {IMEI}");
        }
    }
}