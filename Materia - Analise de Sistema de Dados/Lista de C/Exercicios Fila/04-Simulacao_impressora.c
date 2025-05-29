#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>

#define MAX_DOCUMENTOS 5 // Capacidade máxima da fila de documentos
#define MAX_NOME_DOC 50  // Tamanho máximo para o nome do documento

// --- Estrutura para representar um Documento ---
typedef struct
{
    char nome[MAX_NOME_DOC];
    int paginas;
    int pagina_atual; // Guarda a *última página impressa com sucesso* ou 0 se nada foi impresso
} Documento;

// --- Definição da Estrutura da Fila Circular (para Documentos) ---
typedef struct
{
    Documento itens[MAX_DOCUMENTOS];
    int frente;
    int tras;
    int contador;
} FilaDocumentos;

// --- Funções da Fila ---

void inicializarFilaDocumentos(FilaDocumentos *f)
{
    f->frente = 0;
    f->tras = -1;
    f->contador = 0;
}

int estaVaziaDocumentos(FilaDocumentos *f)
{
    return (f->contador == 0);
}

int estaCheiaDocumentos(FilaDocumentos *f)
{
    return (f->contador == MAX_DOCUMENTOS);
}

void enqueueDocumento(FilaDocumentos *f, Documento doc)
{
    if (estaCheiaDocumentos(f))
    {
        printf("Erro: Fila da impressora cheia. Documento '%s' nao pode ser adicionado.\n", doc.nome);
        return;
    }
    f->tras = (f->tras + 1) % MAX_DOCUMENTOS;
    f->itens[f->tras] = doc;
    f->contador++;
    printf("Documento '%s' (%d paginas) adicionado a fila.\n", doc.nome, doc.paginas);
}

Documento dequeueDocumento(FilaDocumentos *f)
{
    Documento docVazia = {"", 0, 0}; // Documento de retorno em caso de erro

    if (estaVaziaDocumentos(f))
    {
        printf("Erro: Fila da impressora vazia. Nao ha documentos para imprimir.\n");
        return docVazia;
    }
    Documento doc = f->itens[f->frente];
    f->frente = (f->frente + 1) % MAX_DOCUMENTOS;
    f->contador--;
    return doc;
}

Documento frontDocumentos(FilaDocumentos *f)
{
    Documento docVazia = {"", 0, 0}; // Documento de retorno em caso de erro

    if (estaVaziaDocumentos(f))
    {
        printf("Erro: Fila da impressora vazia. Nao ha documento na frente.\n");
        return docVazia;
    }
    return f->itens[f->frente];
}

int impressora_com_erro = 0; // 0 = funcionando, 1 = com erro

// --- Função para "Bater na Impressora" ---
// Retorna 1 se o usuário consertou a impressora, 0 caso contrário.
int baterNaImpressora() {
    if (impressora_com_erro) {
        printf("Deseja tentar bater na impressora para consertar? (s/n): ");
        char resposta;
        scanf(" %c", &resposta);
        while (getchar() != '\n'); // Limpa o buffer

        if (resposta == 's' || resposta == 'S') {
            printf("Voce bateu na impressora... e parece que ela voltou a funcionar!\n");
            impressora_com_erro = 0; // Remove o erro
            return 1; // Impressora consertada
        } else {
            printf("Impressora permanece com erro. Nao eh possivel imprimir.\n");
            return 0; // Impressora ainda com erro
        }
    } else {
        printf("Nao ha necessidade de bater na impressora, ela esta funcionando (por enquanto!).\n");
        return 1; // Impressora já estava funcionando
    }
}

// --- Função para Simular a Impressão ---
void imprimirProximoDocumento(FilaDocumentos *f)
{
    if (estaVaziaDocumentos(f))
    {
        printf("Nenhum documento na fila para imprimir.\n");
        return;
    }

    if (impressora_com_erro)
    {
        printf("Impressora com erro! Nao eh possivel imprimir. Tente consertar.\n");
        return;
    }

    // Pega o documento da frente da fila usando um ponteiro para modificá-lo diretamente
    Documento *doc_a_imprimir = &f->itens[f->frente];

    printf("\n--- Imprimindo Documento: '%s' (%d paginas totais) ---\n", doc_a_imprimir->nome, doc_a_imprimir->paginas);

    // Inicia a impressão da *próxima* página a ser impressa (pagina_atual + 1)
    // Se pagina_atual for 0, começa da 1. Se for 3, começa da 4.
    for (int i = doc_a_imprimir->pagina_atual + 1; i <= doc_a_imprimir->paginas; i++)
    {
        // Verifica se a impressora foi posta em erro por algum outro motivo durante o loop
        // (embora neste código, o erro só viria de rand() ou de um "bater" que não consertou)
        if (impressora_com_erro) {
            printf("Impressao de '%s' interrompida na pagina %d (erro persistente).\n", doc_a_imprimir->nome, i - 1);
            // Aqui, a função baterNaImpressora é chamada, e se consertar, o loop continua.
            // Se não consertar, o 'impressora_com_erro' permanece 1, e a condição acima será TRUE na próxima iteração.
            if (!baterNaImpressora()) { // Se o usuário NÃO consertou, saímos do loop
                return;
            }
            // Se consertou, o loop continua e tenta imprimir a mesma página 'i' novamente.
        }

        // 10% de chance de dar erro para a página *atual*
        if (rand() % 10 == 0)
        {
            printf("### ERRO DE IMPRESSAO! Impressora travou na pagina %d de '%s'.\n", i, doc_a_imprimir->nome);
            impressora_com_erro = 1;
            // A 'pagina_atual' fica como 'i-1', pois a página 'i' *não* foi impressa com sucesso.
            // Quando recomeçar, o loop vai de (i-1)+1, ou seja, da página 'i'.
            if (!baterNaImpressora()) { // Se o usuário NÃO consertou, saímos do loop
                return; // Impressora ainda com erro, para a impressão
            }
            // Se o usuário consertou, o loop continua e tenta imprimir a página 'i' novamente.
        }
        printf("Imprimindo '%s' - Pagina %d de %d\n", doc_a_imprimir->nome, i, doc_a_imprimir->paginas);
        doc_a_imprimir->pagina_atual = i; // Salva que esta página foi impressa com sucesso
        // Pequena pausa para simular o tempo de impressão (opcional)
        // #ifdef _WIN32
        // Sleep(50); // Windows
        // #else
        // usleep(50000); // Unix/Linux (50 mil microssegundos = 50ms)
        // #endif
    }

    // Se a impressão chegou até aqui, o documento foi totalmente impresso.
    dequeueDocumento(f); // Remove o documento da fila apenas após a impressão completa
    printf("Documento '%s' impresso com sucesso!\n", doc_a_imprimir->nome);
}

// --- Função Principal de Simulação Interativa ---
int main(void)
{
    FilaDocumentos filaImpressora;
    inicializarFilaDocumentos(&filaImpressora);

    srand(time(NULL)); // Inicializa o gerador de números aleatórios

    int escolha;
    Documento novo_documento;

    printf("--- Simulacao de Fila de Impressora Interativa ---\n");
    printf("Capacidade da fila: %d documentos.\n", MAX_DOCUMENTOS);
    printf("Chances de erro por pagina: 1 em 10.\n\n");

    do {
        printf("\n--- Menu da Impressora ---\n");
        printf("1. Adicionar Documento a Fila\n");
        printf("2. Imprimir Proximo Documento\n");
        printf("3. Verificar Status da Fila\n");
        printf("0. Sair\n");
        printf("Escolha uma opcao: ");
        scanf("%d", &escolha);

        while (getchar() != '\n'); // Limpa o buffer de entrada

        switch (escolha)
        {
            case 1:
                printf("Digite o nome do documento (max %d caracteres): ", MAX_NOME_DOC - 1);
                fgets(novo_documento.nome, MAX_NOME_DOC, stdin);
                novo_documento.nome[strcspn(novo_documento.nome, "\n")] = '\0';

                printf("Digite o numero de paginas: ");
                scanf("%d", &novo_documento.paginas);
                while (getchar() != '\n'); // Limpa o buffer

                if (novo_documento.paginas <= 0) {
                    printf("Numero de paginas invalido. Documento nao adicionado.\n");
                } else {
                    novo_documento.pagina_atual = 0; // Novo documento sempre começa com 0 páginas impressas
                    enqueueDocumento(&filaImpressora, novo_documento);
                }
                break;
            case 2:
                imprimirProximoDocumento(&filaImpressora);
                break;
            case 3:
                printf("\n--- Status da Fila ---\n");
                if (estaVaziaDocumentos(&filaImpressora)) {
                    printf("Fila de impressao esta vazia.\n");
                } else {
                    printf("Documentos na fila: %d\n", filaImpressora.contador);
                    Documento proximo = frontDocumentos(&filaImpressora);
                    if (proximo.paginas != 0) {
                        // Mostra a próxima página a ser impressa
                        printf("Proximo a ser impresso: '%s' (%d paginas totais, proxima pagina: %d)\n",
                               proximo.nome, proximo.paginas, proximo.pagina_atual + 1);
                    }
                }
                printf("Status da Impressora: %s\n", impressora_com_erro ? "COM ERRO" : "Funcionando");
                break;
            case 0:
                printf("Saindo da simulacao. Ate mais!\n");
                break;
            default:
                printf("Opcao invalida. Tente novamente.\n");
                break;
        }
    } while (escolha != 0);

    return 0;
}