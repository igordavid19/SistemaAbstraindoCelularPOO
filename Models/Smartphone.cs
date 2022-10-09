using System.Text.RegularExpressions;

namespace SistemaAbstraindoCelularPOO.Models

{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }
        private bool SinalDeRede;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Regex numeroCelular = new Regex("^[0-9]{5}-[0-9]{4}$");
            // O Caractere "()" é especial, por isso, precisamos realizar um escape nele com a barra invertida "\".
            // Como essa barra também é considerada como caractere especial, também precisamos realizar um escape nela.
            Regex numeroCelularComDDD = new Regex("^\\([0-9]{2}\\)[0-9]{5}-[0-9]{4}$");
            Regex numeroImei = new Regex("^[0-9]{6}-[0-9]{2}-[0-9]{6}-[0-9]{1}$");
            if (!numeroCelular.IsMatch(numero) && !numeroCelularComDDD.IsMatch(numero))
            {
                bool numeroValido = false;
                while(!numeroValido)
                {
                    Console.WriteLine($"Número {numero} é inválido, por favor, digite um válido, " +
                                      "no formato: 00000-0000 ou (00)00000-0000");
                    numero = Console.ReadLine();

                    if (numeroCelular.IsMatch(numero) || numeroCelularComDDD.IsMatch(numero))
                        numeroValido = true;
                }
            }

            if (!numeroImei.IsMatch(imei))
            {
                bool imeiValido = false;
                while(!imeiValido)
                {
                    Console.WriteLine("Formato de IMEI inválido, por favor, digite um válido, " +
                                      "no formato: 000000-00-000000-0");
                    imei = Console.ReadLine();

                    if (numeroImei.IsMatch(imei))
                        imeiValido = true;
                }
            }
            
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            SinalDeRede = TorreDeTelefone.VerificarSinal();
        }

        public string Ligar()
        {
            if (SinalDeRede)
            {
                return "Ligando...";
            }
            
            return "Não foi possível ligar...";
        }

        // Sobrecarga, mudamos o comportamento do método conforme passamos parâmetros
        public string Ligar(string pessoa)
        {
            string texto = Ligar();
            return texto.Substring(0, texto.Length - 3) + $" para o(a) {pessoa}...";
        }

        public void ReceberLigacao()
        {
            if (SinalDeRede)
            {
                Console.WriteLine("Recebendo ligação...");
            }
            else
            {
                Console.WriteLine("Ligação perdida...");
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public bool VerificarAplicativo(string aplicativo)
        {
            if (SinalDeRede)
            {
                Console.WriteLine($"Aplicativo \"{aplicativo}\" encontrado!");
                return true;
            }
        
            Console.WriteLine($"Aplicativo \"{aplicativo}\" não encontrado!");
            return false;
        }

        public abstract void ExibirConfiguracoes();
    }
}