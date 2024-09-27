using models;
class Estacionamento
{
    public static void Main(String[] args)
    {
        double precoInicial, precoHora;
        int opcao;
        bool keep = true;
        Console.WriteLine("Seja bem-vindo ao MeuPark!");
        Console.WriteLine("Digite o preço inicial: ");
        precoInicial = Double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o preço por hora: ");
        precoHora = Double.Parse(Console.ReadLine());
        Console.Clear();
        while (keep)
        {
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    EstacionamentoModel.cadastrar();
                    break;
                case 2:
                    EstacionamentoModel.remover(precoInicial, precoHora);
                    break;
                case 3:
                    EstacionamentoModel.listar();
                    break;
                case 4:
                    keep = false;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida, tente novamente");
                    break;
            }
        }
    }
}