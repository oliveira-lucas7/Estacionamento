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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string input = Console.ReadLine();

            if(input.Length != 8)
            {
                Console.WriteLine("Placa inválida, insira um número de placa verdadeiro");
                Console.ReadLine();
                if(input.Length != 8)
                {
                    Console.WriteLine("Detectamos atitudes suspeitas, volte para Home!");
                }

            } else {
                Console.WriteLine($"A placa {input} foi adicionada");
                veiculos.Add(input);
            }
        }

                public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");


                string horasStr = Console.ReadLine();

                if (!string.IsNullOrEmpty(horasStr))
                    {
                        if (decimal.TryParse(horasStr, out decimal horas))
                        {
                            decimal precoFinal = precoInicial + (precoPorHora * horas);

                            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {precoFinal}");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Por favor, digite um número decimal válido.");
                        }
                    }
                else
                    {
                        Console.WriteLine("Nenhuma hora digitada.");
                    }

            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string elemento in veiculos)
                    {
                        Console.WriteLine(elemento);
                    }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
