namespace Estacionamento.Models;

public class Estacionamento
{
    private Decimal precoInicial { get; set; }
    private Decimal precoPorHora { get; set; }
    private List<Veiculo> veiculos { get; set; }

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
        this.veiculos = new List<Veiculo>();
    }

    public void AdicionaVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        var placa = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Digite o modelo do veículo para estacionar:");
        var modelo = Convert.ToString(Console.ReadLine());
        var veiculo = new Veiculo(placa, modelo);
        veiculos.Add(veiculo);
    }

    public void RemoveVeiculo()
    {
        Console.WriteLine("Digite a placa do veiculo que deseja retirar:");
        var placa = Convert.ToString(Console.ReadLine());
        var veiculo = veiculos.SingleOrDefault(veiculo => veiculo.placa.ToUpper().Equals(placa.ToUpper()));

        if (veiculo != null)
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            var horas = Convert.ToDecimal(Console.ReadLine());
            var valorTotal = precoInicial + precoPorHora * horas;
            veiculos.Remove(veiculo);
            Console.WriteLine($"O {veiculo.modelo} com a placa {veiculo.placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
    }

    public List<Veiculo> ListaTodosOsVeiculos()
    {
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"{veiculo.modelo} - Placa: {veiculo.placa}");
            }
        }
        else
            Console.WriteLine("Não há veículos estacionados.");
        return veiculos;
    }
}