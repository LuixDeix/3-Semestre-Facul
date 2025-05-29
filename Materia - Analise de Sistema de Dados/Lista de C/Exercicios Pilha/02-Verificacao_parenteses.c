#include <stdio.h>
#include <stdlib.h>

#define MAX 100

typedef struct {
    int itens[MAX];
    int topo;
} Pilha;

// Funções da Pilha
void inicializarPilha(Pilha *p) {
    p->topo = -1;
}

int estaVazia(Pilha *p) {
    return (p->topo == -1);
}

int estaCheia(Pilha *p) {
    return (p->topo == MAX - 1);
}

void push(Pilha *p, int valor) {
    if (estaCheia(p)) {
        printf("Erro: Pilha cheia\n");
        return;
    }

    p->topo++;
    p->itens[p->topo] = valor;
}

int pop(Pilha *p) {
    if (estaVazia(p)) {
        printf("Erro: Pilha vazia\n");
        return -1;
    }

    int valor = p->itens[p->topo];
    p->topo--;
    return valor;
}

int peek(Pilha *p) {
    if (estaVazia(p)) {
        printf("Erro: Pilha vazia\n");
        return -1;
    }

    return p->itens[p->topo];
}

// Verifica se os caracteres são pares válidos
int isPar(char charAbertura, char charFechamento) {
    return (charAbertura == '(' && charFechamento == ')') ||
           (charAbertura == '[' && charFechamento == ']') ||
           (charAbertura == '{' && charFechamento == '}');
}

// Verifica se a expressão está balanceada
int balanceamento(const char *expressao) {
    Pilha p;
    inicializarPilha(&p);

    int i = 0;
    while (expressao[i] != '\0') {
        char caractereAtual = expressao[i];

        if (caractereAtual == '(' || caractereAtual == '[' || caractereAtual == '{') {
            push(&p, caractereAtual);
        } else if (caractereAtual == ')' || caractereAtual == ']' || caractereAtual == '}') {
            if (estaVazia(&p)) {
                return 0;
            }
            char topoPilha = pop(&p);
            if (!isPar(topoPilha, caractereAtual)) {
                return 0;
            }
        }

        i++;
    }

    return estaVazia(&p);
}

int main(void) {
    char exp1[] = "{[()]}";
    char exp2[] = "()]";

    printf("Expressao: \"%s\" -> Balanceada: %s\n", exp1, balanceamento(exp1) ? "Sim" : "Nao");
    printf("Expressao: \"%s\" -> Balanceada: %s\n", exp2, balanceamento(exp2) ? "Sim" : "Nao");

    return 0;
}
