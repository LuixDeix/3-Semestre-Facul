#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

#define MAX 100

// --- Definição da estrutura da pilha ---
typedef struct {
    int itens[MAX];
    int topo;
} Pilha;

// --- Funções básicas da pilha ---
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
    p->itens[++(p->topo)] = valor;
}

int pop(Pilha *p) {
    if (estaVazia(p)) {
        printf("Erro: Pilha vazia\n");
        return -1;
    }
    return p->itens[(p->topo)--];
}

int peek(Pilha *p) {
    if (estaVazia(p)) {
        printf("Erro: Pilha vazia\n");
        return -1;
    }
    return p->itens[p->topo];
}

// --- Avaliação de expressão pós-fixa ---
int avaliar_posfixa(const char *expressao) {
    Pilha p;
    inicializarPilha(&p);

    char *expressao_copia = strdup(expressao);
    if (expressao_copia == NULL) {
        printf("Erro de alocacao de memoria.\n");
        return -1;
    }

    char *token = strtok(expressao_copia, " ");
    while (token != NULL) {
        // Verifica se o token é um número (inteiro)
        if (isdigit(token[0]) || (token[0] == '-' && strlen(token) > 1 && isdigit(token[1]))) {
            push(&p, atoi(token));
        } else {
            if (p.topo < 1) {
                printf("Erro: Expressao mal formatada (poucos operandos para '%s').\n", token);
                free(expressao_copia);
                return -1;
            }

            int op2 = pop(&p);
            int op1 = pop(&p);
            int resultado;

            switch (token[0]) {
                case '+': resultado = op1 + op2; break;
                case '-': resultado = op1 - op2; break;
                case '*': resultado = op1 * op2; break;
                case '/':
                    if (op2 == 0) {
                        printf("Erro: Divisao por zero.\n");
                        free(expressao_copia);
                        return -1;
                    }
                    resultado = op1 / op2;
                    break;
                default:
                    printf("Erro: Operador desconhecido '%s'.\n", token);
                    free(expressao_copia);
                    return -1;
            }
            push(&p, resultado);
        }
        token = strtok(NULL, " ");
    }

    if (estaVazia(&p) || p.topo > 0) {
        printf("Erro: Expressao mal formatada (final da expressao).\n");
        free(expressao_copia);
        return -1;
    }

    int resultado_final = pop(&p);
    free(expressao_copia);
    return resultado_final;
}

// --- Função principal (testes) ---
int main(void) {
    printf("--- Avaliacao de Expressao Pos-fixa ---\n");

    printf("\"2 3 +\" = %d (Esperado: 5)\n", avaliar_posfixa("2 3 +"));
    printf("\"5 10 *\" = %d (Esperado: 50)\n", avaliar_posfixa("5 10 *"));
    printf("\"10 2 /\" = %d (Esperado: 5)\n", avaliar_posfixa("10 2 /"));
    printf("\"15 7 -\" = %d (Esperado: 8)\n", avaliar_posfixa("15 7 -"));
    printf("\"2 3 + 4 *\" = %d (Esperado: 20)\n", avaliar_posfixa("2 3 + 4 *"));
    printf("\"10 2 3 + *\" = %d (Esperado: 50)\n", avaliar_posfixa("10 2 3 + *"));
    printf("\"-5 2 +\" = %d (Esperado: -3)\n", avaliar_posfixa("-5 2 +"));

    printf("\n--- Testes de Erro ---\n");
    printf("\"2 +\" = %d (Esperado: -1 - poucos operandos)\n", avaliar_posfixa("2 +"));
    printf("\"2 3 4 +\" = %d (Esperado: -1 - muitos operandos)\n", avaliar_posfixa("2 3 4 +"));
    printf("\"10 0 /\" = %d (Esperado: -1 - divisao por zero)\n", avaliar_posfixa("10 0 /"));
    printf("\"ABC 3 +\" = %d (Esperado: -1 - operando invalido)\n", avaliar_posfixa("ABC 3 +"));
    printf("\"\" = %d (Esperado: -1 - expressao vazia)\n", avaliar_posfixa(""));
    printf("\"1 2 #\" = %d (Esperado: -1 - operador desconhecido)\n", avaliar_posfixa("1 2 #"));

    return 0;
}
