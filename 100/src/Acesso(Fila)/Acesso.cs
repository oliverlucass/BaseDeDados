namespace BaseDeDados.Acesso;

using BaseDeDados.Usuario;

public class Acesso
{
    public int Id { get; set; }
    public string UsuarioName { get; set; }
    public string? Sistema { get; set; }
    public DateTime DataRequisicao { get; set; }
}