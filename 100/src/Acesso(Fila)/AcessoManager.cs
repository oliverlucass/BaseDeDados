namespace BaseDeDados.Acesso;

public class AcessoManager
{
    
    Queue<Acesso> fila = new Queue<Acesso>();

    public void AdicionarAcessoParaUsuario()
    {
        Console.Clear();

        Acesso newAcesso = new Acesso();
        
        Console.WriteLine("Digite o nome do Usuário à adicionar acesso");
        newAcesso.UsuarioName = Console.ReadLine();
        Console.WriteLine("Escolha o Sistema à liberar acesso");
        newAcesso.Sistema = Console.ReadLine();
        newAcesso.DataRequisicao = DateTime.Now;
        
        fila.Enqueue(newAcesso);

        int idCount = 0;


        foreach(Acesso a in fila){
            idCount++;
        }  

        newAcesso.Id = idCount;

        Console.ReadLine();
    }

    public void LiberarPrimeiroAcessoDaFila()
    {
        Console.Clear();

        Console.WriteLine($"Acesso liberado para### {fila.Peek().UsuarioName} \n");
        fila.Dequeue();
        Console.WriteLine(fila.Count + " Acesso(s) na fila");
        

        Console.ReadLine();
    }

    public void RemoverPrimeiroAcessoDaFila()
    {
        Console.Clear();
        
        int count = 0;

        foreach(Acesso a in fila)
        {
            count++;
        }
        
        fila = new Queue<Acesso>(fila.Where((value, index) => index == count));

        Console.ReadLine();
    }

    public void LiberarTodosOsAcessosDaFila()
    {
        Console.Clear();

        int count = 0;
        
        foreach(Acesso a in fila)
        {
            count++;
        }

        while(count > 0)
        {
            fila.Dequeue();
            count--;
        }

        Console.ReadLine();
    }


    public void MostrarTodosOsAcessos()
    {
        Console.Clear();

        foreach(Acesso i in fila){
            Console.WriteLine($"ID### {i.Id}");
            Console.WriteLine($"NOME### {i.UsuarioName}");
            Console.WriteLine($"Setor### {i.Sistema}");
            Console.WriteLine($"DATA DA REQUISICAO### {i.DataRequisicao.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("br-BR"))} \n");
        }

        Console.ReadLine();
    }
}