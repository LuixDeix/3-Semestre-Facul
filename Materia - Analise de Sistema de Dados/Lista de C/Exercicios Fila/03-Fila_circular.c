#include <stdio.h>
#include <stdlib.h>

#define MAX 5 

typedef struct
{
    int itens[MAX];
    int frente;     
    int tras;       
    int contador;   
} FilaCircular;

// Inicializa a fila, definindo seus índices para um estado vazio.
void inicializarFilaCircular(FilaCircular *f)
{
    f->frente = 0;
    f->tras = -1; // O 'tras' começa em -1 para indicar que a fila está vazia
    f->contador = 0;
}

// Verifica se a fila circular está vazia.
int estaVazia(FilaCircular *f)
{
    return (f->contador == 0);
}

// Verifica se a fila circular está cheia.
int estaCheia(FilaCircular *f)
{
    return (f->contador == MAX);
}

// Adiciona um elemento (valor) ao final da fila circular (operação de enfileirar).
void enqueue(FilaCircular *f, int valor)
{
    if (estaCheia(f))
    {
        printf("Erro: Fila cheia. Nao eh possivel enfileirar %d\n", valor);
        return;
    }

    // Calcula a nova posição de 'tras' usando o operador módulo para circularidade.
    f->tras = (f->tras + 1) % MAX;
    f->itens[f->tras] = valor;
    f->contador++;
    printf("Enfileirado: %d\n", valor);
}

// Remove e retorna o elemento do início da fila circular (operação de desenfileirar).
int dequeue(FilaCircular *f)
{
    if (estaVazia(f))
    {
        printf("Erro: Fila vazia. Nao ha elementos para desenfileirar.\n");
        return -1; // Retorno de erro padrão para indicar falha na operação
    }

    int valor = f->itens[f->frente]; // Pega o valor do elemento da frente
    // Calcula a nova posição de 'frente' usando o operador módulo para circularidade.
    f->frente = (f->frente + 1) % MAX;
    f->contador--;
    printf("Desenfileirado: %d\n", valor);
    return valor;
}

// Opcional: Retorna o elemento da frente da fila sem removê-lo.
int front(FilaCircular *f)
{
    if (estaVazia(f))
    {
        printf("Erro: Fila vazia. Nao ha elemento na frente.\n");
        return -1;
    }
    return f->itens[f->frente];
}

// --- Função Principal para Teste ---
int main(void)
{
    FilaCircular filaCircular;
    inicializarFilaCircular(&filaCircular);

    printf("--- Teste de Fila Circular ---\n\n");

    printf("Capacidade da fila: %d\n", MAX);
    printf("Fila esta vazia? %s\n", estaVazia(&filaCircular) ? "Sim" : "Nao"); // Deve ser "Sim"

    // Enfileira alguns elementos
    printf("\n--- Enfileirando Elementos ---\n");
    enqueue(&filaCircular, 10);
    enqueue(&filaCircular, 20);
    enqueue(&filaCircular, 30);
    enqueue(&filaCircular, 40);
    enqueue(&filaCircular, 50); // Fila agora está cheia

    printf("Fila esta cheia? %s\n", estaCheia(&filaCircular) ? "Sim" : "Nao"); // Deve ser "Sim"

    // Tenta enfileirar um elemento extra (deve falhar)
    enqueue(&filaCircular, 60);

    // Desenfileira alguns elementos
    printf("\n--- Desenfileirando Elementos ---\n");
    dequeue(&filaCircular); // Remove 10
    dequeue(&filaCircular); // Remove 20

    printf("Fila esta vazia? %s\n", estaVazia(&filaCircular) ? "Sim" : "Nao"); // Deve ser "Nao"

    // Enfileira mais elementos para demonstrar a circularidade
    printf("\n--- Enfileirando mais Elementos (Reutilizacao de Espaco) ---\n");
    enqueue(&filaCircular, 60); // Ocupa o lugar do 10 (índice 0)
    enqueue(&filaCircular, 70); // Ocupa o lugar do 20 (índice 1)

    printf("Elemento na frente: %d\n", front(&filaCircular)); // Deve ser 30

    // Desenfileira o restante dos elementos
    printf("\n--- Esvaziando a Fila ---\n");
    while (!estaVazia(&filaCircular))
    {
        dequeue(&filaCircular);
    }
    printf("\nFila esta vazia? %s\n", estaVazia(&filaCircular) ? "Sim" : "Nao"); // Deve ser "Sim"

    // Tenta desenfileirar de uma fila vazia (deve falhar)
    dequeue(&filaCircular);

    return 0;
}