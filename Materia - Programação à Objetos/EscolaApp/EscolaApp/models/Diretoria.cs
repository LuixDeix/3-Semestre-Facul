namespace models;

public class Diretoria
{
    private Professor Diretor;

    public Diretoria(Professor diretor)
    {
        this.Diretor = diretor;
    }
    public void ExibirDiretoria()
    {
        this.Diretor.ExibirInfo();
    }
}