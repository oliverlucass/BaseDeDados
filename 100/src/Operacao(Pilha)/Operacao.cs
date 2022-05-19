namespace BaseDeDados.Operacao;

using BaseDeDados.Usuario;

public class Operacao
{
    public int Id { get; set; }
    public string? Usuario { get; set; }
    public string? Email { get; set; }
    public DateTime DataRequisicao { get; set; }
}