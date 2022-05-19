namespace BaseDeDados.Operacao;

public class OperacaoManager
{

    Stack<Operacao> pilha = new Stack<Operacao>();

    public void AdicionarNovaOperacao()
    {
        Console.Clear();

        Operacao novaOperacao = new Operacao();

        Console.WriteLine("Digite o nome do Usuario:");
        novaOperacao.Usuario = Console.ReadLine();

        Console.WriteLine("\nDigite o email do Usuario:");
        novaOperacao.Email = Console.ReadLine();    

        novaOperacao.DataRequisicao = DateTime.Now;
        pilha.Push(novaOperacao);

        int idCount = 0;
        foreach(Operacao o in pilha){
            idCount++;
        }

        novaOperacao.Id = idCount;
        Console.WriteLine($"\nID:{novaOperacao.Id}");
        Console.WriteLine(novaOperacao.Usuario);
        Console.WriteLine(novaOperacao.Email);
        Console.WriteLine(novaOperacao.DataRequisicao);

        Console.ReadLine();
    }

    public void DesfazerUltimaOperacao()
    {
        Console.Clear();
        Console.WriteLine($"Acesso liberado para### {pilha.Peek().Usuario} \n");
        pilha.Pop();
        Console.WriteLine(pilha.Count + " Acesso(s) na pilha");

        Console.ReadLine();
    }

    public void RealizarTodasAsOperacaos()
    {
        Console.Clear();
        
        int count = 0;

        foreach(Operacao o in pilha)
        {
            count++;
        }

        Console.WriteLine(count);

        while(count>0){
            pilha.Pop();
            count--;
        }

        Console.WriteLine(count);

        Console.ReadLine();
    }

    public void MostrarPilha()
    {
        Console.Clear();

        Console.WriteLine("Pilha de todos os usuários:\n");

        foreach(Operacao o in pilha)
        {
            Console.WriteLine($"Id### {o.Id}");
            Console.WriteLine($"Nome### {o.Usuario}");
            Console.WriteLine($"Email### {o.Email}");
            Console.WriteLine($"Data Requisição### {o.DataRequisicao} \n");
        }



        Console.ReadLine();

    }

}

   