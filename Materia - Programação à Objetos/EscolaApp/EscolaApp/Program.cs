using Util;
using models;

BancoDeDados banco = new BancoDeDados();

while (true)
{
    Menu.exibir();
    int opcao = Menu.escolherOpcao();
    switch (opcao)
    {
        case 1:
            banco.CadastrarProfessor();
            break;
        case 2:
            banco.CadastrarAluno();
            break;
        case 3:
            banco.CadastrarDiretor();
            break;
        default:
            return;
    }
}