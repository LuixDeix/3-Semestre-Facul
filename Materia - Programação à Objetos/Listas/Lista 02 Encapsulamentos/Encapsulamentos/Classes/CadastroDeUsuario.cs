namespace Models;
public class CadastroDeUsuario
{
    private string Nome;
    private string Senha;

    public CadastroDeUsuario(string nome, string senha)
    {
        if (senha.Length < 8)
        {
            throw new ArgumentException("A senha deve possuir mais de 8 caracteres");
        }
        Nome = nome;
        Senha = senha;
    }
}