global using System.Text.RegularExpressions;

namespace BaseDeDados.Usuario;

public class UsuarioManager
{
    public List<Usuario> usuarios = new List<Usuario>();

    public void AdicionarUsuarioNaBase()
    {
        Console.Clear();
        Usuario novoUsuario = new Usuario();

        Console.WriteLine("DIGITE O NOME COMPLETO:");
        string novoUsuarioNome = Console.ReadLine();
        
        // Regex rgx = new Regex(pattern);
        string pattern = @"\s+";
        Regex rgx = new Regex(pattern);
        string replacement = "";
        string result = rgx.Replace(novoUsuarioNome, replacement);
        
        novoUsuario.Nome = result;

        Console.WriteLine("\nDIGITE O CPF:");
        string cpf = Console.ReadLine();
        novoUsuario.CPF = long.Parse(cpf);

        Console.WriteLine("\nDIGITE O EMAIL:");
        novoUsuario.Email = Console.ReadLine();
        
        Console.WriteLine("\nDIGITE A DATA DE NASCIMENTO (DD/MM/AA):");
        novoUsuario.DataDeNascimento = new DateTime(
            int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine())
        );
        
        Console.WriteLine(novoUsuario.DataDeNascimento);
        usuarios.Add(novoUsuario);
        Console.ReadLine();
    }

    public void RemoverUsuarioDaBase()
    {
        Console.Clear();
        Console.WriteLine("DIGITE O NOME DO USUARIO QUE DESEJA REMOVER:");
        string userASerRemovido = Console.ReadLine();

        //Regex ->
        string pattern = @"\s+";
        Regex rgx = new Regex(pattern);
        string replacement = "";
        string result = rgx.Replace(userASerRemovido, replacement);
        
        //<- Regex 


        foreach(Usuario user in usuarios)
        {
            if(user.Nome == result)
            {
                usuarios.Remove(user);
                Console.WriteLine("\n" + user.Nome + " REMOVIDO!");
                break;
            }
        }

        Console.ReadLine();
    }

    public void AlterarUsuarioNaBase()
    {
        Console.Clear();
        Console.WriteLine("DIGITE O CPF DO USUARIO QUE DESEJA ALTERAR:");
        long cpfUserASerRemovido = long.Parse(Console.ReadLine());
        
        foreach(Usuario user in usuarios)
        {
            if(user.CPF == cpfUserASerRemovido)
            {
                Console.WriteLine("\n1 - Nome: " + user.Nome);
                Console.WriteLine("2 - CPF: " + user.CPF);
                Console.WriteLine("3 - Email: " + user.Email);
                Console.WriteLine("4 - Data de Nascimento: " + user.DataDeNascimento + "\n");

                Console.WriteLine("DIGITE O NUMERO DA OPÇAO QUE DESEJA MUDAR:");
                string opcao = Console.ReadLine();

                switch(opcao)
                {
                    case (string) "1":
                        Console.WriteLine("\nDIGITE O NOVO NOME:");
                        string novoNome = Console.ReadLine();

                        string pattern = @"\s+";
                        Regex rgx = new Regex(pattern);
                        string replacement = "";
                        string result = rgx.Replace(novoNome, replacement);


                        user.Nome = result;
                        Console.WriteLine("\nNOVO NOME: " + user.Nome);
                        break;
                    case (string) "2":
                        Console.WriteLine("\nDIGITE O NOVO CPF:");
                        long novoCPF = long.Parse(Console.ReadLine());
                        user.CPF = novoCPF;
                        Console.WriteLine("\nNOVO CPF: " + user.CPF);
                        break;
                    case (string) "3":
                        Console.WriteLine("\nDIGITE O NOVO EMAIL:");
                        string novoEmail = Console.ReadLine();
                        user.Email = novoEmail;
                        Console.WriteLine("\nNOVO EMAIL: " + user.Email);
                        break;
                    case (string) "4":
                        Console.WriteLine("\nDIGITE A NOVA DATA DE NASCIMENTO:");
                        user.DataDeNascimento = new DateTime(
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine())
                        );
                        Console.WriteLine("\nNOVA DATA DE NASCIMENTO: " + user.DataDeNascimento);
                        break;
                }
            }
                Console.ReadLine();
        }   
    }

    public void PesquisarUsuarioNaBase()
    {
        Console.Clear();
        Console.WriteLine("DIGITE O NOME DO USUARIO QUE DESEJA PESQUISAR:");
        string userPesquisado = Console.ReadLine();

        string pattern = @"\s+";
        Regex rgx = new Regex(pattern);
        string replacement = "";
        string result = rgx.Replace(userPesquisado, replacement);

        foreach(Usuario user in usuarios)
        {
            if(user.Nome == result)
            {
                Console.WriteLine("\n" + user.Nome);
                Console.WriteLine(user.CPF);
                Console.WriteLine(user.Email);
                Console.WriteLine(user.DataDeNascimento);
            }
        }
        Console.ReadLine();
    }

    public void ListarTodosOsUsuariosDaBase()
    {
        Console.Clear();
        Console.WriteLine("LISTA DE TODOS OS USUÁRIOS:");
        Console.WriteLine("===================================\n");
        foreach(Usuario user in usuarios)
        {
            Console.WriteLine(user.Nome);
            Console.WriteLine(user.CPF);
            Console.WriteLine(user.Email);
            Console.WriteLine(user.DataDeNascimento);
            Console.WriteLine("*");
        }
        Console.WriteLine("===================================");

        Console.ReadLine();
    }
}
