namespace models;

class EstacionamentoModel
{
    static public List<string> veiculos = new List<string>();
    static public void cadastrar()
    {
        string placa;

        Console.WriteLine("Digite a placa do carro: ");
        placa = Console.ReadLine();
        veiculos.Add(placa);
        Console.WriteLine("Pressione em alguma tecla");
        Console.ReadKey();
        Console.Clear();
    }

    static public void remover(double precoInicial, double precoHora)
    {
        String placa;
        int horas;
        double divida;
        Console.WriteLine("Digite a palaca do carro a remover: ");
        placa = Console.ReadLine();
        Console.WriteLine("Digite quantas horas o veículo ficou estacionado");
        horas = int.Parse(Console.ReadLine());
        divida = (horas * precoHora) + precoInicial;
        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de R$ {divida}");
        veiculos.Remove(placa);
        Console.WriteLine("Pressione em alguam letra");
        Console.ReadKey();
        Console.Clear();
    }

    static public void listar()
    {
        Console.WriteLine("Os veículos estacionados são: ");
        foreach (string carro in veiculos)
        {
            Console.WriteLine($"{carro}");
        }
        Console.WriteLine("Pressione em alguma tecla");
        Console.ReadKey();
        Console.Clear();
    }
}