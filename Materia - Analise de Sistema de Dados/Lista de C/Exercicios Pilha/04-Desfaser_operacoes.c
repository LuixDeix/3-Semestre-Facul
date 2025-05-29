#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_STACK_SIZE 100 // Capacidade máxima da pilha
#define MAX_ACOES 10       // Máximo de ações que podem ser desfeitas

// ===== ESTRUTURA DA PILHA =====
typedef struct {
    int itens[MAX_STACK_SIZE];
    int topo;
} Pilha;

void inicializarPilha(Pilha *p) {
    p->topo = -1;
}

int estaVazia(Pilha *p) {
    return (p->topo == -1);
}

int estaCheia(Pilha *p) {
    return (p->topo == MAX_STACK_SIZE - 1);
}

void push(Pilha *p, int valor) {
    if (estaCheia(p)) {
        printf("Erro: Pilha cheia! Não é possível adicionar mais elementos.\n");
        return;
    }
    p->itens[++p->topo] = valor;
}

int pop(Pilha *p) {
    if (estaVazia(p)) {
        printf("Erro: Pilha vazia! Não há elementos para remover.\n");
        return -1; // Valor sentinela indicando erro
    }
    return p->itens[p->topo--];
}

int peek(Pilha *p) {
    if (estaVazia(p)) {
        printf("Erro: Pilha vazia! Não há elementos para visualizar.\n");
        return -1;
    }
    return p->itens[p->topo];
}

// ===== VARIÁVEIS E DEFINIÇÕES DO EDITOR =====
char conteudoEditor[200] = "Texto inicial. ";
Pilha pilhaDesfazer; // Pilha para armazenar os códigos das ações

// Códigos de ação
#define ACAO_DIGITAR_CARACTERE 1
#define ACAO_DELETAR_CARACTERE 2
#define ACAO_FORMATAR_TEXTO    3

// ===== EXECUTAR UMA AÇÃO NO EDITOR =====
void executarAcao(int codigoAcao, const char *descricaoAcao, const char *alteracaoConteudo) {
    strcat(conteudoEditor, alteracaoConteudo);

    printf("\n--- Executando Ação ---\n");
    printf("Ação: %s (Código: %d)\n", descricaoAcao, codigoAcao);
    printf("Conteúdo atual do editor: \"%s\"\n", conteudoEditor);

    // Empilha o código da ação, respeitando o limite lógico de desfazer
    if (pilhaDesfazer.topo + 1 < MAX_ACOES) {
        push(&pilhaDesfazer, codigoAcao);
    } else {
        printf("Limite de ações para desfazer atingido (%d ações). Ação '%s' não registrada.\n", MAX_ACOES, descricaoAcao);
    }
}

// ===== DESFAZ A ÚLTIMA AÇÃO =====
void desfazerUltimaAcao() {
    int codigo = pop(&pilhaDesfazer);
    if (codigo == -1) return;

    printf("\n--- Desfazendo Ação ---\n");
    printf("Desfazendo ação com código: %d\n", codigo);

    // Simulação de reversão
    switch (codigo) {
        case ACAO_DIGITAR_CARACTERE:
            printf("  -> Ação 'Digitar Caractere' desfeita (simulado).\n");
            break;
        case ACAO_DELETAR_CARACTERE:
            printf("  -> Ação 'Deletar Caractere' desfeita (simulado).\n");
            break;
        case ACAO_FORMATAR_TEXTO:
            printf("  -> Ação 'Formatar Texto' desfeita (simulado).\n");
            break;
        default:
            printf("  -> Ação desconhecida desfeita.\n");
            break;
    }

    printf("Conteúdo do editor após desfazer (simulado): \"...estado anterior...\"\n");
}

// ===== FUNÇÃO PRINCIPAL =====
int main(void) {
    inicializarPilha(&pilhaDesfazer);
    printf("Iniciando editor com texto: \"%s\"\n", conteudoEditor);

    // Simulação de ações
    executarAcao(ACAO_DIGITAR_CARACTERE, "Digitou 'A'", "A");
    executarAcao(ACAO_DIGITAR_CARACTERE, "Digitou 'B'", "B");
    executarAcao(ACAO_DELETAR_CARACTERE, "Deletou último caractere", "(DEL)");
    executarAcao(ACAO_FORMATAR_TEXTO, "Aplicou negrito", " (NEG) ");
    executarAcao(ACAO_DIGITAR_CARACTERE, "Digitou 'C'", "C");

    // Desfazendo ações
    printf("\n--- Testando Desfazer ---\n");
    for (int i = 0; i < 6; i++) {
        desfazerUltimaAcao();
    }

    // Testando limite lógico de desfazer
    printf("\n--- Testando Limite de Ações ---\n");
    inicializarPilha(&pilhaDesfazer);
    strcpy(conteudoEditor, "Resetado. ");

    for (int i = 0; i < MAX_ACOES + 2; i++) {
        char descricao[50];
        sprintf(descricao, "Ação de teste %d", i + 1);
        executarAcao(ACAO_DIGITAR_CARACTERE, descricao, "X");
    }

    printf("\n--- Desfazendo todas as ações do limite ---\n");
    for (int i = 0; i < MAX_ACOES + 2; i++) {
        desfazerUltimaAcao();
    }

    return 0;
}
