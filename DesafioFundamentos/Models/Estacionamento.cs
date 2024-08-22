namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            //IMPLEMENTADO!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            bool menuRemover = true;
            string itemEscolhido = string.Empty;
            string placa = string.Empty;
            
            while (menuRemover)
            {
                int sequencia = 0;
                
                Console.WriteLine("Digite o item da placa do veículo para remover:");
                
                foreach (string itens in veiculos)
                {
                    Console.WriteLine($"{sequencia} - {itens}");
                    sequencia++;
                }

                itemEscolhido = Console.ReadLine();

                try
                {
                    placa = veiculos[Convert.ToInt32(itemEscolhido)];
                    
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    // IMPLEMENTADO COM MELHORIAS
                    int horas = 0;
                    decimal valorTotal = 0; 

                    horas = Convert.ToInt32(Console.ReadLine());

                    valorTotal = precoInicial + precoPorHora * horas;

                    // IMPLEMENTADO!!

                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    menuRemover = false;
                }
                catch
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }

            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // IMPLEMENTADO
                int contador = 0;
                foreach (string itens in veiculos)
                {
                    Console.WriteLine($"{itens}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
