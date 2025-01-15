using Dao_CSharp_SQLServer.Model.Dao;
using Dao_CSharp_SQLServer.Service;

class Program 
{
    public static void Main(String[] args) 
    {
       
        Service service = new Service();

        Console.WriteLine("O que você deseja fazer: ");
        Console.WriteLine("Digite 1 para Cadastrar uma pessoa:");
        Console.WriteLine("Digite 2 para Remover uma pessoa:");
        Console.WriteLine("Digite 3 para Listar todas as pessoas:");
        Console.WriteLine("Digite 4 para Atualizar o cadastro de uma pessoa:");
        Console.WriteLine("Digite 5 para Buscar uma pessoa por seu Id:"); 
        int op = int.Parse(Console.ReadLine());

        switch (op) 
        {
            case 1:
                service.insertPessoa();
                break;
            case 2:
                service.deleteByIdPessoa();
                break;
            case 3:
                service.findAllPessoa(); 
                break;
            case 4:
                service.updatePessoa();
                break;
            case 5:
                service.findByIdPessoa();
                break;
            default:
                Console.WriteLine("Opção não encontrada!");
                break;
        }
    }
}