namespace Estacionamento.Models;

public class Veiculo
{
    public string placa { get; set; }
    public string modelo { get; set; }

    public Veiculo(string placa, string modelo)
    {
        this.placa = placa;
        this.modelo = modelo;
    }
}