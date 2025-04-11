
namespace Classes;

public class Aluno
{
    public int Nota1 { get; }
    public int Nota2 { get; }

    public Aluno(int nota1, int nota2)
    {
        Nota1 = nota1;
        Nota2 = nota2;
    }
    public double CalcularMédiaAluno()
    {
        return (Nota1 + Nota2) / 2.0;
    }
}