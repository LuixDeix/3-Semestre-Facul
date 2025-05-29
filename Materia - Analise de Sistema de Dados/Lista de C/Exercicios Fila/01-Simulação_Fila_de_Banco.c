#include <stdio.h> 
#include <stdlib.h> 

#define MAX 100 // Capacidade máxima da nossa estrutura de dados.

// Estrutura.
typedef struct
{
   int itens[MAX];  
   int frente, tras; 
   int tamanho; 
} Fila;

// Inicializa a fila.
void inicializarFila(Fila *f){
    f->frente = 0;
    f->tras = -1;   
    f->tamanho = 0;  // O tamanho inicial é zero.
}

// Verifica se a fila está vazia.
int estaVazia(Fila *f){
    return(f->tamanho == 0); // Retorna verdadeiro (1) se o tamanho for 0, falso (0) caso contrário.
}

// Verifica se a fila está cheia.
int estaCheia(Fila *f){
    return(f->tamanho == MAX); // Retorna verdadeiro (1) se o tamanho atingir o máximo, falso (0) caso contrário.
}

// Adiciona um item ao final da fila .
void enqueue(Fila *f, int valor){
    if(estaCheia(f)){
        printf("A fila está lotada \n");
        return;
    }

    f->tras = (f->tras + 1) % MAX;
    f->itens[f->tras] = valor; // Coloca o valor na posição 'tras' corretamente.
    f->tamanho++; // Incrementa o tamanho da fila.
    printf("Item '%d' entrou na fila. Agora Existem %d itens.\n", valor, f->tamanho);
}

int dequeue(Fila *f){
    if(estaVazia(f)){
        printf("Erro, A fila está vazia \n");
        return -1; // Retorna -1 para indicar que não foi possível remover.
    }

    int valor = f->itens[f->frente]; // Pega o valor que está na "frente" da fila.
    
    f->frente = (f->frente + 1) % MAX;
    
    f->tamanho--; // Reduz o tamanho da fila.
    printf("Item '%d' saiu da fila.\n", valor, f->tamanho);
    return valor; // Retorna o valor que foi removido.
}

// Retorna o item que está no início da fila, sem removê-lo.
int front(Fila *f){
     if(estaVazia(f)){
        printf("A fila está vazia .\n");
        return -1; 
    }
    return f->itens[f->frente]; 
}

int main() {
    Fila minhaFila;
    inicializarFila(&minhaFila); 

    // Adiciona alguns itens na fila
    enqueue(&minhaFila, 22);
    enqueue(&minhaFila, 54);
    enqueue(&minhaFila, 81); 

    dequeue(&minhaFila); // Remove um item.
    dequeue(&minhaFila); // Tenta remover mais um item.

    return 0; 
}
