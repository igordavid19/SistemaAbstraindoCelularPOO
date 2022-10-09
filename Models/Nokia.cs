namespace SistemaAbstraindoCelularPOO.Models

{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        public override void InstalarAplicativo(string nomeApp)
        {
            if(VerificarAplicativo(nomeApp))
            {
                Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Smartphone Nokia");
            }
        }

        public sealed override void ExibirConfiguracoes()
        {
            Console.WriteLine($"As configurações do Nokia {Modelo} são: {Memoria} gigas de armazenamento e IMEI: {IMEI}");
        }
    }
}