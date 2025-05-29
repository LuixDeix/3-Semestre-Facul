#include <stdio.h>
#include <stdlib.h>
#include <string.h> // Para strcpy

#define MAX 100

// Estrutura da Pilha
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

// Conversão de decimal para binário usando pilha
char* decimal_para_binario(int decimal) {
    Pilha p;
    inicializarPilha(&p);

    // Caso especial para 0
    if (decimal == 0) {
        char *binario_str = (char*) malloc(2 * sizeof(char));
        if (binario_str == NULL) {
            printf("Erro de alocacao de memoria.\n");
            return NULL;
        }
        strcpy(binario_str, "0");
        return binario_str;
    }

    // Divide sucessivamente por 2
    int num = decimal;
    while (num > 0) {
        int resto = num % 2;
        push(&p, resto);
        num = num / 2;
    }

    // Aloca espaço suficiente para a string binária
    char *binario_str = (char*) malloc((p.topo + 2) * sizeof(char));
    if (binario_str == NULL) {
        printf("Erro de alocacao de memoria.\n");
        return NULL;
    }

    int i = 0;
    while (!estaVazia(&p)) {
        binario_str[i] = pop(&p) + '0'; // Converte int (0 ou 1) para char
        i++;
    }
    binario_str[i] = '\0'; // Finaliza a string

    return binario_str;
}

// Função principal para testes
int main(void) {
    int numeros[] = {10, 25, 0, 1, 128, 255, 1024};
    int num_testes = sizeof(numeros) / sizeof(numeros[0]);

    for (int i = 0; i < num_testes; i++) {
        char *binario_result = decimal_para_binario(numeros[i]);
        if (binario_result != NULL) {
            printf("Decimal: %d -> Binario: %s\n", numeros[i], binario_result);
            free(binario_result); // Liberação da memória alocada
        }
    }

    return 0;
}
