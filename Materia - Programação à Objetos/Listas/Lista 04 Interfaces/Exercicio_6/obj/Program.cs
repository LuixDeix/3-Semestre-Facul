public class Program
{
    public static void Main(string[] args)
    {
        IImprimivel relatorio = new Relatorio
        {
            Titulo = "Relatório de Vendas",
            Conteudo = "Resumo das vendas do mês de junho."
        };

        IImprimivel contrato = new Contrato
        {
            NomeParte1 = "Empresa ABC Ltda",
            NomeParte2 = "Cliente XYZ"
        };

        relatorio.Imprimir();
        contrato.Imprimir();
    }
}

